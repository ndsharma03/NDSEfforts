import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Router, RouterLink, RouterLinkActive, RouterModule, RouterOutlet } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServerComponent } from './server/server.component';
import { DatabiningtestComponent } from './databiningtest/databiningtest.component';
import { HtmldisplayComponent } from './htmldisplay/htmldisplay.component'
import { FormsModule } from '@angular/forms';
import { DirectivetestComponent } from './directivetest/directivetest.component';
import { ViewchildtestComponent } from './databiningtest/viewchildtest/viewchildtest.component';
//import { ParentComponent } from './databiningtest/parent/parent.component';
//import { ChildComponent } from './databiningtest/child/child.component';
import { HtmlInCodeBehindComponent } from './html-in-code-behind/html-in-code-behind.component';
import { ParentComponent } from './componentcomm/parent/parent.component';
import { ChildComponent } from './componentcomm/child/child.component';

@NgModule({
  declarations: [
    AppComponent,
    ServerComponent,
    DatabiningtestComponent,
    HtmldisplayComponent,
    DirectivetestComponent,
    ViewchildtestComponent,
    ParentComponent,
    ChildComponent,
    HtmlInCodeBehindComponent,
       
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterOutlet,
    RouterLink,
    RouterLinkActive
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
