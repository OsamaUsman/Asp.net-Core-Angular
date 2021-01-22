import { Product } from "./product.model";
import {HttpClient} from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";

@Injectable()
export class ProductRepo
{
    product: Product = new Product();
   
    products : Product[] = [];
    
    constructor(private http : HttpClient)
    {    
    
    }

   
   GetProducts()
   {
    this.http.get<Product>(environment.apiurl + '/Products/rel?related=true' ).toPromise().then(p => this.products =p as Product[]);
   }
   PostProduct()
   {
     return this.http.post<Product>(environment.apiurl + '/Products/', this.product);
   }
   PutProduct(){
     return  this.http.put<Product>(environment.apiurl + '/Products/' + this.product.id ,this.product );
   }
   DeleteProduct(id: number)
  {
    return  this.http.delete<Product>(environment.apiurl + '/Products/' + id);
  }


}