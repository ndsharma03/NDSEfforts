import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent {

  @Input() message: string = 'this is hello word';
 
  @Input() messageToParent: string = "";
  @Output() messageToParentChange = new EventEmitter<string>();

  onchildclick(txtInput: HTMLInputElement) {
    this.messageToParentChange.emit(txtInput.value);
  }
}
