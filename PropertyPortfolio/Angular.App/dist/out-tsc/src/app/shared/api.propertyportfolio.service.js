import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
let ApiPropertyPortfolioService = class ApiPropertyPortfolioService {
    constructor(http) {
        this.http = http;
        this.API = 'https://localhost:44334/api';
        this.PROPERTY_PORTFOLIO_ENDPOINT = `${this.API}/propertyportfolioapi`;
    }
    getAll() {
        return this.http.get(this.PROPERTY_PORTFOLIO_ENDPOINT);
    }
};
ApiPropertyPortfolioService = tslib_1.__decorate([
    Injectable()
], ApiPropertyPortfolioService);
export default ApiPropertyPortfolioService;
//# sourceMappingURL=api.propertyportfolio.service.js.map