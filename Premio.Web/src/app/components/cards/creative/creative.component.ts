import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-creative',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './creative.component.html',
  styleUrls: ['./creative.component.scss']
})
export class CreativeComponent implements OnInit {

  constructor() { }

  ngOnInit() { }

}
