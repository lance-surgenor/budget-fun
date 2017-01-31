import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

// Components
import { AppComponent } from './app.component';
import { FundListComponent } from './fund/fund-list.component';
import { FundDetailComponent } from './fund/fund-detail.component';

// Services
import { FundService } from './fund/fund.service';

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
        FundDetailComponent
    ],
    providers: [FundService],
    bootstrap: [AppComponent]
})

export class AppModule { }