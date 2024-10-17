import fs from 'fs';
const url = 'https://jsonplaceholder.typicode.com/posts';
const  GetPosts = async () => {
    const response = await fetch(url);
    const data = await response.json();
    //sync write file
    fs.writeFileSync('./posts.json', JSON.stringify(data));
    //async write file
    fs.writeFile('./posts-async.json', JSON.stringify(data), (err) => {
        if (err) {
            console.log(err);
            return;
        }
        console.log('Plik zapisany poprawnie');
    });
    //console.log(data);
};

GetPosts();
// Read file
const text = fs.readFileSync('./text.txt', 'utf8');
console.log(text);