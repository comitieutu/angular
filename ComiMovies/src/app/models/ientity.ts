export interface Ientity {
    deleted: boolean
    createdDate: Date
    modifiedDate: Date
}
export abstract class Entity implements Ientity {
    deleted: boolean
    createdDate: Date
    modifiedDate: Date
}
export abstract class BaseEntity extends Entity {
    id: number
}