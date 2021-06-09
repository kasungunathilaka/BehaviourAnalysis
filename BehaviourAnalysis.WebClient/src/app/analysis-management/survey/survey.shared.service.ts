import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class SurveySharedService {
  public disorder = new BehaviorSubject(null);

  constructor() { }

  setDisorder(disorder: string): void {
    this.disorder.next(disorder);
  }
}
