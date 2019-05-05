import { BaseEntity } from './ientity';
import { Director } from './director';
import { Actor } from './actor';

export class Movies extends BaseEntity {
    title: string
    name: string
    description: string
    releaseDate: Date
    status: string
    episode: number
    path: string
    quality: string
    time: Date
    country: string
    language: Language
    kind: Number
    genreMovies: Array<any>
    moviesDirectors: Array<any>
    moviesActors: Array<any>
    trailers: Array<any>
    comments: Array<any>
}

export const QUALITY  = [
    {code: "HD", displayName:  "HD"},
    {code: "HDRip", displayName:  "HDRip"},
    {code: "HQ", displayName:  "HQ"},
    {code: "TWO_K", displayName:  "2K"},
    {code: "FOUR_K", displayName:  "4K"},
]

export enum Language {
    ORIGINAL = "Nguyên bản",
    THUYETMINH = "Thuyết Minh",
    LONGTIENG = "Lồng Tiếng",
    VIETSUB = "Viet subtitle"
}

export const Kind = [
    { code: "PhimLe", name: "Phim lẽ" },
    { code: "PhimBo", name: "Phim bộ" },
    { code: "PhimChieuRap", name: "Phim chiếu rạp" },
]

export const DIRECTORS:Director[] = [
    new Director(1, "Steven Spielberg", ""),
    new Director(2, "Alfred Hitchcock", ""),
    new Director(3, "Martin Scorsese", ""),
    new Director(4, "Christopher Nolan", ""),
    new Director(5, "James Cameron", ""),
    new Director(6, "Francis Ford Coppola", ""),
    new Director(7, "Quentin Tarantino", ""),
    new Director(8, "Guy Ritchie", ""),
]

export const ACTORS:Actor[] = [
    new Actor(1, "Jason Statham", ""),
    new Actor(2, "Sylvester Stallone", ""),
    new Actor(3, "Martin Scorsese", ""),
    new Actor(4, "Christopher Nolan", ""),
    new Actor(5, "James Cameron", ""),
    new Actor(6, "Francis Ford Coppola", ""),
    new Actor(7, "Quentin Tarantino", ""),
    new Actor(8, "Guy Ritchie", ""),
]