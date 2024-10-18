import { createInterface } from "node:readline/promises";
// createInterface() returns an instance of the readline.Interface class
const query = createInterface({ 
    input: process.stdin,
    output: process.stdout
});
const factorial = (n: number): number => {
    if(n <= 1) return 1;
    return n * factorial(n - 1);
}
const main = async () => {
    const n = parseInt(await query.question('Podaj liczbe calkowita: '));
    console.log(`Silnia z liczby ${n}! = ${factorial(n)}`);
    query.close();//zamkniecie zapytania
};
main();