const form = document.forms[0];
//const form = document.querySelector('form');
form.onsubmit = function (event) {
    event.preventDefault();//zatrzymuje domyślne zachowanie formularza
    //bez walidacji
    const rows = parseInt(document.querySelector('#rows').value);
    const cols = parseInt(document.querySelector('#cols').value);
    console.log(rows, cols);
    const table = createTable(rows, cols);
    document.querySelector('.result').innerHTML = table;
};

function createTable(rows, cols) {
    let html = '<table>';
    //po  wierszach
    let number = 0;
    for (let i = 0; i < rows; i++) {
        html += '<tr>';
        //po kolumnach
        for (let j = 0; j < cols; j++) {
            number++;
            html += `<td>${number}</td>`;
        }
        html += '</tr>';
    }

    return html + '</table>';
};