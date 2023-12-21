/* dineroCofla = prompt("cuanto dinero tienes cofla?");
dineroRoberto = prompt("cuanto dinero tienes roberto?");
dineroPedro = prompt("cuanto dinero tienes pedro?");

dineroCofla = parseInt(dineroCofla)

if (dineroCofla >= 0.6 && dineroCofla < 1) {
  alert("Cofla comprate el helado de agua");
  alert("y te sobran" + (dineroCofla - 0.6));
} else if (dineroCofla >= 1 && dineroCofla < 1.6) {
  alert("Cofla comprate el helado de crema");
  alert("y te sobran" + (dineroCofla - 1.6));
} else if (dineroCofla >= 1.6 && dineroCofla < 1.7) {
  alert("Cofla comprate el helado de heladix");
  alert("y te sobran" + (dineroCofla - 1.7));
} else if (dineroCofla >= 1.7 && dineroCofla < 1.8) {
  alert("Cofla comprate el helado de heladovich");
  alert("y te sobran" + (dineroCofla - 1.8));
} else if (dineroCofla >= 1.8 && dineroCofla < 2.9) {
  alert("Cofla comprate el helado de helardo");
  alert("y te sobran" + (dineroCofla - 2.9));
} else if (dineroCofla >= 2.9) {
  alert("Cofla compra el helado con confites o el pote de 1/4kg");
  alert("No te sobra nada no seas mamon");
} else {
  alert("Cofla lo siento, pobre de mierda, no te alcanza para nada");
}

if (dineroPedro >= 0.6 && dineroPedro < 1) {
  alert("Pedro comprate el helado de agua");
  alert("y te sobran" + (dineroPedro - 1));
} else if (dineroPedro >= 1 && dineroPedro < 1.6) {
  alert("Pedro comprate el helado de crema");
  alert("y te sobran" + (dineroPedro - 1.6));
} else if (dineroPedro >= 1.6 && dineroPedro < 1.7) {
  alert("Pedro comprate el helado de heladix");
  alert("y te sobran" + (dineroPedro - 1.7));
} else if (dineroPedro >= 1.7 && dineroPedro < 1.8) {
  alert("Pedro comprate el helado de heladovich");
  alert("y te sobran" + (dineroPedro - 1.8));
} else if (dineroPedro >= 1.8 && dineroPedro < 2.9) {
  alert("Pedro comprate el helado de helardo");
  alert("y te sobran" + (dineroPedro - 2.9));
} else if (dineroPedro >= 2.9) {
  alert("Pedro Pedro compra el helado con confites o el pote de 1/4kg");
  alert("No te sobra nada no seas mamon");
} else {
  alert("Pedro lo siento, pobre de mierda, no te alcanza para nada");
}

if (dineroRoberto >= 0.6 && dineroRoberto < 1) {
  alert("Roberto comprate el helado de agua");
  alert("y te sobran" + (dineroRoberto - 1));
} else if (dineroRoberto >= 1 && dineroRoberto < 1.6) {
  alert("Roberto comprate el helado de crema");
  alert("y te sobran" + (dineroRoberto - 1.6));
} else if (dineroRoberto >= 1.6 && dineroRoberto < 1.7) {
  alert("Roberto  comprate el helado de heladix");
  alert("y te sobran" + (dineroRoberto - 1.7));
} else if (dineroRoberto >= 1.7 && dineroRoberto < 1.8) {
  alert("Roberto comprate el helado de heladovich");
  alert("y te sobran" + (dineroRoberto - 1.8));
} else if (dineroRoberto >= 1.8 && dineroRoberto < 2.9) {
  alert("Roberto comprate el helado de helardo");
  alert("y te sobran" + (dineroRoberto - 2.9));
} else if (dineroRoberto >= 2.9) {
  alert("Roberto helado con confites o el pote de 1/4kg");
  alert("No te sobra nada no seas mamon");
} else {
  alert("Roberto lo siento, pobre de mierda, no te alcanza para nada");
}
 */

/*Arrays let frutas = ["banana","manzanas","pera",5,9,"pedro"];
document.write(frutas[5]) */

/*Array asociativo */
/* let pc = {
    nombre: "DaltoPc",
    procesador: "Intel core I7",
    ram: "16GB",
    espacio: "1TB"
};


let nombre = pc["nombre"];
let procesador = pc["procesador"];
let ram = pc["ram"];
let espacio = pc["espacio"];

frase = `el nombre de mi PC es: <b>${nombre}</b> <br>
        el procesador es: <b>${procesador} </b> <br>
        la memoria ram es: <b>${ram} </b> <br>
        el espacio en disco es de <b>${espacio} </b> <br>
`

document.write(frase) */

/* let pc2 = ["DaltoPc","Intel I7","16GB","1TB"]; */


/* let numero = 0;

if (numero < 10){
    
    document.write(numero)
} */

/* let numero = 0;

while (numero < 6){
  numero++;  
    document.write(numero + "<br>")
} */


/* let numero = 0;

do {
  numero++;  
    document.write(numero + "<br>")
}

while (numero <=6) */


/* let numero=0
while(numero <1000){
    numero++;  
    document.write(numero + "<br>")
    if (numero == 10) {
        break; //finaliza el bucle
    }
} */


/* for (let i=0; i < 20; i++){
    if (i == 12){
      break;  
    }  
    document.write(i + "<br>")
}
 */


/* let animales = ["gato","perro","tiranosaurio rex"];

for (animal in animales){
      document.write(animal + "<br>");    
}

document.write("<br>");

for (animal of animales){
  document.write(animal + "<br>");    
} */


/* array1 = ["maria","josefa","roberta"];
array2 = ["pedro","marcelo",array1,"josefina"];

forRancio:
for (let array in array2){
  if (array == 1){

    for (let array of array1)
    break forRancio;
    document.write(array + "<br>");  

  }else {
    document.write(array2[array] + "<br>");
  }
} */

/* console.log('HOla mundo')

let a = 20;
let b = 14;
console.log(a+b) */