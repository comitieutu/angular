import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Genre } from '../models/genre';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private httpClient: HttpClient) { }

  getAll() {
    return this.httpClient.get<Genre[]>(`https://localhost:44362/api/genres`);
  }

  create(genre: Genre): any {
    return this.httpClient.post(`https://localhost:44362/api/genres`, genre);
  }
}
