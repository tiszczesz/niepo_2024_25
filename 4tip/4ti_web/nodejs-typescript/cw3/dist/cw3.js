"use strict";
console.log("Hello World from TS");
const div = document.createElement("div");
div.innerHTML = "Hello World from TS";
const root = document.querySelector("#root");
if (root !== null) {
    root.appendChild(div);
    createInput(root);
    //obsługa przycisku z info
    const button = document.querySelector("#button");
    button === null || button === void 0 ? void 0 : button.addEventListener("click", () => {
        var _a;
        const howMany = parseInt((_a = document.querySelector("#input")) === null || _a === void 0 ? void 0 : _a.value);
        if (!isNaN(howMany)) {
            generList(howMany, root);
        }
    });
}
else {
    console.log("Root not found");
}
function createInput(elem) {
    const input = document.createElement("input");
    input.id = "input";
    const button = document.createElement("button");
    button.id = "button";
    button.innerHTML = "Generuj";
    input.type = "number";
    input.placeholder = "Podaj ilość elementów";
    const info = document.createElement("div");
    info.id = "info";
    info.appendChild(input);
    info.appendChild(button);
    elem.appendChild(info);
}
function generList(howMany, elem) {
    const ol = document.createElement("ol");
    for (let i = 0; i < howMany; i++) {
        const li = document.createElement("li");
        li.innerHTML = `Element nr ${i + 1}`;
        ol.appendChild(li);
    }
    elem.appendChild(ol); //dodanie listy do elementu root
}
