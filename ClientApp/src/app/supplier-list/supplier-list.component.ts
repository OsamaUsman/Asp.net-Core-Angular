import { Component, OnInit } from '@angular/core';
import { SupplierRepo } from '../models/supplier/supplier.service';

@Component({
  selector: 'app-supplier-list',
  templateUrl: './supplier-list.component.html',
  styleUrls: ['./supplier-list.component.css']
})
export class SupplierListComponent implements OnInit {

  constructor(public srepo: SupplierRepo) 
  {

  }

  ngOnInit()
  {
    this.srepo.getSupplier();
  }

}
