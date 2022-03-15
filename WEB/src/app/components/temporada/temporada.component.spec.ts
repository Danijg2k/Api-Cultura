import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemporadaComponent } from './temporada.component';

describe('TemporadaComponent', () => {
  let component: TemporadaComponent;
  let fixture: ComponentFixture<TemporadaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemporadaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TemporadaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
