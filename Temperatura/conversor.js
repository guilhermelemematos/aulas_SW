document.getElementById('convert').onclick = tempConverte;
document.getElementById('clear').onclick = clearForm;

function tempConverte(){
    var fahrenheit = document.getElementById("fahrenheit").value;
    var celsius = document.getElementById("celsius").value;

    if(isNaN(fahrenheit) || isNaN(celsius)){
        alert("Digite um código válido!");
        return
    }
    else if(fahrenheit === ''){
        fahrenheit = (parseFloat(celsius * 1.8)) + 32
    }
    else if(celsius === ''){
        celsius = (parseFloat(frameElement + 32)) / 1.8
    }
    

    document.getElementById("fahrenheit").value = parseFloat(fahrenheit).toFixed(1);
    document.getElementById("celsius").value = parseFloat(celsius).toFixed(1);
}

function clearForm(){
    document.getElementById("fahrenheit").value = "";
    document.getElementById("celsius").value = "";

}