import { ListService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '@proxy/products';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {
  public id: string;
  public product: any;
  constructor(
    private route: ActivatedRoute,
    public readonly list: ListService,
    private productService: ProductService) { }
  public ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id');
    const productStreamCreator = (query) => this.productService
      .get(query)
      .subscribe(response => this.product = response);
    productStreamCreator(this.id);
  }
}
