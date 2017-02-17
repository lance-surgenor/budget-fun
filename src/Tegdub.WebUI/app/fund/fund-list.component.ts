import { Component, OnInit } from '@angular/core';

// Add a subset of RxJS Observable operators
import '../rxjs-operators';

import { Fund } from './fund.model';
import { FundService } from './fund.service';

@Component ({
    moduleId: module.id,
    selector: 'fund-list',
    templateUrl: 'fund-list.component.html',
    styleUrls: ['../../styles.css']
})

export class FundListComponent implements OnInit {
    errorMessage: string;
    selectedFund: Fund;
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

    viewDetail(fund: Fund) : void {
        this.selectedFund = fund;
    }
}