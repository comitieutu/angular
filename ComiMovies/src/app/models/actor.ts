import { BaseEntity } from './ientity';

export class Actor extends BaseEntity {
    name: string
    photo: string
    moviesActors: Array<any>
}
