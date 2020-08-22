import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { BaseService } from './base.service';
import { Character } from 'src/app/app.models';
import { LocalStorageService } from './local-storage.service';

@Injectable()
export class UserService extends BaseService {
    baseUrl = 'http://localhost:44353/api';

    _authNavStatusSource = new BehaviorSubject<boolean>(false);
    authNavStatus$ = this._authNavStatusSource.asObservable();

    constructor(private http: HttpClient,
        private router: Router,
        private storageService: LocalStorageService) {
            super();

            this._authNavStatusSource.next(!!this.storageService.model.auth_token);
    }

    get email(): string {
        return this.storageService.model.email;
    }

    get loggedIn(): boolean {
        return !!this.storageService.model.auth_token;
    }

    get userIcon(): string {
        return this.storageService.model.userIcon;
    }

    get userId(): string {
        return this.storageService.model.userId;
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

    logout() {
        this.storageService.removeAppItems();
    }

    getCharacters(): Observable<Character[]> {
        return this.http.get<Character[]>(this.uri('/account/' + this.userId + '/lodestone/'), { headers: this.headers });
    }

    verifyLodestone(characterId: string, code: string): Observable<Character> {
        return this.http.post<Character>(this.uri(`/account/${this.userId}/lodestone/${characterId}/${code}`), { headers: this.headers });
    }
}