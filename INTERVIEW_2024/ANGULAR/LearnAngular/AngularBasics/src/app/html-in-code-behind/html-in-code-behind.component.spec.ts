import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmlInCodeBehindComponent } from './html-in-code-behind.component';

describe('HtmlInCodeBehindComponent', () => {
  let component: HtmlInCodeBehindComponent;
  let fixture: ComponentFixture<HtmlInCodeBehindComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HtmlInCodeBehindComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HtmlInCodeBehindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
