import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DialogComponent } from './dialog/dialog.component';
import { Dialog } from './dialog/dialog.model';

@NgModule({
  declarations: [
    DialogComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    DialogComponent
  ]
})
export class CoreModule { }
