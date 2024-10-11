import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.min.js';
import './style.css';
import { GetPosts } from './data';

const app = document.querySelector<HTMLDivElement>('#app');

const h1 = document.createElement('h1');
h1.textContent = 'Hello World!';
h1.classList.add('text-center');
app?.appendChild(h1);
// GetPosts().then((data) => {
//   console.log(data);
// });


const data = await GetPosts();
console.log(data);

