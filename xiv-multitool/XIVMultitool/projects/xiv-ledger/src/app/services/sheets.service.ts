import { Injectable } from "@angular/core";
import { BaseService } from '../../../../../src/app/shared/services/base.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SheetModel, MarketTransaction } from '../ledger-sheet/ledger-sheet.model';

@Injectable()
export class SheetService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }

    getSheets(userId: string): Observable<SheetModel[]> {
        const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

        return this.http.get<SheetModel[]>(this.baseUrl + '/sheet/' + userId, { headers });
    }

    addSheet(sheet: SheetModel): Observable<SheetModel> {
        return this.http.post<SheetModel>(this.uri('/sheet'), JSON.stringify(sheet), { headers: this.headers });
    }

    addMarketTransaction(transaction: MarketTransaction): Observable<MarketTransaction> {
        return this.http.post<MarketTransaction>(this.uri('/sheet/' + transaction.sheetId + '/marketTransaction'), JSON.stringify(transaction), { headers: this.headers });
    }

    updateSheet(sheet: SheetModel): Observable<SheetModel> {
        return this.http.put<SheetModel>(this.uri('/sheet'), JSON.stringify(sheet), { headers: this.headers });
    }

    deleteSheet(id: number): Observable<any> {
        return this.http.delete(this.uri('/sheet/' + id), { headers: this.headers });
    }
}