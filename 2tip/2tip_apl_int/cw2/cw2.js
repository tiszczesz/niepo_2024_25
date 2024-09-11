function cw1() {
    const person1 = {};
    //const tab1 = [];
    console.log(typeof person1);
    console.log(person1.firstname);
    //console.log(typeof tab1);
    person1.firstname = "Jan";
    person1.lastname = "Kowalski";
    person1.age = 34;
    person1.show = function () {
        console.log(this.firstname + " " + this.lastname + " wiek: " + this.age);
    }
    console.log(person1);
    person1.show();
}


document.forms[0].addEventListener('submit', function (event) {
    event.preventDefault();
    if (ValidateString(document.querySelector("#firstname")) ||
        ValidateString(document.querySelector("#lastname"))) {
            
    }
    const person = {};
})
function ValidateString(elem) {
    const next = elem.nextElementSibling;
    if (elem.value.trim() === "") {
        next.innerHTML = "To pole jest wymagane";
        return false;
    } else {
        next.innerHTML = "";
        return true;
    }
}