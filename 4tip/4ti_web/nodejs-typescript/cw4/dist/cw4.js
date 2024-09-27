import { people } from "./data.js";
console.log(people);
const root = document.querySelector("#root");
if (root) {
    generButton(root);
}
function generButton(elem) {
    const button = document.createElement("button");
    button.textContent = "Załaduj dane";
    elem.appendChild(button);
    button.addEventListener("click", () => {
        generTable(elem);
    });
}
function generTable(elem) {
    const table = document.createElement("table");
    table.className = "table table-striped";
    const header = table.createTHead();
    const row = header.insertRow(0);
    const cell1 = row.insertCell(0);
    const cell2 = row.insertCell(1);
    const cell3 = row.insertCell(2);
    cell1.innerHTML = "<b>Imię</b>";
    cell2.innerHTML = "<b>Nazwisko</b>";
    cell3.innerHTML = "<b>Wiek</b>";
    const body = table.createTBody();
    people.forEach((person) => {
        const row = body.insertRow();
        const cell1 = row.insertCell(0);
        const cell2 = row.insertCell(1);
        const cell3 = row.insertCell(2);
        cell1.textContent = person.firstname;
        cell2.textContent = person.lastname;
        cell3.textContent = person.age.toString();
    });
    elem.appendChild(table);
}
