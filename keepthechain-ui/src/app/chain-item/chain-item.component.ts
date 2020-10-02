import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-chain-item',
  templateUrl: './chain-item.component.html',
  styleUrls: ['./chain-item.component.scss']
})
export class ChainItemComponent implements OnInit {
  @Input() name: string;

  constructor() { }

  ngOnInit(): void {
  }

}
