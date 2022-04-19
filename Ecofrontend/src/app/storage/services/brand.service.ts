import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/core/base.service';
import { environment } from 'src/environments/environment';
import { Brand } from '../models/brand';

@Injectable({
  providedIn: 'root'
})
export class BrandService extends BaseService<Brand> {

  constructor(
    public http: HttpClient) {
    super(http, environment.api.storageService, "brand");
  }
  
  protected getModelInstance(): Brand {
    return new Brand({});
  }

}
