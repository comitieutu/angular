import { BaseEntity } from './ientity';

export class Genre extends BaseEntity {
    name: string
    genreMovies: Array<any>
}
