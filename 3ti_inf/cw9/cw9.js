document.querySelector('#count').onclick = function(){
    
    let money = parseInt(document.querySelector("#money").value);//pobranie wartości z pola money
    let rate = parseFloat(document.querySelector("#rate").value);//pobranie wartości z pola rate
    let time = parseInt(document.querySelector("#time").value);//pobranie wartości z pola time
    console.log(`obliczanie...${money} ${rate} ${time}`); 
    let result = money+(money*rate/12*time);
    console.log(result);
    document.querySelector("#result").innerHTML = result;
    document.querySelector("#result2").innerHTML = (result/time).toFixed(2);
};