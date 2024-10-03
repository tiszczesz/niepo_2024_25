const btn = document.querySelector('#change')//szukamy elementu o id change
console.log(btn);//wypisujemy ten element w konsoli
btn.onclick = function () { //dodajemy funkcje do zdarzenia onclick
    // alert("Hello World");
    const number = document.querySelector('#width').value; //szukamy elementu o id number
    console.log(number);//wypisujemy ten element (warość) w konsoli
    const root = document.querySelector('#root');//szukamy elementu root
    root.style.width = number + "px";//ustawiamy szerokość elementu root na wartość z inputa
}
let width = 100;
const btn2 = document.querySelector('#expand')//szukamy elementu o id change2
btn2.onclick = function () {//dodajemy funkcje do zdarzenia onclick
    const root = document.querySelector('#root');
    width += 10;
   root.style.width = width + "px";
}