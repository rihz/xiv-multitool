import { Component, OnInit } from '@angular/core';
import { AccountSubmitModel } from '../account.models';
import { UserService } from 'src/app/shared/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'xiv-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  model = new AccountSubmitModel();
  passwordDirty = false;
  emailDirty = false;
  confirmDirty = false;
  confirm = '';
  errors = '';
  
  constructor(private userService: UserService, private router: Router) { }

  get saveDisabled(): boolean {
    return !this.validateConfirm(this.confirm, this.model.password)
      || !this.validateEmail(this.model.email)
      || !this.validatePassword(this.model.password);
  }

  ngOnInit(): void {
  }

  register() {
    this.userService.register(this.model.email, this.model.password);
  }

  validateEmail(value: string) {
    const regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

    return regex.test(value);
  }

  validatePassword(value: string) {
    const regex = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])/;

    return regex.test(value) && value.length > 4;
  }

  validateConfirm(value: string, toConfirm: string) {
    return value === toConfirm;
  }

}
