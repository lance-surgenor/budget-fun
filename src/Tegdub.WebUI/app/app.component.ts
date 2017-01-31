import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

// Add a subset of RxJS Observable operators
import './rxjs-operators';

import { Fund } from './fund/fund.model';
import { FundService } from './fund/fund.service';

@Component ({
    selector: 'tegdub',

    template: `
    <h1>{{title}}</h1>
    <a routerLink="/funds" routerLinkActive="selected">Funds</a>
    <router-outlet></router-outlet>
    `,

    styleUrls: ['../styles.css']
})

export class AppComponent {
    title = 'Tegdub';
}