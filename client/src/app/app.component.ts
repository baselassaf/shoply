import { HttpClient } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { IPagination } from './models/pagination';
import { IProduct } from './models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Shoply';
  products: IProduct[];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get('https://localhost:5003/api/products?pageSize=18').subscribe((respose: IPagination) => {
    this.products = respose.data;
    }, error => {
      console.log(error);
    });
  }
}
