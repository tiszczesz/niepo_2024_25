// Pobieranie elementów
const modal = document.getElementById("modal");
const btn = document.getElementById("openModal");
const span = document.getElementsByClassName("close")[0];

// Otwieranie modalu
btn.onclick = function() {
    modal.style.display = "block";
}

// Zamknięcie modalu po kliknięciu na X
span.onclick = function() {
    modal.style.display = "none";
}

// Zamknięcie modalu po kliknięciu gdziekolwiek poza modalem
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
