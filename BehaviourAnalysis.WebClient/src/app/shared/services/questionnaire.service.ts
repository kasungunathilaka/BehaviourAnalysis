import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Question } from '../models/question.model';
import { Questionnaire } from '../models/questionnaire.model';
import { RequestHandlerService } from './common/request-handler.service';

@Injectable({
  providedIn: 'root'
})
export class QuestionnaireService {
  private baseUrl: string;

  constructor(private requestHandlerService: RequestHandlerService) {
    this.baseUrl = environment.baseUrl;
  }

  SaveQuestionnaire(questions: Question[]): Promise<Questionnaire> {
    return new Promise((resolve, reject) => {
      this.requestHandlerService.post(this.baseUrl + 'questionnaire', questions).subscribe(
        (response: Questionnaire) => {
          resolve(response);
        },
        error => {
          reject(error);
        });
    });
  }
}
