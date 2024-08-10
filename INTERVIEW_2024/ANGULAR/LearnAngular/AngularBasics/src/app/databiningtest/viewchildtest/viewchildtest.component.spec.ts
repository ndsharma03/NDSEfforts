import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewchildtestComponent } from './viewchildtest.component';

describe('ViewchildtestComponent', () => {
  let component: ViewchildtestComponent;
  let fixture: ComponentFixture<ViewchildtestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ViewchildtestComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewchildtestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
