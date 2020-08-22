import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { AccountSubmitModel } from '../account.models';
import { LocalStorageService } from 'src/app/shared/services/local-storage.service';

@Component({
  selector: 'xiv-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  creds = new AccountSubmitModel();

  constructor(private userService: UserService, 
    private router: Router, private activatedRoute: ActivatedRoute,
    private storageService: LocalStorageService) { }

  ngOnInit(): void {
  }
  
  login() {
    this.userService.login(this.creds.email, this.creds.password)
      .subscribe(result => {
        if (result) {
          this.storageService.addLoginItems(result);

          this.userService.getCharacters().subscribe(characters => {
            if(characters && characters.length > 0) {
              this.storageService.addCharacterItems(characters);
            }
          });

          this.router.navigate(['/']);
        }
      }, errors => {
        console.log('errors', errors);
      });
  }

}
