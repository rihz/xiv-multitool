import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { AppPanel } from 'src/app/app.models';
import { LocalStorageService } from '../services/local-storage.service';

@Component({
  selector: 'xiv-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  @Input() apps: AppPanel[];
  
  constructor(public router: Router, public userService: UserService,
    public storageService: LocalStorageService) { }

  ngOnInit(): void {
  }

  goToLogin() {
    this.router.navigate(['/account/register']);
  }

  logout() {
    this.storageService.removeAppItems();

    this.router.navigate(['/']);
  }

}
