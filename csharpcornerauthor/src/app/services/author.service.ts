import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

export enum SearchType {
  all = '',
  admin = 'Admin',
  editor = 'Editor',
  mvp = 'MVP',
  author = 'Author'
}

@Injectable({
  providedIn: 'root'
})
export class AuthorService {
  url = 'https://localhost:44369/api/User/';

  constructor(private http: HttpClient) { }
    
  searchauthor(title: string, type: SearchType): Observable<any> {
    return this.http.get(`${this.url}?s=${encodeURI(title)}&st=${type}`).pipe(    
      map(results => results)
    );
  }

  
  getauthorProfile(id) {
    return this.http.get(`${this.url}?id=${id}`);
  }

  

   
}
