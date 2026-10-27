import prompt from 'prompt-sync';
let ler = prompt();

console.log("Informe o valor total da compra e a quantidade de parcelas:");
let valorCompra = Number(ler());
let qtdParcelas = Number(ler());

let valorParcela = valorCompra / qtdParcelas;

console.log(`Sua compra de R$ ${valorCompra} em ${qtdParcelas}x de R$ ${valorParcela} foi concluída`);
