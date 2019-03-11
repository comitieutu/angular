import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Movies } from '../models/movies';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class MovieService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<Movies[]>(`https://localhost:44362/api/users`);
    }

    getById(id: number): Observable<any> {
        return this.http.get(`https://localhost:44362/api/movies/${id}`);
    }
}