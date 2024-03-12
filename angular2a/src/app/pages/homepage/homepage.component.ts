import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [CommonModule,HttpClientModule],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.scss'
})

export class HomepageComponent {
  constructor(private httpClient:HttpClient) {

  }
  todoList: string[] = ['Eleman 1'];

  ngOnInit()
  {
    console.log('ngOnInıt calıstı.');
  }
  getTodos()
{
//Backende istek atıp, verileri çek
//Component Lifecycle
}
  
}
