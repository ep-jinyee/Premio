import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-button-group', 
  standalone: true,
  imports: [CommonModule,NgbDropdownModule],
  templateUrl: './button-group.component.html',
  styleUrls: ['./button-group.component.scss']
})
export class ButtonGroupComponent implements OnInit {

  constructor() { }

  ngOnInit() {  }

}
