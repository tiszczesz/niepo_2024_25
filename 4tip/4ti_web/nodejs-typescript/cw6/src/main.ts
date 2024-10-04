import './style.css'
import { colors } from './data';

console.log(colors);

const app = document.getElementById('app');

const createDiv = (div: HTMLDivElement) => {
  const elem = document.createElement('div');
  elem.style.width = '100px';
  elem.id = 'myDiv';
  elem.style.height = '100px';
  elem.style.backgroundColor = 'red';
  div?.appendChild(elem);
}
const creteSelect = (div: HTMLDivElement,data:string[]) => {
  const select = document.createElement('select');
  //dodanie opcji do selecta
  div?.appendChild(select);
}
createDiv(app as HTMLDivElement);
creteSelect(app as HTMLDivElement,colors);