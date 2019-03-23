import { Movies } from './movies';
import { BaseEntity } from './ientity';

export class Comment extends BaseEntity {
    content: string
    moviesId: number
    movies: Movies
}
