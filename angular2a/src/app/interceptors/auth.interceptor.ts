import { HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  console.log('Sistemden istek atıldı.');
 // req.headers.append("Authorization", "BearMyJwt");
//req degsitirme

//read-only
console.log('AuthInterceptor');
let newRequest=req.clone({setHeaders:{Authorization: 'Bearer myjwt'}});
  return next(newRequest);
};
