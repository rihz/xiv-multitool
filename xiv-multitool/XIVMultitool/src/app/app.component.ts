import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AppPanel } from './app.models';
import { UserService } from './shared/services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  apps: AppPanel[] = [
    { path: 'xiv-checklist', logo: '../assets/final-logo.png' },
    { path: 'xiv-ledger', logo: '../assets/ledger-logo.png' }
  ];
  title = 'xiv-multitool';

  constructor(public route: Router,
    private userService: UserService) { }

  get showApps(): boolean {
    return this.route.url === '/';
  }

  testNewUser() {
    const user = { userName: 'test1', email: 'jshields310@gmail.com', password: 'Test123!' };

    this.userService.register(user.email, user.password);
  }

  testLogin() {
    this.userService.login('jshields310@gmail.com', 'Test123!')
      .subscribe(result => {
        if(result) {
          console.log('success!', result);
        }
      }, error => {
        console.log('ERROR', error);
      })
  }
}
