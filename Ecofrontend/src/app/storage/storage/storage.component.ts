import { Component, OnInit } from '@angular/core';
import { Dialog } from 'src/app/core/dialog/dialog.model';
import { DialogService } from 'src/app/core/dialog/dialog.service';

@Component({
  selector: 'app-storage',
  templateUrl: './storage.component.html',
  styleUrls: ['./storage.component.scss']
})
export class StorageComponent implements OnInit {

  showDialog = false;
  dialogService: DialogService;
  dialogOptions: Dialog;
  title = 'Ecofrontend';

  constructor(dialogService: DialogService)  {
    this.dialogService = dialogService;
  }

  ngOnInit(): void {
    this.dialogService.getOpenDialogEvent().subscribe(
      () => {
        if (!this.showDialog) {
          this.dialogOptions = new Dialog();
          this.dialogOptions.title = "Hello world!";
        }
        this.showDialog = !this.showDialog;
      }
    );
  }

}
