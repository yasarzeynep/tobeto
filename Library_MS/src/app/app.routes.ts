import { Routes } from '@angular/router';
import { HomepageComponent } from './shared/pages/homepage/homepage.component';
import { BooklistComponent } from './features/book/pages/booklist.component';
import { authGuard } from './core/guards/auth.guard';

export const routes: Routes = [
    {path: '', redirectTo: 'homepage', pathMatch:'full'},
    {path:'homepage', component:HomepageComponent},
    {path:'books', component:BooklistComponent, canActivate:[authGuard]}, //interceptorde oldugu gibi multple: guardları belirliyoruz
];
