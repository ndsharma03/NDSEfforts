import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { ChildComponent } from '../child/child.component';
@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrl: './parent.component.css'
})
export class ParentComponent {
  messageToChild: string = "this is message to child";
  messageFromChildP: string = "";

  onParentButtonClick(child: ChildComponent) {
    child.message = this.messageToChild;

  }
  //Another way: by handling event raised by child
  //-----------------------------------------------
  //onMessageChangeAtClient(messageFromChild: string) {
  //  this.messageFromChildP = messageFromChild;

  //}
}
