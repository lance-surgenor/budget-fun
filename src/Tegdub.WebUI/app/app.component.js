"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var fund_service_1 = require('./fund/fund.service');
var AppComponent = (function () {
    function AppComponent(fundService) {
        this.fundService = fundService;
        this.title = 'Tegdub';
    }
    AppComponent.prototype.ngOnInit = function () {
        this.getFunds();
        // this.getFundsRaw();
    };
    AppComponent.prototype.getFunds = function () {
        var _this = this;
        this.fundService.getFunds()
            .then(function (funds) { return _this.funds = funds; });
    };
    AppComponent.prototype.getFundsRaw = function () {
        this.fundService.getFundsRaw()
            .then(function (data) {
            alert("Alert");
            console.error("Error Raw: ", data);
            console.log(data);
            alert("second alert");
        });
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'tegdub',
            template: "\n    <h1>{{title}}\n    <h2>Funds</h2>\n    <ul>\n        <li *ngFor=\"let fund of funds\">\n            Fund: <span>{{fund.name}}</span>\n        </li>\n    </ul>\n    ",
            styles: ["\n    "],
            providers: [
                fund_service_1.FundService
            ]
        }), 
        __metadata('design:paramtypes', [fund_service_1.FundService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map