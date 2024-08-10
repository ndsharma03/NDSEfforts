import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ServerComponent } from './server/server.component';
import { DatabiningtestComponent } from './databiningtest/databiningtest.component'
import { DirectivetestComponent } from './directivetest/directivetest.component';
import { ViewchildtestComponent } from './databiningtest/viewchildtest/viewchildtest.component';

const routes: Routes = [
  { path: 'databinding', component: DatabiningtestComponent },
  { path: 'directive', component: DirectivetestComponent },
  { path: 'parentChild', component: ViewchildtestComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
