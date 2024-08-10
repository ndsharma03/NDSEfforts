import { Component, ElementRef, ViewChild } from '@angular/core';
import { MyService } from './new-module/services/my-service.service';
import { DataServiceService } from './new-module/services/data-service.service';
//import { NgModel } from '@angular/forms';
declare let $:any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
    
  title:string;
  data;
  @ViewChild('pActive') paraAction!:ElementRef;
  constructor(private myservice:MyService, private dataService :DataServiceService ){
    this.title = 'AngularPractice ' +this.myservice.GetName("Bittu");
    this.data=dataService.getData();
    console.log(this.title)
  }
  
  btnAbout(){
   $('#pActive').toggle();
    let p =   this.paraAction.nativeElement as HTMLElement;
    console.log(p);
  }
  
}
