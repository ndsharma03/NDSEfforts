import { Component, Input, } from '@angular/core';
import { NgModel } from '@angular/forms'

@Component({
  selector: 'databindingExample',
  templateUrl: './databiningtest.component.html',
  styleUrl: './databiningtest.component.css'
})
export class DatabiningtestComponent {

  noOfStudent: number = 60;

  strContent: string = 'this is the example of property binding';

  txtValue: string = "Adding value in textbox!";

  hideContent: boolean=true;

  twowayInput: string = "initial two binding text";
  txtChange(event:any):void {
    console.log(event);
    alert(event.target.value);
  }
  btn_click(): void {
    this.hideContent = !this.hideContent;
  }
}
