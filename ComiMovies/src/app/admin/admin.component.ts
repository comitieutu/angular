import { Component, OnInit, OnDestroy } from '@angular/core';
import { SettingsService } from './services/settings.service';

@Component({
    selector: 'admin-index',
    templateUrl: './admin.component.html',
    styleUrls: ['./admin.component.css']
  })
export class AdminComponent implements OnInit, OnDestroy {
  public id: number;
  public backgroundColor: string;
  constructor(public settingService: SettingsService) {
    this.id = settingService.getSidebarImageIndex() + 1;
    this.backgroundColor = settingService.getSidebarColor();
  }

  ngOnInit() {
    this.settingService.sidebarImageIndexUpdate.subscribe((id: number) => {
      this.id = id + 1;
    });
    this.settingService.sidebarColorUpdate.subscribe((color: string) => {
      this.backgroundColor = color;
    });
  }

  ngOnDestroy() {
    this.settingService.sidebarImageIndexUpdate.unsubscribe();
    this.settingService.sidebarColorUpdate.unsubscribe();
  }
}
