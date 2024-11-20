document.querySelector("#check").onclick = function () {
    console.log("ff");

    const input = document.querySelector("#prime");
    console.log(input.nextElementSibling);

    const prime = parseInt(input.value);
    if (!isNaN(prime) && prime >= 2) {
        input.nextElementSibling.innerText = "";
        document.querySelector("#result").innerText
            = isPrime(prime) ? `${prime} jest pierwsza`
                : `${prime} nie jest pierwsza`;
    } else {
        input.nextElementSibling.innerText = "Podaj liczbę całkowitą większą od 1";
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