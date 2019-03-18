import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsService } from './services/settings.service';
import { AdminComponent } from './admin.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { FigurecardComponent } from './components/ui/figurecard/figurecard.component';
import { ImagecardComponent } from './components/ui/imagecard/imagecard.component';
import { NavbarComponent } from './components/ui/navbar/navbar.component';
import { MatButtonModule, MatRadioModule, MatInputModule, MatMenuModule, MatCheckboxModule } from '@angular/material';
import { SettingComponent } from './components/setting/setting.component';

@NgModule({
  declarations: [
    DashboardComponent,
    AdminComponent,
    SidebarComponent,
    FigurecardComponent,
    ImagecardComponent,
    NavbarComponent,
    SettingComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    MatButtonModule,
    MatRadioModule,
    MatInputModule,
    MatMenuModule,
    MatCheckboxModule
  ],
  providers: [SettingsService]
})
export class AdminModule { }
