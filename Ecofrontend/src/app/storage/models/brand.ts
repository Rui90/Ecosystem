import { BaseModel } from "src/app/core/base.model";

export class Brand extends BaseModel {

    public createdAt: Date;
    public name: string;

    constructor(data) {
        super(data.id);
        Object.assign(this, data);
    }
}
