import { Component, OnInit } from '@angular/core';

// Add a subset of RxJS Oservable operators
import '../rxjs-operators';

import { Account } from './account.model';
import { AccountService } from './account.service';

@Component ({
    moduleId: module.id,
    selector: 'account-list',
    templateUrl: 'account-list.component.html',
    styleUrls: ['../../styles.css']
})

export class AccountListComponent implements OnInit {
    errorMessage: string;
    selectedAccount: Account;
    accounts: Account[];

    constructor(private accountService: AccountService){
    }

    ngOnInit(): void {
        this.getAccounts();
    }

    getAccounts(): void {
        this.accountService.getAccounts()
                .subscribe(
                    accounts => this.accounts = accounts,
                    error => this.errorMessage = <any>error);
    }

    viewDetail(account: Account): void {
        this.selectedAccount = account;
    }
}