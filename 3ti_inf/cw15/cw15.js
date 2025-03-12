const elemMenu = document.querySelector('#menu');
elemMenu.oncontextmenu = function (e) {
    e.preventDefault();
    document.querySelector("#info1").innerHTML = "menu kontekstowe";
}
elemMenu.ondblclick = function (e) {
    e.preventDefault();
    if (elemMenu.style.backgroundColor != 'red')
        elemMenu.style.backgroundColor = 'red';
    else
        elemMenu.style.backgroundColor = 'white';
}
elemMenu.onmouseenter = function (e) {
    elemMenu.innerHTML = "najechano na menu";
}
elemMenu.onmouseleave = function (e) {
    elemMenu.innerHTML = "opuszczono menu";
}