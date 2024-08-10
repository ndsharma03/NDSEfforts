import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewModuleModule } from './new-module/new-module.module';
import { MyService } from './new-module/services/my-service.service';


@NgModule({
  declarations: [
    AppComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NewModuleModule
  ],
 // providers: [MyService],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
