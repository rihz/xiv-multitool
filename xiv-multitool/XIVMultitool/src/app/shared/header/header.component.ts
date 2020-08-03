import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'xiv-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(public router: Router, public userService: UserService) { }

  ngOnInit(): void {
  }

  goToLogin() {
    this.router.navigate(['/account/register']);
  }

}
