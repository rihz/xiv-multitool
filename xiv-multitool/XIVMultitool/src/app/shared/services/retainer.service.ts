import { Injectable } from "@angular/core";
import { BaseService } from './base.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Retainer, RetainerLabel } from 'src/app/app.models';

@Injectable()
export class RetainerService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }

    getRetainers(userId: string): Observable<Retainer[]> {
        return this.http.get<Retainer[]>(this.uri('/retainer/' + userId), { headers: this.headers });
    }

    addRetainer(retainer: Retainer): Observable<Retainer> {
        return this.http.post<Retainer>(this.uri('/retainer/'), retainer, { headers: this.headers });
    } 

    addLabel(label: RetainerLabel): Observable<RetainerLabel> {
        return this.http.post<RetainerLabel>(this.uri('/retainer/label/'), label, { headers: this.headers });
    }

    deleteLabel(id: number): Observable<any> {
        return this.http.delete<any>(this.uri('/retainer/label/' + id), { headers: this.headers });
    }
}