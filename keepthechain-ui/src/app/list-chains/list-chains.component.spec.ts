import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListChainsComponent } from './list-chains.component';

describe('ListChainsComponent', () => {
  let component: ListChainsComponent;
  let fixture: ComponentFixture<ListChainsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListChainsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListChainsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
