import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import FormattedOwner from './shared/formattedOwner';
let AppComponent = class AppComponent {
    constructor(apiPropertyPortfolioService) {
        this.apiPropertyPortfolioService = apiPropertyPortfolioService;
        this.title = 'Angular';
    }
    ngOnInit() {
        this.apiPropertyPortfolioService.getAll().subscribe(data => {
            this.owners = data;
            // Format the owners into flat object array
            var newFormattedOwners = new Array();
            this.owners.map(function (owner) {
                owner.properties.map(function (property) {
                    var newOwner = new FormattedOwner();
                    newOwner.name = owner.name;
                    newOwner.age = owner.age;
                    newOwner.gender = owner.gender;
                    newOwner.propertyName = property.name;
                    newOwner.propertyType = property.type;
                    newFormattedOwners.push(newOwner);
                    return;
                });
            });
            this.formattedOwners = newFormattedOwners;
        });
    }
};
AppComponent = tslib_1.__decorate([
    Component({
        selector: 'app-root',
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.scss']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map