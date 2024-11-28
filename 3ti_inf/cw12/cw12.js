document.forms[0].onsubmit = function (event) {
    event.preventDefault();
    console.log("Formularz został wysłany");
    getInfo();
    clearForm();
}
function getInfo() {
    let firstname = document.querySelector("#firstname").value;
    let lastname = document.querySelector("#lastname").value;
    let division = document.querySelector("#division").value;
    let birtdate = document.querySelector("#birthdate").value;
    console.log(firstname, lastname, division, birtdate);
    generRow(firstname, lastname, division, birtdate);
}
function generRow(firstname, lastname, division, birtdate) {
    const table = document.querySelector("table");
    const row = table.insertRow(-1);
    const cell1 = row.insertCell(0);
    cell1.innerHTML = firstname;
    const cell2 = row.insertCell(1);
    cell2.innerHTML = lastname;
    const cell3 = row.insertCell(2);
    cell3.innerHTML = division;
    const cell4 = row.insertCell(3);
    cell4.innerHTML = birtdate;
}
function clearForm() {
    document.querySelector("#firstname").value = "";
    document.querySelector("#lastname").value = "";
    document.querySelector("#division option").selected = true;
    document.querySelector("#birthdate").value = "";
}