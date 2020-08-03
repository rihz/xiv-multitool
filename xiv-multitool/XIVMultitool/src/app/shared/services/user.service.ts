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

    get loggedIn(): boolean {
        return !!localStorage.getItem('auth_token');
    }

    get userId(): string {
        return localStorage.getItem('userId');
    }

    constructor(private http: HttpClient,
        private router: Router) {
            super();

            this._authNavStatusSource.next(this.loggedIn);
    }

    register(email: string, password: string) {
        const body = JSON.stringify({ email, password });
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        
        this.http.post(this.baseUrl + '/account/register', body, { headers: headers })
            .subscribe(result => {
                if(result) {
                    this.router.navigate(['/account/login']);
                }
            });
    }

    login(email: string, password: string) {
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

        return this.http.post<any>(this.baseUrl + '/account/login', JSON.stringify({ email, password }), { headers });
    }
}