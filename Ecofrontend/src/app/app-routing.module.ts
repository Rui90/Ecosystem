import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'storage',
    loadChildren: () =>
      import('./storage/storage.module').then(mod => mod.StorageModule)
  },
  {
    path: '',
    loadChildren: () =>
      import('./storage/storage.module').then(mod => mod.StorageModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { 
  
}
