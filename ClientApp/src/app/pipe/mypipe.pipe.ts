import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'mypipe'
})
export class MypipePipe implements PipeTransform {

  defaultrate :number = 10;
  transform(value: any, rate?: any): number 
  {
    let valuenumber = Number.parseFloat(value);
    let ratevalue = rate == undefined ? this.defaultrate : Number.parseInt(rate);
    return valuenumber + (valuenumber * (ratevalue/100))  ;
  }

}
