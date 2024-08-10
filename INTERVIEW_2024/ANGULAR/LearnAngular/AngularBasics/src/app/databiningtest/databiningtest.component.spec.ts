import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DatabiningtestComponent } from './databiningtest.component';

describe('DatabiningtestComponent', () => {
  let component: DatabiningtestComponent;
  let fixture: ComponentFixture<DatabiningtestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DatabiningtestComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DatabiningtestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
