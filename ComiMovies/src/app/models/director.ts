import { BaseEntity } from './ientity';

export class Director extends BaseEntity {

    constructor(id:number, name:string, photo:string){
        super();
        this.id = id;
        this.name = name;
        this.photo = photo;
    }

    name: string
    photo: string
    moviesDirectors: Array<any>
}
