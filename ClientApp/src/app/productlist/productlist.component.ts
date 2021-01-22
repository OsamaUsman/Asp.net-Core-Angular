import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Product } from '../models/product/product.model';
import { ProductRepo } from '../models/product/product.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent  
{
  constructor(public Prepo: ProductRepo,private toaster: ToastrService ) 
  {
    
  }

ngOnInit()
{
  this.Prepo.GetProducts();
}

taxrate :number = 0 ;
categoryfilter :string ;
numcounter :number = 3;
counter(i : number)
{
return new Array(i);
}


populateform(pd : Product)
{
this.Prepo.product = Object.assign({}, pd) ;
}

get sumofprice()
{
return this.Prepo.products.reduce((pre,crr) => pre + crr.price , 0);
}
get Averageofprice()
{
return this.sumofprice / this.Prepo.products.length;
}

OnDelete(id: number)
{
  if(confirm('Are you sure to delete this record?'))
  {
    this.Prepo.DeleteProduct(id).subscribe(res=>
      {
        this.toaster.info("Deleted Successfully","Product Deleted!");
        this.Prepo.GetProducts();
      },
      err =>
      {
        this.toaster.error("Opps! something went wrong..." ,"Error");
        console.log(err);
      } 
    );
  }
}
  
}
