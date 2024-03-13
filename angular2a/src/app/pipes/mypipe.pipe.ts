import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'mypipe',
  standalone: true //bagımsız
})
export class MypipePipe implements PipeTransform {

  transform(value: string): string {
    return value+ 'Tobeto';
  }

}
