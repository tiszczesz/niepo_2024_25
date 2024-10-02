// Pobierz elementy
var modal = document.getElementById("myModal");
var btn = document.getElementById("openModal");
var span = document.getElementsByClassName("close")[0];

// Otwórz modal po kliknięciu przycisku
btn.onclick = function() {
    modal.style.display = "block";
}

// Zamknij modal po kliknięciu na <span> (x)
span.onclick = function() {
    modal.style.display = "none";
}

// Zamknij modal po kliknięciu poza modalem
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
