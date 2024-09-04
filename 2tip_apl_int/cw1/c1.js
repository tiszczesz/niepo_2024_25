function createElem(root, content, elem) {
    const target = document.querySelector(root);
    const elemDOM = document.createElement(elem);
    const textContent = document.createTextNode(content);
    elemDOM.appendChild(textContent);
    target.appendChild(elemDOM);
}
function createList(root,list,type){
    //zawartość pętli li mogą być innerHTML
    const target = document.querySelector(root);
    const listDOM = document.createElement(type);

    target.appendChild(listDOM);
}
createElem("#root", "Witaj w JS", "p");
createElem("#root2", "Witaj w JS2", "div");
const content = ["Zjeść śniadanie","Strawić śniadanie","Wydalić resztki"];
createList("#todo",content,"ol");