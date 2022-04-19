import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StorageComponent } from './storage/storage.component';
import { StorageRoutingModule } from './storage-routing.module';
import { BrandComponent } from './storage/child-components/brand/brand.component';
import { StorageCreationOverlayComponent } from './storage/core-components/storage-creation-overlay/storage-creation-overlay.component';
import { CoreModule } from '../core/core.module';

@NgModule({
  declarations: [
    StorageComponent,
    BrandComponent,
    StorageCreationOverlayComponent
  ],
  imports: [
    CommonModule,
    StorageRoutingModule,
    CoreModule
  ]
})
export class StorageModule { }
