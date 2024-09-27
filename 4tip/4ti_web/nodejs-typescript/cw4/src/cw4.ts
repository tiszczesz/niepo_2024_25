import { people } from "./data.js";

console.log(people);
const root = document.querySelector<HTMLDivElement>("#root");

if (root) {
    generButton(root);
}

function generButton(elem:HTMLElement){
    const button = document.createElement("button");
    button.textContent = "Załaduj dane";
    elem.appendChild(button);
    button.addEventListener("click", () => {
        generTable(elem);
    });
}
function generTable(elem:HTMLElement):void{
    const table = document.createElement("table");
    table.className = "table table-striped";   
    const header = table.createTHead();
    const row = header.insertRow(0);
   // row.innerHTML = "<th>Imię</th><th>Nazwisko</th><th>Wiek</th>";
    const cell1 = row.insertCell(0);
    const cell2 = row.insertCell(1);
    const cell3 = row.insertCell(2);
    cell1.innerHTML = "Imię";
    cell2.innerHTML = "Nazwisko";
    cell3.innerHTML = "Wiek";
    const body = table.createTBody();
    people.forEach((person) => {
        const row = body.insertRow();
      //  row.innerHTML = "<td>"+person.firstname+"</td><td>"+person.lastname+"</td><td>"+person.age+"</td>";
        const cell1 = row.insertCell(0);
        const cell2 = row.insertCell(1);
        const cell3 = row.insertCell(2);
        cell1.textContent = person.firstname;
        cell2.textContent = person.lastname;
        cell3.textContent = person.age.toString();
    });
    elem.appendChild(table);
}
