import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { ToastrServices } from './toastr.service';

@Injectable({
  providedIn: 'root'
})
export class RequestHandlerService {
  headerList: HttpHeaders;

  constructor(private http: HttpClient, private toastrServices: ToastrServices) {
    this.headerList = new HttpHeaders({
      'Content-Type': 'application/json',
      Accept: 'application/json'
    });
  }

  public get(url: string): Observable<any> {
    return this.http.get(url, { headers: this.headerList }).pipe(
      map(response => {
        return response;
      }),
      catchError(err => this.handleError(err, 'get')));
  }

  public post(url: string, requestObject: {}, param?: HttpParams): Observable<any> {
    return this.http.post(url, requestObject, { headers: this.headerList, params: param }).pipe(
      map(response => {
        return response;
      }),
      catchError(err => this.handleError(err, 'post')));
  }

  private handleError(errorResponse: HttpErrorResponse | any, requestType?: string): Observable<any> {
    this.toastrServices.warning(errorResponse.statusText, 'Status Code: ' + errorResponse.status);
    return throwError(errorResponse);
  }
}
