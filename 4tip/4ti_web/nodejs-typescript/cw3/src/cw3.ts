console.log("Hello World from TS");

const div = document.createElement("div");
div.innerHTML = "Hello World from TS";

const root = document.querySelector<HTMLDivElement>("#root");
if (root !== null) {
    root.appendChild(div);
    createInput(root);
    //obsługa przycisku z info
    const button = document.querySelector<HTMLButtonElement>("#button");
    button?.addEventListener("click", () => {
        const howMany = parseInt(document.querySelector<HTMLInputElement>("#input")?.value!);
        if (!isNaN(howMany)) {
            generList(howMany, root);
        }
    });
} else {
    console.log("Root not found");
}

function createInput(elem: HTMLElement): void {
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
function generList(howMany: number, elem: HTMLElement): void {
    const ol = document.createElement("ol");
    for (let i = 0; i < howMany; i++) {
        const li = document.createElement("li");
        li.innerHTML = `Element nr ${i + 1}`;
        ol.appendChild(li);
    }
    elem.appendChild(ol);//dodanie listy do elementu root
}