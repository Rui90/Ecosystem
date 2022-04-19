export abstract class BaseModel {
    public id: any | undefined;  
    constructor(id?: any) {
      this.id = id;
    }
  }
  