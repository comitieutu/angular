import { BaseEntity } from './ientity';

export class Director extends BaseEntity {
    name: string
    photo: string
    moviesDirectors: Array<any>
}
