import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Question } from '../models/question.model';
import { RequestHandlerService } from './common/request-handler.service';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  private baseUrl: string;

  constructor(private requestHandlerService: RequestHandlerService) {
    this.baseUrl = environment.baseUrl;
  }

  getQuestions(): Promise<Question[]> {
    return new Promise((resolve, reject) => {
      this.requestHandlerService.get(this.baseUrl + 'questions').subscribe(
        (response: Question[]) => {
          resolve(response);
        },
        error => {
          reject(error);
        });
    });
  }
}
