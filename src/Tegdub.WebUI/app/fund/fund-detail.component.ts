import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location } from '@angular/common';

import { Fund } from './fund.model';
import { FundService } from './fund.service'

@Component({
    selector: 'fund-detail',
    template: `
    <div *ngIf="fund">
        <label>Fund: </label>
        <input [(ngModel)]="fund.name" placeholder="name" />
    </div>
    `
})

export class FundDetailComponent implements OnInit {
    @Input()
    fund: Fund;

    constructor(
        private fundService: FundService,
        private route: ActivatedRoute,
        private location: Location
    ) {
    }

    ngOnInit(): void {
        this.route.params.forEach((params: Params) => {
            let id = +params['id'];
            this.fundService.getFund(id)
                .then(fund => this.fund = fund);
        });
    }
}
