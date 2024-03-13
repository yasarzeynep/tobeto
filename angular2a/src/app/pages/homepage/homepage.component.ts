import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ToDo } from '../../models/toDo';
import { FilterTodolistPipe } from '../../pipes/filter-todolist.pipe';
import { FormsModule } from '@angular/forms';
import { TodoService } from '../../services/todo.service';



@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [CommonModule, HttpClientModule, FilterTodolistPipe, FormsModule],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.scss'
})

export class HomepageComponent implements OnInit{
 // todoList: string[] = ['Eleman 1'];
 todoList: ToDo[] = [];

 today: Date=new Date();

 searchKey:string='';
 constructor(private todoService: TodoService) {}
 
  ngOnInit(): void
  {
    //console.log('ngOnInıt calıstı.');
    this.getTodos();
  }

  getTodos()
{
//Backende istek atıp, verileri çek
//Component Lifecycle
this.todoService.getAll().subscribe({
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
  //this.httpClient.post('link', obj).subscribe();
}

formatDate(date:Date)
{
//formatlama islemi 
return date.toISOString();
}
}
