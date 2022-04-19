import { Component, ContentChild, Input, OnInit, TemplateRef } from '@angular/core';
import { Dialog } from './dialog.model';
import { DialogService } from './dialog.service';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.scss'],
  host: { class: "c-dialog" },
})
export class DialogComponent implements OnInit {

  @ContentChild(TemplateRef) public inputElement: TemplateRef<any>;
  @Input() options: Dialog;
  dialogService: DialogService;
  
  constructor(dialogService: DialogService) { 
    this.dialogService = dialogService;
  }

  ngOnInit(): void {
  }

  public close(): void {
    this.dialogService.toggleDialog();
  }

}
