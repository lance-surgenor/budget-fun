import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

// Components
import { AppComponent } from './app.component';
import { FundListComponent } from './fund/fund-list.component';
import { FundDetailComponent } from './fund/fund-detail.component';
import { AccountListComponent } from './account/account-list.component';
import { AccountDetailComponent } from './account/account-detail.component';
import { AccountTransactionListComponent } from './account/account-transaction-list.component';

// Services
import { FundService } from './fund/fund.service';
import { AccountService } from './account/account.service';

@NgModule ({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        AppRoutingModule
    ],
    declarations: [
        AppComponent,
        FundListComponent,
        FundDetailComponent,
        AccountListComponent,
        AccountDetailComponent,
        AccountTransactionListComponent
    ],
    providers: [
        FundService,
        AccountService],
    bootstrap: [AppComponent]
})

export class AppModule { }