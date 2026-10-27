import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe a base e altura de dois retângulos:");
let baseRetangulo1 = Number(ler());
let alturaRetangulo1 = Number(ler());
let baseRetangulo2 = Number(ler());
let alturaRetangulo2 = Number(ler());

let areaRetangulo1 = baseRetangulo1 * alturaRetangulo1;
let areaRetangulo2 = baseRetangulo2 * alturaRetangulo2;
let saoIguais = areaRetangulo1 == areaRetangulo2;

console.log(`O primeiro retângulo possui área ${areaRetangulo1}.
O segundo retângulo possui área ${areaRetangulo2}.
Eles são iguais? ${saoIguais}`);