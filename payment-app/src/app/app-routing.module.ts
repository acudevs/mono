import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AccountsummaryComponent } from './accountsummary/accountsummary.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'summary', component: AccountsummaryComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
