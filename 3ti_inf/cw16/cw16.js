document.querySelector('#start').onclick = function (e) {
    document.querySelector('.scene').innerHTML = generTab(40, 40);
    const tds = document.querySelectorAll('.table td img');
    console.log(tds);
    document.querySelector('.scene').oncontextmenu = function (e) {
        e.preventDefault();
    }
    for (let td of tds) {
        //do wyłaczenia menu kontekstowego
        td.oncontextmenu = function (e) {
            e.preventDefault();
        }
        //do pracy z przyciskami myszy
        td.onmousedown = function (e) {
            //console.log(e);
            switch (e.buttons) {
                case 1: // lewy przycisk
                    console.log('lewy przycisk');
                    e.target.src = 'x.png';
                    break;
                case 2: // prawy przycisk
                    console.log('prawy przycisk');
                    e.target.src = 'o.png';
                    break;
                case 4: // środkowy przycisk
                    console.log('środkowy przycisk');
                    e.target.src = 'empty.png';
                    break;
                default:
                    console.log('inny przycisk');
                    break;
            }
        }
    }
}

function generTab(rows, cols) {
    let html = '<table class="table">';
    for (let i = 0; i < rows; i++) {
        html += '<tr>';
        for (let j = 0; j < cols; j++) {
            html += '<td><img src="empty.png" alt="obrazek"/></td>';
        }
        html += '</tr>';
    }

    return html + "</table>";
}