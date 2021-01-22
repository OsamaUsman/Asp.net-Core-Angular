import { Component } from "@angular/core";
import { ProductRepo } from "../models/product/product.service";
import { Supplier } from "../models/supplier/supplier.model";
import { SupplierRepo } from "../models/supplier/supplier.service";
import { NgForm } from '@angular/forms';
import { Product } from '../models/product/product.model';
import { ToastrService } from 'ngx-toastr';


@Component({
    selector : 'productform',  
    templateUrl : './productform.component.html',
    styleUrls: ['./productform.component.css']
})

export class ProductForm
{
   constructor( public Prepo : ProductRepo , public Srepo : SupplierRepo ,private toaster :ToastrService) 
   {
   }
   
   ngOnInit(): void
   {
      this.resetForm();
   }
   resetForm()
   {
    this.Prepo.product.id = 0;
    this.Prepo.product.supplierId = 0;
   }

  
 
   
    get buttonText()
    {
       if(this.Prepo.product.id == 0)
       {
        return "Create New";
       }
       else  
       {
        return "Update";
       }
   }
   onSubmit(form : NgForm)
{
    if(this.Prepo.product.id == 0)
    {
        this.PostProduct(form);
    }
    else
    {
    this.PutProuct(form);
    }
}
  
   PostProduct(form: NgForm)
   {
    this.Prepo.PostProduct().subscribe(res => 
    {
        form.reset();
        this.toaster.success("Submitted Successfully","Product Created!");
        this.Prepo.GetProducts();
        

    },
    err =>
    {
        this.toaster.error("Opps! something went wrong..." ,"Error");
        console.log(err);
    }

    );     
   }
   PutProuct(form: NgForm)
   {
    this.Prepo.PutProduct().subscribe
    (
        res=>
        {
          form.reset();
          this.toaster.success("Updated Successfully" ,"Product Updated");
          this.Prepo.GetProducts();  
        },
        err=>
        {
        this.toaster.error("Opps! something went wrong..." ,"Error");
            console.log(err);
        }
    )
   }
  
}


  
