import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImenikFormComponent } from './imenik-form.component';

describe('ImenikFormComponent', () => {
  let component: ImenikFormComponent;
  let fixture: ComponentFixture<ImenikFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImenikFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImenikFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
