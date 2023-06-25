import { ListService, PagedResultDto, LocalizationPipe } from '@abp/ng.core';
import { query } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { ProductDto, ProductService, productTypeOptions } from '@proxy/products';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { Confirmation, ConfirmationService, THEME_SHARED_ROUTE_PROVIDERS } from '@abp/ng.theme.shared';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss'],
  providers: [ListService]
})
export class ProductComponent implements OnInit {
  product = { items: [], totalCount: 0 } as PagedResultDto<ProductDto>;
  productTypes = productTypeOptions;
  isModalOpen = false; // trạng thái mở đóng của form
  selectedProduct = {} as ProductDto;
  form: FormGroup;
  constructor(
    public readonly list: ListService, private productService: ProductService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService) { } // inject FormBuilder

  ngOnInit(): void {
    const productStreamCreator = (query) => this.productService.getList(query);
    this.list.hookToQuery(productStreamCreator).subscribe(response => {
      this.product = response;
    })

  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedProduct.name || '', Validators.required],
      category: [this.selectedProduct.category || null, Validators.required],
      description: [this.selectedProduct.description || '', Validators.required],
      price: [this.selectedProduct.price || null, Validators.required]
    })
  }

  createProduct() {
    this.isModalOpen = true;
  }

  // Add editBook method
  editProduct(id: string) {
    console.log(id);

    this.productService.get(id).subscribe((product) => {
      this.selectedProduct = product;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id:string){ 
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) =>
      {

        if (status === Confirmation.Status.confirm){
        this.productService.delete(id).subscribe(() => {
          this.list.get();
        })
        }
      }
    )

  }

  save() {
    if (this.form.invalid) {
      return;
    }

    this.productService.create(this.form.value).subscribe((response) => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    })
  }
}
