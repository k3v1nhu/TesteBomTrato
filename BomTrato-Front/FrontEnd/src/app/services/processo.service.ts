import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { map, repeat } from 'rxjs/operators';
import { Processo } from '../models/Processo';

@Injectable({
  providedIn: 'root'
})
export class AlunoService {

  baseURL = `${environment.mainUrlAPI}aluno`;

  constructor(private http: HttpClient) { }

  // getAll(page?: number, itemsPerPage?: number ): Observable<PaginatedResult<Processo[]>> {
  //   const paginatedResult: PaginatedResult<Processo[]> = new PaginatedResult<Processo[]>();

  //   let params = new HttpParams();

  //   if (page != null && itemsPerPage != null) {
  //     params = params.append('pageNumber', page.toString());
  //     params = params.append('pageSize', itemsPerPage.toString());
  //   }

    //return this.http.get<Processo[]>(this.baseURL, { observe: 'response', params })
    //  .pipe(
      //   map(response => {
      //     paginatedResult.result = response.body;
      //     if (response.headers.get('Pagination') != null) {
      //       paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
      //     }
      //     return paginatedResult;
      //   })
      // );
  //}

  getById(id: number): Observable<Processo> {
    return this.http.get<Processo>(`${this.baseURL}/${id}`);
  }

  post(processo: Processo) {
    return this.http.post(this.baseURL, processo);
  }

  put(processo: Processo) {
    return this.http.put(`${this.baseURL}/${processo.id}`, processo);
  }

  trocarEstado(processoId: number, ativo: boolean) {
    return this.http.patch(`${this.baseURL}/${processoId}/trocarEstado`, { Estado: ativo });
  }

  patch(processo: Processo) {
    return this.http.patch(`${this.baseURL}/${processo.id}`, processo);
  }

  delete(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

}
