import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegradeSimulatorComponent } from './regradesimulator.component';

describe('RegradesimulatorComponent', () => {
  let component: RegradeSimulatorComponent;
  let fixture: ComponentFixture<RegradeSimulatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegradeSimulatorComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RegradeSimulatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
