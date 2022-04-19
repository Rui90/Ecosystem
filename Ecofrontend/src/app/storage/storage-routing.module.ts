import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandComponent } from './storage/child-components/brand/brand.component';
import { StorageComponent } from './storage/storage.component';

const routes: Routes = [
    {
        path: "",
        component: StorageComponent,
        children: [
          {
            path: "",
            redirectTo: "brands",
            pathMatch: "full",
          },
          {
            path: "brands",
            component: BrandComponent,
            data: {
              title: "Brands",
            }
          },
          {
            path: "products",
            component: BrandComponent,
            data: {
              title: "Products",
            }
          }
          
        ],
    },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StorageRoutingModule { 
  
}
