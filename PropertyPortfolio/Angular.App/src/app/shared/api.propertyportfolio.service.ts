import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import Owner from './owner';

@Injectable()
export default class ApiPropertyPortfolioService {
  public API = 'https://localhost:44334/api';
  public PROPERTY_PORTFOLIO_ENDPOINT = `${this.API}/propertyportfolioapi`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Array<Owner>> {
    return this.http.get<Array<Owner>>(this.PROPERTY_PORTFOLIO_ENDPOINT);
  }
}
