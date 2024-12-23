import { CommonModule } from '@angular/common';
import { Component, ViewChild, OnInit } from '@angular/core';
import { LightboxModule } from 'ng-gallery/lightbox';
import { NgxMasonryComponent, NgxMasonryModule, NgxMasonryOptions } from 'ngx-masonry';

@Component({
  selector: 'app-mesonry',
  standalone: true,
  imports: [CommonModule, LightboxModule,NgxMasonryModule],
  templateUrl: './mesonry.component.html',
  styleUrls: ['./mesonry.component.scss']
})
export class MesonryComponent implements OnInit {

  public masonryOptions: NgxMasonryOptions = {
    gutter: 20,
  };

  @ViewChild(NgxMasonryComponent) masonry: NgxMasonryComponent;

  masonryImages : any= [];
  limit = 15;

  dummyPictures = [
    [false, 'assets/images/masonry/1.jpg'],
    [false, 'assets/images/masonry/2.jpg'],
    [false, 'assets/images/masonry/3.jpg'],
    [false, 'assets/images/masonry/4.jpg'],
    [false, 'assets/images/masonry/5.jpg'],
    [false, 'assets/images/masonry/6.jpg'],
    [false, 'assets/images/masonry/7.jpg'],
    [false, 'assets/images/masonry/8.jpg'],
    [false, 'assets/images/masonry/9.jpg'],
    [false, 'assets/images/masonry/10.jpg'],
    [false, 'assets/images/masonry/11.jpg'],
    [false, 'assets/images/masonry/12.jpg'],
  ];

  ngOnInit() {
    this.masonryImages = this.dummyPictures.slice(0, this.limit);
  }

  showMoreImages() {
    this.limit += 15;
    this.masonryImages = this.dummyPictures.slice(0, this.limit);
  }

  insertImage() {
    this.masonryImages.splice(0, 0, this.dummyPictures[0]);
    this.masonry.reloadItems();
    this.masonry.layout();
  }
  prependImage() {
    const image = this.dummyPictures[50];
    image[0] = true;
    this.masonryImages.push(image);
  }

  removeImage() {
    this.masonryImages.pop();
  }

  itemsLoaded() {
  }

}