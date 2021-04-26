import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProcessosComponent } from './components/processos/processos.component';

const routes: Routes = [
  { path: 'processos', component: ProcessosComponent}
  { path: '', redirectTo: 'processos'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
