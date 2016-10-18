import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

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
    `,

    styles: [`
    `],

    providers: [
        FundService
    ]
})

export class AppComponent implements OnInit {
    title = 'Tegdub';
    funds: Fund[];

    constructor (private fundService:FundService) {
    }

    ngOnInit(): void {
        this.getFunds();
        // this.getFundsRaw();
    }

    getFunds(): void {
        this.fundService.getFunds()
                .then(funds => this.funds = funds);
    }

    getFundsRaw(): void {
        this.fundService.getFundsRaw()
                .then(function(data) {
                    alert("Alert");
                    console.error("Error Raw: ", data);
                    console.log(data);
                    alert("second alert");
                })
    }
}