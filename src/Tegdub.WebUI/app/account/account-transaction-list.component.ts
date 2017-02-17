import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location } from '@angular/common';

// Add a subset of RxJS Observable operators
import '../rxjs-operators';

import { Transaction } from '../transaction/transaction.model';
import { Account } from './account.model';
import { AccountService } from './account.service';

@Component ({
    moduleId: module.id,
    selector: 'account-transaction-list',
    templateUrl: 'account-transaction-list.component.html',
    styleUrls: ['../../styles.css']
})

export class AccountTransactionListComponent {
    errorMessage: string;
    selectedTransaction: Transaction;
    transactions: Transaction[];

    _account: Account;
    @Input()
    set account(account: Account) {
        this._account = account;
        this.getTransactions(account);
    }
    get account(): Account {
        return this._account;
    }

    constructor (
        private accountService: AccountService,
        private route: ActivatedRoute,
        private location: Location) {
    }

    getTransactions(account: Account) {
        this.accountService.getTransactions(account.code)
            .subscribe(
                transactions => this.transactions = transactions,
                error => this.errorMessage = <any>error);
    }

    viewTransactionDetail(transaction: Transaction) {
        this.selectedTransaction = transaction;
    }
}