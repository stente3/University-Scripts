/* Condicionales */
console.log("----------")
console.log("Condicionales")
console.log("----------")

// Constante para almacener el número del día de la semana
const numeroDiaSemana = 5;

// Variable que almacenará el nombre del día de la semana
let nombreDia;

// if, else if y else para determinar el nombre del día de la semana
if (numeroDiaSemana === 1) {
  nombreDia = 'Domingo';
} else if (numeroDiaSemana === 2) {
  nombreDia = 'Lunes';
} else if (numeroDiaSemana === 3) {
  nombreDia = 'Martes';
} else if (numeroDiaSemana === 4) {
  nombreDia = 'Miércoles';
} else if (numeroDiaSemana === 5) {
  nombreDia = 'Jueves';
} else if (numeroDiaSemana === 6) {
  nombreDia = 'Viernes';
} else if (numeroDiaSemana === 7) {
  nombreDia = 'Sábado';
} else {
  nombreDia = 'Día inválido';
}

console.log(`El número ${numeroDiaSemana} corresponde al día de la semana: ${nombreDia}`);

// switch para determinar el nombre del día de la semana
switch (numeroDiaSemana) {
  case 1:
    nombreDia = 'Domingo';
    break;
  case 2:
    nombreDia = 'Lunes';
    break;
  case 3:
    nombreDia = 'Martes';
    break;
  case 4:
    nombreDia = 'Miércoles';
    break;
  case 5:
    nombreDia = 'Jueves';
    break;
  case 6:
    nombreDia = 'Viernes';
    break;
  case 7:
    nombreDia = 'Sábado';
    break;
  default:
    nombreDia = 'Día inválido';
    break;
}

console.log(`Utilizando switch, el número ${numeroDiaSemana} corresponde al día de la semana: ${nombreDia}`);


/* Bucles */
console.log("----------")
console.log("Bucles")
console.log("----------")
// Ejemplo utilizando for loop 
console.log("Calculando la suma de los primeros 10 números naturales con for:");
let suma = 0;
for (let i = 1; i <= 10; i++) {
  suma += i;
}
console.log("La suma es:", suma);


// Ejemplo utilizando do...while loop 
console.log("Imprimiendo números pares del 2 al 10 con do...while:");
let num2 = 2;
do {
  console.log(num2);
  num2 += 2;
} while (num2 <= 10);


// Ejemplo de Reverse Loop utilizando un bucle for
console.log("Reverse Loop de números pares del 100 al 1:");
for (let i = 100; i >= 1; i--) {
  if (i % 2 === 0) {
    console.log(i);
  }
}


// Ejemplo de break en un bucle while
console.log("Contando con while loop y break:");
let num = 1;
let limite = 12;
while (true) {
  console.log(num);
  num++;
  if (num > limite) {
    break;
  }
}

// Ejemplo de nested for loop para imprimir una matriz
console.log("Imprimir matriz con nested for loop:");
const matriz = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9],
];

for (let i = 0; i < matriz.length; i++) {
  for (let j = 0; j < matriz[i].length; j++) {
    console.log(matriz[i][j]);
  }
}

/* Operadores lógicos y ternarios */
console.log("----------")
console.log("Operadores lógicos y ternarios")
console.log("----------")

const edad = 25;
const esMayorDeEdad = edad >= 18;
const tieneCarnetConducir = true;

// Para negar el valor de esMayorDeEdad
if (!esMayorDeEdad) {
  console.log("No eres mayor de edad.");
} else {
  console.log("Eres mayor de edad.");
}

// Para verificar si es mayor de edad y tiene carnet de conducir
if (esMayorDeEdad && tieneCarnetConducir) {
  console.log("Eres mayor de edad y tienes carnet de conducir.");
} else {
  console.log("No cumples con los requisitos para conducir.");
}

// Para verificar si es mayor de edad o tiene carnet de conducir
if (esMayorDeEdad || tieneCarnetConducir) {
  console.log("Cumples con al menos uno de los requisitos para conducir.");
} else {
  console.log("No cumples con los requisitos para conducir.");
}

// Para determinar si es mayor de edad o no
const mensaje = esMayorDeEdad ? "Eres mayor de edad." : "No eres mayor de edad.";
console.log(mensaje);

// Comparamos dos variables utilizando el operador !==
const numero1 = 10;
const numero2 = "10";

if (numero1 !== numero2) {
  console.log("Las variables son diferentes en valor o tipo.");
} else {
  console.log("Las variables son iguales en valor y tipo.");
}

