import { Component } from '@angular/core';
import { Product } from "./models/product/product.model";
import { ProductRepo } from "./models/product/product.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent 
{
constructor(private repo: ProductRepo) 
{

}

 
}
