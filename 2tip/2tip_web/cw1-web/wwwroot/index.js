const div = document.createElement('div');
div.innerHTML = 'a kuku';
setTimeout(() => {
    document.body.appendChild(div);
}, 2000);