import { Injectable } from "@angular/core";
import { BehaviorSubject } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { BaseService } from './base.service';

@Injectable()
export class UserService extends BaseService {
    baseUrl = 'http://localhost:44353/api';

    _authNavStatusSource = new BehaviorSubject<boolean>(false);
    authNavStatus$ = this._authNavStatusSource.asObservable();

    loggedIn = false;

    constructor(private http: HttpClient,
        private router: Router) {
            super();

            this.loggedIn = !!localStorage.getItem('auth_token');
            this._authNavStatusSource.next(this.loggedIn);
    }

    register(email: string, password: string) {
        const body = JSON.stringify({ email, password });
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        console.log(body);
        this.http.post(this.baseUrl + '/account/register', body, { headers: headers })
            .subscribe(result => {
                if(result) {
                    this.router.navigate(['/login']);
                }
            })
    }
}