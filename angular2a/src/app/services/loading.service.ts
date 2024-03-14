import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoadingService {

  isLoading : boolean=false;

  constructor() { }

  setLoading(value:boolean)
  {
this.isLoading=value;
  }
}

// Todo: Odev
// requestCount + -
// isLoading true false
