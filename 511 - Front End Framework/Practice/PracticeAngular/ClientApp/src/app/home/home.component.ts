import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  Students: Student[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseURL: string) {
    http.get<Student[]>(baseURL + 'api/Student').subscribe(result => {
      this.Students = result;
    }, error => console.error(error));
  }
}



interface Student {
  Id: number;
  Name: string;

}
