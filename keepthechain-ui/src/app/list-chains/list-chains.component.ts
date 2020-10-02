import { Observable } from 'rxjs';

import { Component, OnInit } from '@angular/core';

import { Chain } from '../chain';
import { ChainsService } from '../chains.service';

@Component({
  selector: 'app-list-chains',
  templateUrl: './list-chains.component.html',
  styleUrls: ['./list-chains.component.scss']
})
export class ListChainsComponent implements OnInit {
  chains$: Observable<Chain[]>;

  constructor(private chainsService: ChainsService) { }

  ngOnInit(): void {
    this.chains$ = this.chainsService.getChains();
  }

}
