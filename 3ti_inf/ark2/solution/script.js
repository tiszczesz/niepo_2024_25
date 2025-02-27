const quotes = document.querySelectorAll('.cytaty>section')
console.log(quotes);
let index = 0;
hideQuotes();
quotes[index].style.display = 'block';
for (const q of quotes) {
    q.onclick = function (event) {
        index++;
        hideQuotes();
        quotes[index % quotes.length].style.display = 'block';
    }
}

function hideQuotes() {
    for (const q of quotes) {
        q.style.display = 'none';
    }
}
