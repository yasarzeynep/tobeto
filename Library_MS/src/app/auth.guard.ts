import { ActivatedRouteSnapshot, CanActivateFn, Router, RouterStateSnapshot } from '@angular/router';
import { inject } from '@angular/core';
import { AuthService } from '../services/concretes/auth.service';

export const loginGuard: CanActivateFn = (route:ActivatedRouteSnapshot, state:RouterStateSnapshot) => {

  const authService = inject(AuthService);
  const router = inject(Router);

  if(authService.loggedIn()) { //kullanıcı otrumu  actıysa true
    return true;
  }
  else{  //kullanıcı otrumu  acmadıysa homeapde yonlendirir uyarı ile birlikte
    router.navigate(["homepage"]);
    alert("You must log in to view this page!")
    return false;
  }

};