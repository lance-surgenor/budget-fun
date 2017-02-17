import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import { Account } from './account.model';
import { Transaction } from '../transaction/transaction.model';

@Injectable()
export class AccountService {
    private serviceUrl = 'http://localhost:7357/api/accounts';

    constructor (private http:Http) {
    }

    getAccounts(): Observable<Account[]> {
        return this.http.get (this.serviceUrl)
                        .map (this.extractData)
                        .catch (this.handleError);
    }

    getAccount(code: string): Promise<Account> {
        return this.getAccounts()[0];
                    // .first(accounts => accounts.find(account => account.code === code))
                    // .then(accounts => accounts.find(account => account.code === code));
    }

    getTransactions(code: string): Observable<Transaction[]> {
        var accountTransactionServiceUrl = this.serviceUrl;
        accountTransactionServiceUrl += "/" + code + "/transactions";
        return this.http.get (accountTransactionServiceUrl)
                        .map (this.extractData)
                        .catch (this.handleError)
    }

    private extractData(res: Response) {
        let body = res.json();
        return body || { };
    }

    private handleError(error:any): Promise<any> {
        console.error('Error: ', error);
        return Promise.reject(error.message || error);
    }
}