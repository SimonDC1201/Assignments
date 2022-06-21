import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Product } from '../../models/Product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  constructor() { }

  @Input() products: Product[] = [];
  @Output() addToCart: EventEmitter<number> = new EventEmitter();

  ngOnInit(): void {
  }

  onAddToCart(productId: number) {
    this.addToCart.emit(productId);
  }
}
