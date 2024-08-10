import { Injectable } from '@angular/core';

@Injectable()
export class DataServiceService {

  constructor() { }

  getData(){
    return [2,3,4,5];
  }
}
