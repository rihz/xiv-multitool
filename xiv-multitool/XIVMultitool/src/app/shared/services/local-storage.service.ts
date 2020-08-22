import { Injectable } from "@angular/core";
import { Character } from 'src/app/app.models';

@Injectable()
export class LocalStorageService {
    private keys: string[] = [
        'auth_token',
        'username',
        'userId',
        'email',
        'userIcon'
    ];

    get model(): LocalStorageModel {
        return new LocalStorageModel();
    }

    addLoginItems(result: any) {
        localStorage.setItem('auth_token', result.auth_token);
        localStorage.setItem('username', result.username);
        localStorage.setItem('userId', result.id);
        localStorage.setItem('email', result.email);
    }

    addCharacterItems(characters: Character[]) {
        localStorage.setItem('userIcon', characters[0].icon);
    }

    removeAppItems() {
        this.removeItems(this.keys);
    }

    private removeItems(keys: string[]) {
        keys.forEach((value) => {
            localStorage.removeItem(value);
        });
    }
}

export class LocalStorageModel {
    auth_token = '';
    username = '';
    userId = '';
    email = '';
    userIcon = '';

    constructor() {
        this.auth_token = localStorage.getItem('auth_token');
        this.username = localStorage.getItem('username');
        this.email = localStorage.getItem('email');
        this.userIcon = localStorage.getItem('userIcon');
        this.userId = localStorage.getItem('userId');
    }
}