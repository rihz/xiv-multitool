import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routing } from './account.routing';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { UserService } from '../shared/services/user.service';
import { SharedModule } from '../shared/shared/shared.module';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';

@NgModule({
  declarations: [RegisterComponent, LoginComponent],
  imports: [
    CommonModule,
    SharedModule,
    routing,
    MatButtonModule,
    MatInputModule
  ],
  providers: [UserService]
})
export class AccountModule { }
