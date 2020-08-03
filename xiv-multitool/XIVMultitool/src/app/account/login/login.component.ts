import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { AccountSubmitModel } from '../account.models';

@Component({
  selector: 'xiv-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  creds = new AccountSubmitModel();

  constructor(private userService: UserService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
  }

  login2() {
    console.log(this.creds);
  }
  
  login() {
    this.userService.login(this.creds.email, this.creds.password)
      .subscribe(result => {
        if (result) {
          localStorage.setItem('auth_token', result.auth_token);
          localStorage.setItem('username', result.username);
          localStorage.setItem('userId', result.id);
          localStorage.setItem('email', result.email);

          this.router.navigate(['/']);
        }
      }, errors => {
        console.log('errors', errors);
      });
  }

}
