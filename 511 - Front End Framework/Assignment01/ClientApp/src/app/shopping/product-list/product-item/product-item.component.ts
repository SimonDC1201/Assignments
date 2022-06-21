import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Product } from '../../../models/Product';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.css']
})
export class ProductItemComponent implements OnInit {

  constructor() { }

  @Input() product: Product | undefined;
  @Output() addToCart: EventEmitter<number> = new EventEmitter();

  ngOnInit(): void {
  }

  onAddToCart(productId: number) {
    this.addToCart.emit(this.product.productId);
  }
}
