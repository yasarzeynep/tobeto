import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

// annotation, attribute, decarator
@Component({
  selector: 'app-root', // bir componenti baska bir componetin içinde kullanabilirim.html tagı: <app-root><app-root/>
  standalone: true, //
  imports: [RouterOutlet], // hangi dıs angular sayfalarını kullannacgını soyler
  templateUrl: './app.component.html', //tek html  dosyasını kullanır
  styleUrl: './app.component.scss' //birden fazla olabilir:stil dosyası 
})
export class AppComponent {
  title = 'Library_MS';
}
