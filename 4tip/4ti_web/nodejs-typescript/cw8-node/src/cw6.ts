
import path from 'path';
import { fileURLToPath } from 'url';
//nie działa gdy używamy es module
// const filePath = path.join(__dirname, 'example.txt');
// console.log(filePath);

const __filename = import.meta.url;
const __dirname = path.dirname(fileURLToPath(__filename));
console.log(__filename);
console.log(__dirname);
console.log(fileURLToPath(__filename));
