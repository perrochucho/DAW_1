function MyFunction1() {
    let precio, cantidad, importe;
            precio = prompt('Ingrese el precio del articulo')
            cantidad = prompt('Ingrese la cantidad de articulos');
            importe = parseInt(precio) * parseInt(cantidad);
            window.alert('debe pagar ' + importe)            

}

function MyFunction2() {
    let texto = document.getElementById("texto");
    let mostrar = document.getElementById("textotal");

    mostrar.innerHTML += texto.value;
}

function MyFunction3() {
    let a, b; 
    a = parseFloat(document.getElementById("a").value);
    b = parseFloat(document.getElementById("b").value);
    if (a > b)
    {
        window.alert(a + " es mayor que " + b);
    } 
    if (b > a)
    {
        window.alert(b +  " es mayor que " + a);
    }
    if (a == b)
    {
        window.alert("Son iguales");
    }    
}

function MyFunction4() {
    let texto = document.getElementById("nombre").value;
    document.getElementById("listanombres").innerHTML += "<li> " + texto + " </li>";
}

function MyFunction5() {
    if (document.getElementById('1').checked)
    {
        window.alert("Has marcado 1")
    }
    else if(document.getElementById('2').checked)
    {
        window.alert("Has marcado 2")
    }
    else if(document.getElementById('3').checked)
    {
        window.alert("Has marcado 3")
    }    
    
}

function MyFunction6() {
    let a2, b2, suma, diferencia, division, multiplicacion;
    a2 = parseFloat(document.getElementById("a2").value);
    b2 = parseFloat(document.getElementById("b2").value);
    suma = a2 + b2;
    diferencia = a2 - b2;
    multiplicacion = b2 * a2;
    division = a2 / b2;
    
    if (a2 > b2)
    {        
        window.alert("La suma es " + suma + " y la diferencia es " + diferencia)
    } 
    if (b2 > a2)
    {
        window.alert("La multiplicación es " + multiplicacion + " y la division es " + division)
    }
    if (a2 == b2)
    {
        window.alert("Son iguales");
    }
}

function MyFunction7() {

    let nota1, nota2, nota3, suma, promedio;
    nota1 = parseInt(document.getElementById("nota1").value); 
    nota2 = parseInt(document.getElementById("nota1").value);
    nota3 = parseInt(document.getElementById("nota1").value);
    suma = nota1 + nota2 + nota3;
    promedio = suma / 3;

    if (promedio < 5)
    {
        window.alert("Repetidor")
    }
    if (promedio >= 5 && promedio <= 7)
    {
        window.alert("Superado")
    }
    if (promedio >= 7)
    {
        window.alert("Promocionado")
    }
}

function MyFunction8() {

    let a, b, c; 
    a = parseInt(document.getElementById("numero1").value);
    b = parseInt(document.getElementById("numero2").value);
    c = parseInt(document.getElementById("numero3").value)
    if (a > b && a > c)
    {
        window.alert("El mayor es: " + a);
    } 
    if (b > a && b > c)
    {
        window.alert("El mayor es: " + b);
    }
    if (c > b && c > a) 
    {
        window.alert("El mayor es: " + c);
    }   
}

function MyFunction9() {

    let a;
    a = parseInt(document.getElementById("ejercicio9").value);
    if (a < 0)
    {
        window.alert("Es negativo")
    }
    if (a == 0)
    {
        window.alert("Es 0")
    }
    if (a > 0)
    {
        window.alert("Es positivo")
    }
}

