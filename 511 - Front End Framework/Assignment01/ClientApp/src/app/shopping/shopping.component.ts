import { Component, OnInit } from '@angular/core';
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

  ngOnInit() {
    this.shoppingService.getProducts().subscribe(result => {
      this.products = result;
    })
  }

}
