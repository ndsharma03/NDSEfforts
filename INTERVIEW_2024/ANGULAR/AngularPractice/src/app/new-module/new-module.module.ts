import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NewComponentComponent } from './new-component/new-component.component';
import { MyService } from './services/my-service.service';
import { DataServiceService } from './services/data-service.service';
//import { MyService } from './services/my-service.service';



@NgModule({
  declarations: [
    NewComponentComponent,
  ],
  imports: [
    CommonModule
  ],
  providers:[MyService,DataServiceService],
  exports:[NewComponentComponent],
})
export class NewModuleModule { }
