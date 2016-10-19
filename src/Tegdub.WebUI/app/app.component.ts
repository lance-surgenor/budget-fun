import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

// Add a subset of RxJS Observable operators
import './rxjs-operators';

import { Fund } from './fund/fund.model';
import { FundService } from './fund/fund.service';

@Component ({
    selector: 'tegdub',

    template: `
    <h1>{{title}}
    <h2>Funds</h2>
    <ul>
        <li *ngFor="let fund of funds">
            Fund: <span>{{fund.name}}</span>
        </li>
    </ul>
    <div *ngIf="errorMessage">
        <span class='error'>Unable to load funds</span>
        <span class='errorDetail'>{{errorMessage}}</span>
    </div>
    `,

    styles: [`
    .error {
        color: red;
    }
    .errorDetail {
        color: gray;
        font-size: small;
    }
    `],

    providers: [
        FundService
    ]
})

export class AppComponent implements OnInit {
    errorMessage: string;
    title = 'Tegdub';
    funds: Fund[];

    constructor (private fundService:FundService) {
    }

    ngOnInit(): void {
        this.getFunds();
    }

    getFunds(): void {
        this.fundService.getFunds()
                .subscribe(
                    funds => this.funds = funds,
                    error => this.errorMessage = <any>error);
    }
}