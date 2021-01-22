import { Component, NgModule, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

import {  ToastrService } from 'ngx-toastr';
import { SupplierRepo } from '../models/supplier/supplier.service';

@Component({
  selector: 'app-supplier-create',
  templateUrl: './supplier-create.component.html',
  styleUrls: ['./supplier-create.component.css']
})
export class SupplierCreateComponent implements OnInit {

  constructor(public srepo : SupplierRepo ,private toaster :ToastrService) 
  { 

  }

  ngOnInit()
  {
    this.srepo.supplier.id = 0;
  }

  onSubmit(form : NgForm)
  {
    

    if(this.srepo.supplier.id == 0)
    {
      this.PostSupplier(form);
    }
    
  }

PostSupplier(form :NgForm)
{
  this.srepo.postSupplier().subscribe(res => {
    form.reset();
    this.toaster.success("Your Supplier is submitted","Supplier Created");
    this.srepo.getSupplier();
  },
  err=>
  {
    this.toaster.error("Opps! Something went wromg","Error");
    console.log(err);
  });
}

}




