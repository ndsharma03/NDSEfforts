import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmldisplayComponent } from './htmldisplay.component';

describe('HtmldisplayComponent', () => {
  let component: HtmldisplayComponent;
  let fixture: ComponentFixture<HtmldisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HtmldisplayComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HtmldisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
