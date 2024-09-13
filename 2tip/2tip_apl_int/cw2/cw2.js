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
    let firstnameOK = ValidateString(document.querySelector("#firstname"));
    let lastnameOK = ValidateString(document.querySelector("#lastname"));
    let ageOK = ValidateAge(document.querySelector("#age"));
    if (firstnameOK && lastnameOK && ageOK) {
        //jak ok   
        const person = { //json
            firstname: document.querySelector("#firstname").value,
            lastname: document.querySelector("#lastname").value,
            age: parseInt(document.querySelector("#age").value),
            show: function (elem) {
                return `Imie: ${this.firstname}, nazwisko: ${this.lastname}, wiek: ${this.age}`
            }
        };
        console.log(person);
        const result = document.querySelector("#result");
        result.innerHTML = person.show();
        result.style.display = "block";
    }else{
        document.querySelector("#result").style.display = "none";
    }
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
function ValidateAge(elem) {
    const next = elem.nextElementSibling;
    let age = parseInt(elem.value.trim());
    if (!isNaN(age) && age >= 1 && age <= 140) {
        next.innerHTML = "";
        return true;
    } else {
        next.innerHTML = "Wiek musi zawierać się w przedziale od 1 do 140";
        return false;
    }
}