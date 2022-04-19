import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DialogService {

  public subject = new Subject();

  public initEvent(): void {
    this.subject = new Subject();
  }

  public toggleDialog(data?: any): void {
    this.subject.next(data);
  }

  public getOpenDialogEvent(): Observable<any> {
    return this.subject.asObservable();
  }

  public destroy(): void {
    this.subject.unsubscribe();
  }
}
