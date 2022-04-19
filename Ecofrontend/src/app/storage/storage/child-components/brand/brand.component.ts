import { Component, OnInit } from '@angular/core';
import { DialogService } from 'src/app/core/dialog/dialog.service';
import { Paginated } from 'src/app/core/paginated.model';
import { Brand } from 'src/app/storage/models/brand';
import { BrandService } from 'src/app/storage/services/brand.service';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.scss']
})
export class BrandComponent implements OnInit {

  private brandService: BrandService;
  private dialogService: DialogService;
  public brands: Paginated<Brand>;

  constructor(brandService: BrandService,
    dialogService: DialogService) { 
    this.brands = new Paginated<Brand>();
    this.brandService = brandService;
    this.dialogService = dialogService;
  }

  ngOnInit(): void {
    this.brandService.get().subscribe(
      (data) => {
        this.brands = data;
      }
    );
  }

  public CreateBrand(): void {
    this.dialogService.toggleDialog();
  }
}