function MyFunction10() {

    let a;
    a = parseInt(document.getElementById("ejercicio10").value);

    if (a >= 0 && a <= 99) 
    {
        window.alert("Es correcto")
        if (a <= 9) 
        {
            window.alert("Es de una cifra")
        }
        else
        {
            window.alert("Es de dos cifras")
        }
    }
    else
    {
        window.alert("No es correcto")
    }
}

    function MyFunction11() {

        let a;
        a = parseInt(document.getElementById("ejercicio11").value);

        if (a >= 0 && a <= 9) 
        {
            window.alert("Es de una cifra")
        }
        if (a >= 10 && a <= 99) 
        {
            window.alert("Es de dos cifras")
        }
        if (a >= 100 && a <= 999) 
        {
            window.alert("Es de tres cifras")
        }
    }

    function MyFunction12() {

        let day, month;
        day = parseInt(document.getElementById("day").value)
        month = parseInt(document.getElementById("month").value)


        if (day == 25 && month == 12) 
        {
            window.alert("Es navidad")
        }
        else
        {
            window.alert("No es navidad")
        }
    }

    function MyFunction13() {

        let a, b, c, suma, resultado;

        a = parseInt(document.getElementById("ejercicio13.1").value);
        b = parseInt(document.getElementById("ejercicio13.2").value);
        c = parseInt(document.getElementById("ejercicio13.3").value);
        suma = a + b;
        resultado = suma * c;
        if (a == b && a == c) 
        {
            window.alert("El resultado es: " + resultado)
        }
        else
        {
            window.alert("No son iguales");
        }
    }

    function MyFunction14() {

        let total, correctas, resultado;

        total = parseInt(document.getElementById("total").value)
        correctas = parseInt(document.getElementById("correctas").value)

        resultado = correctas / total * 100;
        window.alert(resultado + "%")
        if (resultado >= 90) 
        {
            window.alert("Nivel Superior")
        }
        if (resultado >= 75 && resultado < 90) 
        {
            window.alert("Nivel medio")
        }
        if (resultado >= 50 && resultado <= 75) 
        {
            window.alert("Nivel bajo")
        }
        if (resultado < 50) 
        {
            window.alert("Fuera de Nivel")
        }
    }

    function MyFunction15() {
        
        let sueldo, antiguedad, suma;
        
        sueldo = parseInt(document.getElementById("sueldo").value)
        antiguedad = parseInt(document.getElementById("antiguedad").value)
        suma = 0;
        if (sueldo < 1000 && antiguedad >= 10)
        {
            suma = (sueldo * 20) / 100;
            sueldo = sueldo + suma;
            window.alert("Su sueldo es de " + sueldo);
        }
        if (sueldo < 1000 && antiguedad < 10)
        {
            suma = (sueldo * 5) / 100;
            sueldo = sueldo + suma;
            window.alert("Su sueldo es de " + sueldo)
        }
        if (sueldo >= 1000 && suma == 0)
        {
            window.alert("Su sueldo sigue siendo de " + sueldo)
        }
    }

    function MyFunction16() {

        let marca, modelo, bul;
        bul = 0;

        marca = document.getElementById("marca").value;
        modelo = document.getElementById("modelo").value;
        
        if (marca == 'renault' || marca ==  "Renault")
        {
            window.alert("El descuento es de 15%")
        }
        else
         {
             bul = bul + 1;
         }
        if (marca == "ford" || marca == "Ford" && modelo == "fiesta" || modelo == 'Fiesta')
        {
            window.alert("El descuento es igual a 7%")
        }
        else
        {
            bul = bul + 1;
        }
        if (marca == "ford" || marca == "Ford" && modelo == "focus" || modelo == "Focus")
        {
            window.alert("El descuento es de 10%")
        }
        else
        {
            bul = bul + 1;
        }
        if (bul == 3)
        {
            window.alert("El descuento es del 5%    ")
        }
    }

    function MyFunction17() {
        let mes, dias; 
        mes = parseInt(document.getElementById("mes").value);
        var year = parseInt(document.getElementById("year17").value);
        let bisiesto;
        bisiesto = false;

        if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0))) {
            bisiesto = true;
        }
    
        if (mes == 4 || mes == 6 ||  mes == 9 ||  mes == 11) {
            dias = 31;
            window.alert("El mes tiene: " + dias + " dias");
        }
        else {
            if (mes == 1 || mes == 3 ||  mes == 5 ||  mes == 7 ||  mes == 8 ||  mes == 10 ||  mes == 12) {
                dias = 30;
                window.alert("El mes tiene: " + dias + " dias");
            }
            else {
                if (mes == 2) 
                {
                    if (bisiesto == true) 
                    {
                        dias = 29;
                        window.alert("El mes tiene: "  + dias + " dias");
                    }
                    else {
                        dias = 28;
                        window.alert("El mes tiene: "  + dias + " dias");
                    }
                }
            }
        }
    }

    function MyFunction18() {

        let altura, edad, sexo, resultado;

        sexo = document.getElementById("sexo").value;
        edad = parseInt(document.getElementById("edad").value);
        altura = parseFloat(document.getElementById("altura").value);

        if ((sexo == "hombre") || (sexo == "Hombre"))
        {
            resultado = 50+((altura-150)/4)*3 + (edad-20)/4 
            window.alert("El peso recomendado es de: " + resultado + "Kg")    
        }
        if ((sexo == "mujer") || (sexo == "Mujer")) 
        {
            resultado = 50+((altura-150)/4)*0.9 + (edad-20)/4 
            window.alert("El peso recomendado es de: " + resultado + "Kg")    
        }
    }

    
    function MyFunction19() {
        let dinero = 50;
        num  = prompt('Ingrese el numero al que quiere apostar: ');
        cantidad = prompt('Cantidad que quiere apostar: ');
        
        while (dinero > 0 && apuestas > 0) {
            dado();        
            window.alert("Ha salido el número: " + dado());
            if (num == dado) {
                dinero = dinero + cantidad * 2;
                alert("Has ganado " + cantidad * 2);
                break;
            }
            if (num != dado()) 
            {
                dinero = dinero - cantidad;
                alert("Has perdido : " + cantidad + " ahora tienes " + dinero)
                break;    
            }                            
            if (dinero == 0) 
            {
                alert("Has perdido")
                break;
            }
            if (dinero >= 200) 
            {
                alert("Has ganado")
                break;
            }
        }
    }

    dado(min, max)
        {
            return Math.floor((Math.random()* (6 - 1 + 1)) + min);
        }

        function MyFunction20() {
            let base = parseFloat(document.getElementById("BI").value);
            let iva = document.getElementById("iva").value
            var gastosenvio = parseFloat(document.getElementById("gastosenvio").value);
            var peso = parseFloat(document.getElementById("peso").value);
            var resultado;
        
            if (iva == "normal") {
                base = parseFloat(base) * 0,21;
            }
            else {
                if (iva == "reducido") {
                    base = parseFloat(base) * 0,10;
                }
            }
        
            if(peso == "menos 1")
            {
                peso = 3;
            }
            else
            {
                if(peso == "más 1 menos 3")
                {
                    peso = 5;
                }
                else
                {
                    if(peso == "3 o más")
                    {
                        peso = 10;
                    }
                }
            }
        
            resultado = (base) + (iva) + (gastosenvio);
        
            window.alert(resultado);
        }
    