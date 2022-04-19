import { Component, Input, OnInit } from '@angular/core';
import { Dialog } from 'src/app/core/dialog/dialog.model';

@Component({
  selector: 'app-storage-creation-overlay',
  templateUrl: './storage-creation-overlay.component.html',
  styleUrls: ['./storage-creation-overlay.component.scss'],
  host: { class: "c-storageCreationOverlay" },
})
export class StorageCreationOverlayComponent implements OnInit {
  @Input() options: Dialog;

  constructor() { }

  ngOnInit(): void {
  }
}
