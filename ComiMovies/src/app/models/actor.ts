import { BaseEntity } from './ientity';

export class Actor extends BaseEntity {
    name: string
    photo: string
    moviesActors: Array<any>

    constructor(id:number, name:string, photo:string){
        super();
        this.id = id;
        this.name = name;
        this.photo = photo;
    }
}
