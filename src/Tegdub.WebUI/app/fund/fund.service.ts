import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { Fund } from './fund.model';

@Injectable()
export class FundService {
    private serviceUrl = 'http://localhost:7357/api/funds';

    constructor (private http:Http) {
    }

    getFunds(): Observable<Fund[]> {
        return this.http.get (this.serviceUrl)
                        .map(this.extractData)
                        .catch (this.handleError);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body || { };
    }

    private handleError(error:any): Promise<any> {
        console.error ('Error: ', error);
        return Promise.reject(error.message || error);
    }
}