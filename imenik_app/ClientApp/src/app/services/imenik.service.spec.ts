import { TestBed, inject } from '@angular/core/testing';

import { ImenikService } from './imenik.service';

describe('ImenikService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ImenikService]
    });
  });

  it('should be created', inject([ImenikService], (service: ImenikService) => {
    expect(service).toBeTruthy();
  }));
});
