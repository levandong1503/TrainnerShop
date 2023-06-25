import { AuthService, ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ProductDto, ProductService } from '@proxy/products';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }
  product = { items: [], totalCount: 0 } as PagedResultDto<ProductDto>;
  constructor(private authService: AuthService, public readonly list: ListService, private productService: ProductService) { }

  login() {
    this.authService.navigateToLogin();
  }

  public ngOnInit(): void {
    const productStreamCreator = (query) => this.productService.getList(query);
    this.list.hookToQuery(productStreamCreator).subscribe(response => {
      this.product = response;
    })
    console.log(this.product);

  }
}
