import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Movies } from 'src/app/models/movies';

@Injectable({ providedIn: 'root' })
export class DirectorService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Movies[]>(`https://localhost:44362/api/users`);
    }

    getById(id: number): Observable<any> {
        return this.http.get(`https://localhost:44362/api/movies/${id}`);
    }
}