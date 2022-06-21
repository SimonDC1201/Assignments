import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Product } from '../models/Product';
import { ShoppingService } from '../shopping.service';

@Component({
  selector: 'app-shopping',
  templateUrl: './shopping.component.html',
  styleUrls: ['./shopping.component.css']
})
export class ShoppingComponent implements OnInit {

  constructor(private shoppingService: ShoppingService) { }

  products: Product[] = [];
  cartItems: Product[] = [];

  @Output() addToCart: EventEmitter<number> = new EventEmitter();


  ngOnInit() {
    this.shoppingService.getProducts().subscribe(result => {
      this.products = result;
    });
  }

  onAddToCart(productId: number) {
    let product = this.products.find(p => p.productId == productId);
    if (product) {
      this.cartItems.push(product);
    }
  }

}
