import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { FundListComponent } from './fund/fund-list.component';

const routes: Routes = [
    { path: '', redirectTo: '/funds', pathMatch: 'full' },
    { path: 'funds', component: FundListComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {
}