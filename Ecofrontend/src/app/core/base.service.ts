import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs/internal/Observable";
import { BaseModel } from "./base.model";
import { Paginated } from "./paginated.model";

export abstract class BaseService<T extends BaseModel> {
  constructor(protected httpClient: HttpClient, protected host: string, protected endpoint: string) {}

  protected abstract getModelInstance(): T;

  public create(entity: T): Observable<T> {
    return this.httpClient
      .post<T>(`${this.host}/${this.endpoint}`, entity);
  }

  public update(entity: T): Observable<T> {
    return this.httpClient
      .put<T>(
        `${this.host}/${this.endpoint}/${entity.id}`, entity);
  }

  public get(currentPage = 0, pageSize = 10): Observable<Paginated<T>> {
    return this.httpClient
      .get<Paginated<T>>(`${this.host}/${this.endpoint}?currentPage=${currentPage}&pageSize=${pageSize}`);
  }

  public getById(id: string): Observable<T> {
    return this.httpClient
      .get<T>(`${this.host}/${this.endpoint}/${id}`);
  }

  public delete(id: string): Observable<void> {
    return this.httpClient.delete<void>(`${this.host}/${this.endpoint}/${id}`);
  }
}
