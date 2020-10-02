import { Observable } from 'rxjs';

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Chain } from './chain';

@Injectable({
  providedIn: 'root'
})
export class ChainsService {

  constructor(private http: HttpClient) { }

  getChains(): Observable<Chain[]> {
    return this.http.get<Chain[]>('https://keepthechainapp.azurewebsites.net/Chains');
  }
}
