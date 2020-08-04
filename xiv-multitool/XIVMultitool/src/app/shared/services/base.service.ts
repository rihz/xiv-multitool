import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

export abstract class BaseService {
    baseUrl = 'http://localhost:44353/api';
    headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    constructor() {}

    protected handleError(error: any) {
        var appError = error.headers.get('Application-Error');

        if(appError) {
            return Observable.throw(appError);
        }

        var modelStateErrors = '';
        var serverError = error.json();

        if(!serverError.type) {
            for(var key in serverError) {
                if(serverError[key]) {
                    modelStateErrors += serverError[key] + '\n';
                }
            }
        }

        modelStateErrors = modelStateErrors == '' ? null : modelStateErrors;

        return Observable.throw(modelStateErrors || 'Server error');
    }

    protected uri(path: string) {
        return this.baseUrl + path;
    }
}