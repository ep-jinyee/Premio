import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgbModule, NgbNavChangeEvent } from '@ng-bootstrap/ng-bootstrap';
// import {NgbTabChangeEvent} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-tabset',
  standalone: true,
  imports: [CommonModule,NgbModule],
  templateUrl: './tabset.component.html',
  styleUrls: ['./tabset.component.scss']
})
export class TabsetComponent implements OnInit {

  currentJustify = 'start';
  currentOrientation = 'horizontal';

  public active1 = 1;
  public active2 = 1;
  public active3 = 1;
  public active4 = 1;
  disabled = true;

  onNavChange1(changeEvent: NgbNavChangeEvent) {
    if (changeEvent.nextId === 3) {
      changeEvent.preventDefault();
    }
  }

  onNavChange(changeEvent: NgbNavChangeEvent) {
    if (changeEvent.nextId === 3) {
      changeEvent.preventDefault();
    }
  }

  ngOnInit() { }
}
