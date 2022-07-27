import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DenemComponent } from './denem.component';

describe('DenemComponent', () => {
  let component: DenemComponent;
  let fixture: ComponentFixture<DenemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DenemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DenemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
