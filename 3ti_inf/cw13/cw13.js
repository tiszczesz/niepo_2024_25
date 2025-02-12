const form = document.forms[0];
//const form = document.querySelector('form');
form.onsubmit = function (event) {
    event.preventDefault();//zatrzymuje domyślne zachowanie formularza
    //bez walidacji
    const rows = parseInt(document.querySelector('#rows').value);
    const cols = parseInt(document.querySelector('#cols').value);
    //console.log(rows, cols);
    const table = createTable(rows, cols);
    document.querySelector('.result').innerHTML = table;
    console.log('submit', event);

};
document.querySelector("#reset").onclick = function (event) {
    //alert('reset');
    event.preventDefault();
    document.querySelector('#rows').value = 20;
    document.querySelector('#cols').value = 20;
    //ustawianie inputów na value 20 oraz czyszcze element .result
    document.querySelector('.result').innerHTML = '';
    console.log(document.querySelector('.result').innerHTML, event);

}

function createTable(rows, cols) {
    let html = '<table>';
    //po  wierszach
    let number = 0;
    for (let i = 0; i < rows; i++) {
        html += '<tr>';
        //po kolumnach
        for (let j = 0; j < cols; j++) {
            number++;
            let isRed = isPrime(number) ? "class='red'" : '';
            html += `<td ${isRed}>${number}</td>`;
        }
        html += '</tr>';
    }

    return html + '</table>';
};
function isPrime(number) {
    if (number < 2) return false;
    for (let i = 2; i * i <= number; i++) {
        if (number % i === 0) return false;
    }
    return true;
};