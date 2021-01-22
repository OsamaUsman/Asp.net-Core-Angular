import { Pipe, PipeTransform } from '@angular/core';
import { ppid } from 'process';
import { Product } from '../models/product/product.model';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(products: Product[],category : string):Product[] 
  {
    // if(category == undefined || category == "All" )
    // {
    //   return products;
    // }
    // else
    // {
    //   return products.filter(p => p.category == category)
    // }
    
    return  (category == undefined || category == "All") ?  products : products.filter(p => p.category == category);   
  }

}
