const btn = document.querySelector("#show");
btn.onclick = function () {
    let value = document.querySelector("#range").value;//z suwaka pobieramy wartość
    document.querySelector("#info").innerHTML = value;//wyświetlamy w label
}
document.querySelector("#range").onchange = function () {
    let value = document.querySelector("#range").value;
    console.log(value);
}