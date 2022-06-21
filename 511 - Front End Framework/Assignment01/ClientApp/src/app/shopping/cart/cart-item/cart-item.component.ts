import { Component, Input, OnInit } from '@angular/core';
import { Product } from '../../../models/Product';

@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrls: ['./cart-item.component.css']
})
export class CartItemComponent implements OnInit {

  constructor() { }

  @Input() cartItem = Product;

  ngOnInit() {
  }

  
}
