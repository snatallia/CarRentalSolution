import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarOrderComponent } from './carorder/carorder.component';
import { CarOrderService } from './services/carorder.service'; 
import { AddCarOrderComponent } from './carorder/addcarorder.component';
import { CarComponent } from './car/car.component';
import { CarService } from './services/car.service'; 
import { RouterModule } from '@angular/router';
import { ClientComponent } from './client/client.component';
import { ClientService } from './services/client.service'; 

@NgModule({
  declarations: [
    AppComponent,
    CarOrderComponent,
    AddCarOrderComponent,
    CarComponent,
    ClientComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,    
    HttpClientModule,
    RouterModule.forRoot([
      { path: 'order/add', component: AddCarOrderComponent },
      { path: 'order/edit/:id', component: AddCarOrderComponent},
      { path: 'orders', component: CarOrderComponent },
      { path: 'cars', component: CarComponent },
      { path: 'clients', component: ClientComponent }      
    ])
  ],
  providers: [CarOrderService,CarService, ClientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
