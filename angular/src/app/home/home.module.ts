import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { ListService } from '@abp/ng.core';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule],
  providers: [
    ListService
  ]
})
export class HomeModule { }
