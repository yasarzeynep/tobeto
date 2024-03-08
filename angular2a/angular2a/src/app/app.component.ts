import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormComponent } from './components/form/form.component';
// annotation, attribute, decorator
@Component({
  selector: 'app-root', //<app-root> <app-root>
  standalone: true, //sonradan bakılacak
  imports: [RouterOutlet, FormComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Tobeto';
  count = 0;
  inputValue: string = '';
  onBtnClick(event: Event) {
    console.log(this.inputValue);
    this.count++;
  }
  onChange(event: Event) {
    let element = event.target as HTMLInputElement;
    console.log('Input değeri değişti', element.value);
    this.inputValue = element.value;
  }
}
