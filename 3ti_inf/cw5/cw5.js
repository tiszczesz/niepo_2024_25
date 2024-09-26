const root = document.querySelector('#root');
root.innerHTML = 'aktualny czas: ' + new Date().toLocaleTimeString();

setInterval(() => {
    root.innerHTML = 'aktualny czas: ' + new Date().toLocaleTimeString();
}, 1000);