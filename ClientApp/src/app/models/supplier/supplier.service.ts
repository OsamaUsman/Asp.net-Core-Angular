import { Supplier } from "./supplier.model";
import { Injectable } from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {environment} from "src/environments/environment";
 
@Injectable()
export class SupplierRepo
{
    suppliers  :Supplier[] = [];
    supplier : Supplier = new Supplier();

 constructor(private http: HttpClient)
 {
   this.getSupplier();
 }

 getSupplier()
 {
    this.http.get<Supplier>(environment.apiurl + '/Suppliers' ).toPromise().then(res => this.suppliers = res as Supplier[]);
 }
 postSupplier()
 {
    return this.http.post<Supplier>(environment.apiurl + '/Suppliers' , this.supplier);
 }
 deleteSupplier()
 {
    return this.http.delete<Supplier>(environment.apiurl + '/Suppliers' + this.supplier.id);
 }
}