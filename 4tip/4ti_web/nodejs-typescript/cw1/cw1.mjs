import { readFile } from 'node:fs';

readFile('./text.txt', (err, data) => {
  if (err) throw err;
  console.log(data.toString());
});