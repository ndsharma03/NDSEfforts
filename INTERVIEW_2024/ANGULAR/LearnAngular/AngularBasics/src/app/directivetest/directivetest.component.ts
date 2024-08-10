import { Component } from '@angular/core';

@Component({
  selector: 'directivetest',
  templateUrl: './directivetest.component.html',
  styleUrl: './directivetest.component.css'
})
export class DirectivetestComponent {

  showHide: boolean = false;
  btn_click(): void {
    this.showHide = !this.showHide;
  }
  stylecolor: string = "black";
  btnChangeStyle(): void {
    this.stylecolor = Math.random() > 0.5 ? "red" : "green";
    
  }
  getColor(): string {
    return this.stylecolor;
  }
}
