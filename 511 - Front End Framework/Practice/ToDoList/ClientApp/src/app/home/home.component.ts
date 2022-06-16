import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  ListItems: Item[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseURL: string) {
    http.get<Item[]>(baseURL + 'api/ToDo').subscribe(result => {
      this.ListItems = result;
    }, error => console.error(error));
  }

}
interface Item {
  Id: number;
  Name: string;
  Description: string;
}
