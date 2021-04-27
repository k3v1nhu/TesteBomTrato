import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProcessoComponent } from './components/processo/processo.component';

const routes: Routes = [
  { path: '', component: ProcessoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
