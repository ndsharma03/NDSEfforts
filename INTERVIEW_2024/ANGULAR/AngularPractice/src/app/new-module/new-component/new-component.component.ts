import { Component } from '@angular/core';
import { MyService } from '../services/my-service.service';
//import { MyService } from '../services/my-service.service';

@Component({
  selector: 'app-new-component',
  templateUrl: './new-component.component.html',
  styleUrl: './new-component.component.css'
})
export class NewComponentComponent {
  nameupdated:string;
  fakecontent="this value is coming from .ts(codebehind) file";
  constructor(myservice:MyService){
    this.nameupdated=myservice.GetName(" Niranjan");
    console.log(this.nameupdated);
  }
  // name:string;
  // constructor(myService:MyService){
  //    this.name=myService.GetName('Niranjan');
  // }
}
