import { createInterface } from "node:readline/promises";
// createInterface() returns an instance of the readline.Interface class
const query = createInterface({ 
    input: process.stdin,
    output: process.stdout
});

(async function (){
    const firstname = await query.question('Podaj imie: ');
    const lastname = await query.question('Podaj nazwisko: ');
    console.log(`Witaj ${firstname} ${lastname}`);

    query.close();//zamkniecie zapytania
})();
//zapytanie o imie

//cwiczenie 4 obliczenie silni n! = 1*2*3*...*n
