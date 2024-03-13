import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ToDo } from '../../models/toDo';
import { MypipePipe } from '../../pipes/mypipe.pipe';

@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [CommonModule,HttpClientModule, MypipePipe],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.scss'
})

export class HomepageComponent implements OnInit{
  constructor(private httpClient:HttpClient) {}

 // todoList: string[] = ['Eleman 1'];
 todoList: ToDo[] = [];


today: Date=new Date();
  ngOnInit(): void
  {

    //console.log('ngOnInıt calıstı.');
    this.getTodos();
   
  }
  getTodos()
{
//Backende istek atıp, verileri çek
//Component Lifecycle
this.httpClient
.get<ToDo[]>('https://jsonplaceholder.typicode.com/todos')
.subscribe({
  next: (response: ToDo[]) => {
    console.log('Backendden cevap geldi:', response);
    this.todoList = response;
  },
  error: (error) => {
    console.log('Backendden hatalı cevap geldi:', error);
  },
  complete: () => {
    console.log('Backend isteği sonlandı.');
  },
});
}

postToDo() {
  let obj = {};
  this.httpClient.post('link', obj).subscribe();
}

formatDate(date:Date)
{
//formatlama islemi 
return date.toISOString();
}
}
