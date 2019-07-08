import { Component, OnInit } from '@angular/core';
import { AuthorService } from './../../services/author.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-authordetail',
  templateUrl: './authordetail.page.html',
  styleUrls: ['./authordetail.page.scss'],
})
export class AuthordetailPage implements OnInit {

  information = null;
 
  /**
   * Constructor of our details page
   * @param activatedRoute Information about the route we are on
   * @param authorService The movie Service to get data
   */
  constructor(private activatedRoute: ActivatedRoute, private authorService: AuthorService) { }
 
  ngOnInit() {
    
    let id = this.activatedRoute.snapshot.paramMap.get('id');
 
    this.authorService.getauthorProfile(id).subscribe(result => {
      this.information = result;
    });
  }
 
  openWebsite() {
    window.open(this.information[0].profilelink, '_blank');
  }

}
