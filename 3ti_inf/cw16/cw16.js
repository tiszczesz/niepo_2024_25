document.querySelector('#start').onclick = function (e) {
    document.querySelector('.scene').innerHTML = generTab(40, 40);
    const tds = document.querySelectorAll('.table td');
    console.log(tds);
    for(td of tds){
        
    }
}

function generTab(rows, cols) {
    let html = '<table class="table">';
    for (let i = 0; i < rows; i++) {
        html += '<tr>';
        for (let j = 0; j < cols; j++) {
            html += '<td></td>';
        }
        html += '</tr>';
    }

    return html + "</table>";
}