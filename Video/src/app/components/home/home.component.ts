import { Component, OnInit, ViewEncapsulation  } from '@angular/core';

import '../../../assets/js/jquery.flexslider.js';
import '../../../assets/js/jquery.dotdotdot.min.js';
import '../../../assets/js/jquery.magnific-popup.js';
import '../../../assets/js/jquery.slidey.js';
declare var $:any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css',
              '../../../assets/css/flexslider.css',
              '../../../assets/css/jquery.slidey.min.css'
            ],
  encapsulation: ViewEncapsulation.None,             
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    
    $("#slidey").slidey({
      interval: 8000,
      listCount: 5,
      autoplay: false,
      showList: true
    });
    $(".slidey-list-description").dotdotdot();

    $(document).ready(function() {
      $('.w3_play_icon,.w3_play_icon1,.w3_play_icon2').magnificPopup({
        type: 'inline',
        fixedContentPos: false,
        fixedBgPos: true,
        overflowY: 'auto',
        closeBtnInside: true,
        preloader: false,
        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
      });                                      
    });

    $(window).load(function(){
      $('.flexslider').flexslider({
      animation: "slide",
      start: function(slider){
        $('body').removeClass('loading');
      }
      });
    });
  }

}
