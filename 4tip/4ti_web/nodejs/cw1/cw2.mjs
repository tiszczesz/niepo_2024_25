//zapis do pliku cw2.txt tekstu "ala ma kota"
 import { writeFile } from 'node:fs';
const text = "ala ma kota";
const filePath = './cw2.txt';

writeFile(filePath, text, (err) => {
    if (err) throw err;
    console.log('The file has been saved!');
});
