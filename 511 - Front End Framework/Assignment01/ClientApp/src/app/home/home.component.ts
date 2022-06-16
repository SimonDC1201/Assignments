import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  Products: Product[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseURL: string) {
    http.get<Product[]>(baseURL = 'api/Product').subscribe(result => {
      this.Products = result;
    }, error => console.error(error));
  }
}
interface Product {
  ProductId: number;
  ProductName: string;
  UnitPrice: number;
}

interface Cart {
  Products: Array<Product>;
  totalPrice: number;
}
