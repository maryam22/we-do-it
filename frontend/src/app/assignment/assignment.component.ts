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

  }

}
