import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { ProductComponent } from './product.component';
import { ProductRoutingModule } from './product-routing.module';
import { ListService } from '@abp/ng.core';

@NgModule({
  declarations: [ProductComponent],
  imports: [
    ProductRoutingModule,
    SharedModule
  ],
  providers: [
    ListService
  ]
})
export class ProductModule { }
