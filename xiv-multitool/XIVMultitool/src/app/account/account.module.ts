import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routing } from './account.routing';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { UserService } from '../shared/services/user.service';
import { SharedModule } from '../shared/shared/shared.module';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { ProfileComponent } from './profile/profile.component';
import { MatStepperModule } from '@angular/material/stepper';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { RetainerDialogComponent } from './profile/retainer-dialog/retainer-dialog.component';
import { FormsModule } from '@angular/forms';
import { MatChipsModule } from '@angular/material/chips';
import { LodestoneDialogComponent } from './profile/lodestone-dialog/lodestone-dialog.component';

@NgModule({
  declarations: [RegisterComponent, LoginComponent, ProfileComponent, RetainerDialogComponent, LodestoneDialogComponent],
  imports: [
    CommonModule,
    SharedModule,
    routing,
    MatButtonModule,
    MatInputModule,
    MatStepperModule,
    MatCardModule,
    MatIconModule,
    FormsModule,
    MatChipsModule
  ],
  providers: [UserService]
})
export class AccountModule { }
