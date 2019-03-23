import { BaseEntity } from './ientity';
import { Movies } from './movies';

export class Trailer extends BaseEntity {
    name: string
    path: string
    moviesId: number
    movies: Movies
}
