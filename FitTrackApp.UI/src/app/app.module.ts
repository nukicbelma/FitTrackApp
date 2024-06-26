import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser'; 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ActivityTablePageComponent } from './activity-table-page/activity-table-page.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, provideHttpClient, withFetch } from '@angular/common/http';
import { ActivityAddPageComponent } from './activity-add-page/activity-add-page.component';
import { NavigationHeaderComponent } from './navigation-header/navigation-header.component';
import { AboutPageComponent } from './about-page/about-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { GoalTablePageComponent } from './goal-table-page/goal-table-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { GoalAddPageComponent } from './goal-add-page/goal-add-page.component';
import { ActivityEditPageComponent } from './activity-edit-page/activity-edit-page.component';
import { GoalEditPageComponent } from './goal-edit-page/goal-edit-page.component';
import { PopupMessageComponent } from './popup-message/popup-message.component';
import { AchievementTablePageComponent } from './achievement-table-page/achievement-table-page.component';
import { AchievementAddPageComponent } from './achievement-add-page/achievement-add-page.component';
import { AuthService } from './services/auth/auth.service';

@NgModule({
  declarations: [
    AppComponent,
    ActivityTablePageComponent,
    ActivityAddPageComponent,
    NavigationHeaderComponent,
    AboutPageComponent,
    HomePageComponent,
    GoalTablePageComponent,
    GoalAddPageComponent,
    LoginPageComponent,
    ActivityEditPageComponent,
    GoalEditPageComponent,
    PopupMessageComponent,
    AchievementTablePageComponent,
    AchievementAddPageComponent    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [AuthService, provideClientHydration(), provideHttpClient(withFetch())],
  bootstrap: [AppComponent]
})
export class AppModule { }