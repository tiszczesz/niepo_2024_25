const inputs = document.querySelectorAll('input[type=range]');
document.body.style.backgroundColor = `rgb(${inputs[0].value},${inputs[1].value},${inputs[2].value})`;
console.log(inputs);
for (let i = 0; i < inputs.length; i++) {
    inputs[i].oninput = function () {
        const next = inputs[i].nextElementSibling;
        next.innerHTML = inputs[i].value;
        console.log(`rgb(${inputs[0].value},${inputs[1].value},${inputs[2].value})`);

        document.body.style.backgroundColor = `rgb(${inputs[0].value},${inputs[1].value},${inputs[2].value})`;
    }
}
