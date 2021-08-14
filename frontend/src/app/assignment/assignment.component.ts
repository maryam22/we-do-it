/* tslint:disable:only-arrow-functions typedef semicolon */
import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';


@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    // Do not touch this
    this.assignmentCode();
  }

  assignmentCode(): void {
    // TODO: Add here your javascript code
   let btn =document.querySelector('button')

   btn.addEventListener('click',function(){

     btn.classList.add("blue-gradient")
     btn.classList.remove("orange-gradient")
     setTimeout(() => {
      alert("what's up!")
     }, 100);
    

   })


  }

}
