import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Fund } from './fund.model';

@Injectable()
export class FundService {
    private serviceUrl = 'http://localhost:7357/api/funds';

    constructor (private http:Http) {
    }

    getFunds(): Promise<Fund[]> {
        return this.http.get (this.serviceUrl)
                        .toPromise()
                        .then(response => response.json())
                        .catch (this.handleError);
    }

    getFundsRaw() {
        return this.http.get(this.serviceUrl)
                        .toPromise()
                        .then(response => response.text())
                        .catch(this.handleErrorRaw);
    }

    private handleError(error:any): Promise<any> {
        console.error ('Error: ', error);
        return Promise.reject(error.message || error);
    }

    private handleErrorRaw(error:any): Promise<any> {
        console.error('Error Raw: ', error);
        return Promise.reject("Promise rejected: " + error);
    }
}