import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Product } from '../../models/Product';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  constructor() { }

  @Input() products: Product[] = [];
  @Output() addToCart: EventEmitter<number> = new EventEmitter();


  ngOnInit(): void {
  }

  onAddToCart() {

  }

}
