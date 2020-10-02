import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChainItemComponent } from './chain-item.component';

describe('ChainItemComponent', () => {
  let component: ChainItemComponent;
  let fixture: ComponentFixture<ChainItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChainItemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChainItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
