function After(time) {
    setTimeout(function () {
        document.querySelector("h1").innerHTML += " już za chwilę!"
    }, time);
}
After(2000);
const textElement = document.querySelector("#text");
console.log(textElement);
textElement.onkeydown = function (event) {
    if (!isLetter(event.key)) {
        event.preventDefault();
        console.log("Nie można wpisać znaku: " + event.key);
    }
}
// textElement.onkeydown = function (event) {
//     console.log("onkeydown: " + event.key);
//     console.log("onkeydown: " + event.code);
// }
// textElement.onkeypress = function (event) {
//     console.log("onkeypress: " + event.key);
//     console.log("onkeypress: " + event.code);

// }
// textElement.onkeyup = function (event) {
//     console.log("onkeyup: " + event.key);
//     console.log("onkeyup: " + event.code);
// }
function isLetter(key) {
    //polskie litery
    const polishLetters = ['ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż',
        'Ą', 'Ć', 'Ę', 'Ł', 'Ń', 'Ó', 'Ś', 'Ź', 'Ż'];
    return (key >= 'a' && key <= 'z') ||
        (key >= 'A' && key <= 'Z') ||
        polishLetters.includes(key);
}