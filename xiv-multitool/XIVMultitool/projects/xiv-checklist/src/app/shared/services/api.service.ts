import { Injectable } from "@angular/core";
import { BaseService } from './base.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ApiService extends BaseService {
    baseUrl = 'http://localhost:44353/api';

    constructor(private http: HttpClient) {
        super();
    }

    get(uri: string): Observable<any> {
        return this.http.get(this.baseUrl + uri);
    }
}