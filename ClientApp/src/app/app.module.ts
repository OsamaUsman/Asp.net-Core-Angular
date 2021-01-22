import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ProductRepo } from "./models/product/product.service";
import { ProductlistComponent } from './productlist/productlist.component';
import { ProductForm } from './productform/productform.component';
import { Supplier } from './models/supplier/supplier.model';
import { SupplierRepo } from './models/supplier/supplier.service';
import { ToastrModule } from 'ngx-toastr';
import { SupplierCreateComponent } from './supplier-create/supplier-create.component';
import { SupplierListComponent } from './supplier-list/supplier-list.component';
import { MypipePipe } from './pipe/mypipe.pipe';
import { FilterPipe } from './pipe/filter.pipe';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { RegistrationComponent } from './registration/registration.component';


@NgModule({
  declarations: [
    AppComponent,
    ProductlistComponent,
    ProductForm,
    SupplierCreateComponent,
    SupplierListComponent,
    MypipePipe,
    FilterPipe,
    RegistrationComponent
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ToastrModule.forRoot(),
    FontAwesomeModule
    
    
  ],
  providers: [ProductRepo,SupplierRepo],
  bootstrap: [AppComponent]
})
export class AppModule { }
