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
const creteSelect = (div: HTMLDivElement, data: string[]) => {
  const select = document.createElement('select');
  select.addEventListener('change', (e) => {
    const target = e.target as HTMLSelectElement;
    const myDiv = document.querySelector<HTMLDivElement>('#myDiv');
    //myDiv?.style.setProperty('background-color', target.value);
    if(myDiv) {
      myDiv.style.backgroundColor = target.value;
    }   
  });
  //dodanie opcji do selecta
  data.forEach((color) => {
    const option = document.createElement('option');
    option.value = color;
    option.text = color;
    select.appendChild(option);
  });
  div?.appendChild(select);
}
createDiv(app as HTMLDivElement);
creteSelect(app as HTMLDivElement, colors);