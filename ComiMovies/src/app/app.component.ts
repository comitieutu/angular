import { Component, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import {isPlatformBrowser} from '@angular/common';
import {NavigationEnd, Router} from '@angular/router';
import { AuthenticationService } from './services/authentication.service';
import { User } from './models/user';

@Component({
  selector: 'app-home',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  currentUser: User;
  private isBrowser: boolean = isPlatformBrowser(this.platformId);
  
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService,
    @Inject(PLATFORM_ID) private platformId: any
  ) 
  {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }
  ngOnInit() {
    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }
      if (this.isBrowser) {
        window.scrollTo(0, 0);
      }
    });
  }

  logout() {
    this.authenticationService.logout();
    this.router.navigate(['/']);
  }
}
