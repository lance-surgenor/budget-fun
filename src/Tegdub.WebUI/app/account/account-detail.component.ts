import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location } from '@angular/common';

import { Account } from './account.model';
import { AccountService } from './account.service';

@Component({
    selector: 'account-detail',
    template: `
    <div *ngIf="account">
        <label>Name: </label>
        <input [(ngModel)]="account.name" placeholder="name" />
        <br/>
        <account-transaction-list [account]="account"></account-transaction-list>
    </div>
    `
})

export class AccountDetailComponent implements OnInit {
    @Input()
    account: Account;

    constructor(
        private accountService: AccountService,
        private route: ActivatedRoute,
        private location: Location) {
    }

    ngOnInit(): void {
        this.route.params.forEach((params: Params) => {
            let code = params['code'];
            // this.accountService.getAccount(code)
            //     .then(account => this.account = account);
        });
    }
}