import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EHPCalculatorComponent } from './ehpcalculator.component';

describe('EHPCalculatorComponent', () => {
  let component: EHPCalculatorComponent;
  let fixture: ComponentFixture<EHPCalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EHPCalculatorComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EHPCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
