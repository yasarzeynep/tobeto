import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'my-form', //htmlde cagısralacak isim
  standalone: true,
  imports: [FormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.scss'
})
export class FormComponent {
  username: string = '';
  //Reactive Forms : daha complex formlarda 
  writeToConsole(){
    console.log(this.username);
  }

  changeFromTs (){
 this.username="ornek";
}
}

/*ödev
ngModel
typescript interface/modeller
two way data binding*/
//clı: command line interface
