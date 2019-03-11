import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class UserService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<User[]>(`https://localhost:44362/api/users`);
    }

    getById(id: number) {
        return this.http.get(`https://localhost:44362/api/users/${id}`);
    }

    register(user: User) {
        return this.http.post(`https://localhost:44362/api/users/register`, user);
    }

    update(user: User) {
        return this.http.put(`https://localhost:44362/api/users/${user.id}`, user);
    }

    delete(id: number) {
        return this.http.delete(`https://localhost:44362/api/users/${id}`);
    }
}