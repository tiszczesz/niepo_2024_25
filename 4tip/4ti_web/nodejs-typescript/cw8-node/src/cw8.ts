import { createServer } from "node:http";
import fs from "fs";
// import { fileURLToPath } from "node:url";
// import path from "node:path";
// const __filename = import.meta.url;
// const __dirname = path.dirname(fileURLToPath(__filename));
const port = 3000;
const hostname = 'localhost';
const server = createServer((req, res) => {

    if (req.url === '/') {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/plain');
        res.end('Hello World');
    } else if (req.url === '/index') {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.write(fs.readFileSync('./public/index.html'));
        res.end();
    }else if (req.url === '/about') {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/html');
        res.write(fs.readFileSync('./public/about.html'));
        res.end();
    }

});

server.listen(port, hostname, () => {
    console.log(`Server running at http://${hostname}:${port}/`);
});