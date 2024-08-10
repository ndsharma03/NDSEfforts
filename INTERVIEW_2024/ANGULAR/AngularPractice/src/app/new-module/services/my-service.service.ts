import { Injectable } from '@angular/core';

@Injectable()
export class MyService {
  constructor() { }
  GetName(name:string){
    
    return 'Hello' +name;
  }
}
