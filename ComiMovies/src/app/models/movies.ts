import { BaseEntity } from './ientity';

export class Movies extends BaseEntity {
    title : string
    name : string
    description: string
    manufacture: Date
    status: string
    episode: number
    path: string
    quality: Quality
    time: Date
    country: string
    language: Language
    kind: Kind
    genreMovies: Array<any>
    moviesDirectors: Array<any>
    moviesActors: Array<any>
    trailers: Array<any>
    comments: Array<any>
}

export enum Quality {
    HD,
    HDRip
}

export enum Language {
    Vietnamese,
    ThuyetMinh,
    LongTieng,
    VietSub
}

export enum Kind {
    PhimLe,
    PhimBo,
    PhimChieuRap
}