import { Component, Input,OnInit } from '@angular/core';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
@Component({
  selector: 'htmldisplay',
  templateUrl: './htmldisplay.component.html',
  styleUrl: './htmldisplay.component.css'
})
export class HtmldisplayComponent implements OnInit {

  constructor(private sanitizer: DomSanitizer) { }
  @Input('Content')
  content: string ="";
  safeContent: SafeHtml = '';

  num = 5006;


  ngOnInit(): void {

   // this.content = '<section class="content" *ngIf="safeContent" [innerHTML]="safeContent"></section>';
    this.safeContent = this.sanitizer.bypassSecurityTrustHtml(this.content);
    console.log(this.content);
  }
}
