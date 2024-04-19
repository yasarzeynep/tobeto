import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { TokenService } from '../services/token.service';

export const authGuard: CanActivateFn = (route, state) => {
// eger bir sayfadan birine redirect olmak istersek  router intectsiyonu yapmamız gerekiyor
//if ile token kontrolü yaptık
const router =inject(Router);
const tokenService=inject(TokenService);

if (tokenService.hasToken())return true;

router.navigateByUrl("/homepage");
  return false; // false olursa ilgili route erişim sağlanmaz; true olursa saglar
};
