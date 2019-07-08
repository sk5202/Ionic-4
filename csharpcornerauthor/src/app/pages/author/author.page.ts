import { Component, OnInit } from '@angular/core';
import { AuthorService, SearchType } from './../../services/author.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-author',
  templateUrl: './author.page.html',
  styleUrls: ['./author.page.scss'],
})
export class AuthorPage implements OnInit {

  results: Observable<any>;
  searchTerm: string = '';
  type: SearchType = SearchType.all;
 
  constructor(private authorservice: AuthorService) { }
 
  ngOnInit() { }

  livesearch() {  
    this.results = this.authorservice.searchauthor(this.searchTerm, this.type);
  }

}
