import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { FundService } from './fund/fund.service';

@NgModule ({
    imports: [
        BrowserModule,
        HttpModule
    ],
    declarations: [
        AppComponent
    ],
    providers: [
        FundService
    ],
    bootstrap: [
        AppComponent
    ]
})

export class AppModule { }