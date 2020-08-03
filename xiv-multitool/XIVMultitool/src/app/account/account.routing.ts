import { ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';

export const routing: ModuleWithProviders = RouterModule.forChild([
    { path: 'register', component: RegisterComponent },
    { path: 'login', component: LoginComponent }
]);