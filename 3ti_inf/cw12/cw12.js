document.forms[0].onsubmit = function (event) {
    event.preventDefault();
    console.log("Formularz został wysłany");
    
    getInfo();
}
function getInfo() {
    let firstname = document.querySelector("#firstname").value;
    let lastname = document.querySelector("#lastname").value;
    let division = document.querySelector("#division").value;
    let birtdate = document.querySelector("#birthdate").value;
    console.log(firstname, lastname, division, birtdate);
    
}