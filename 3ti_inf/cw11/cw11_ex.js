document.querySelector("#check").onclick = function () {
    const input = document.querySelector("#prime");
    console.log(input.nextElementSibling);

    const prime = parseInt(input.value);
    if (!isNaN(prime) && prime >= 2) {
        input.nextElementSibling.innerText = "";
        document.querySelector("#result").innerText
            = "";
    } else {
        input.nextElementSibling.innerText = "Podaj liczbę całkowitą większą od 0";
    }
}
function isPrime(number) {
    if (number < 2) return false;
    //liczby pierwsze to te ktore nie podziela sie przez kazda
    // liczbe mniejsza badz rowna od pierwiastek z liczby
    for (let i = 2; i * i <= number; i++) {
        if (number % i == 0) return false;
    }
    return true;
}
function getPrimes(number) {
    const primes = [];
    primes.length; // rozmiar tablicy
    primes.push(2); // dodaje na koniec do tablicy
    //spraawdzamy kolejne liczby czy pierwsze jesli tak to dodajemy do tablicy
    //tak długo aż tablica osiągnie rozmiar number
    let count = 3;
    while (primes.length < number) {
        //sprawdzamy czy count jest pierwsza
        //jesli tak to dodajemy do tablicy
        //jesli nie to sprawdzamy kolejną count++

    }
}