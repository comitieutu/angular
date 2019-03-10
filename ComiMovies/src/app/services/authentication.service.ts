import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { map, tap, catchError } from 'rxjs/operators';

import { User } from '../models/user';
import { UserViewModel } from '../view-models/user-view-model';

const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json'
    })
  };

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUserSubject: BehaviorSubject<User>;
    public currentUser: Observable<User>;

    constructor(private http: HttpClient) {
        this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
    }

    public get currentUserValue(): User {
        return this.currentUserSubject.value;
    }

    login(email: string, password: string) : Observable<any> {
        var userViewModel = {
            'Email': email,
            'Password': password
        };
        // userView.Email = email;
        // userView.Password = password;
        
        return this.http.post<any>(`https://localhost:44362/api/users/authenticate`, { userViewModel }, httpOptions)
            .pipe(
              map(res => {
                  if (res.result && res.result.token) {
                      localStorage.setItem('currentUser', JSON.stringify(res.result));
                      this.currentUserSubject.next(res.result);
                  }

                  return res.result;
              }));
    }

    logout() {
        // remove user from local storage to log user out
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
    
    private handleError<T> (operation = 'operation', result?: T) {
        return (error: any): Observable<T> => {
      
          // TODO: send the error to remote logging infrastructure
          console.error(error); // log to console instead
      
          // Let the app keep running by returning an empty result.
          return of(result as T);
        };
      }
}