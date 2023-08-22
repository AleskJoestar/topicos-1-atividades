/*1. O Hipermercado Assaí está com uma promoção de carnes que é imperdível. Confira:
    
                      Até 5 Kg               Acima de 5 Kg
    
    File Duplo      R$ 4,90 por Kg          R$ 5,80 por Kg
    
    Alcatra           R$ 5,90 por Kg          R$ 6,80 por Kg
    
    Picanha          R$ 6,90 por Kg          R$ 7,80 por Kg
    

Para atender a todos os clientes, cada cliente poderá levar apenas um dos tipos de carne da promoção, porém não há limites para 
a quantidade de carne por cliente. Se compra for feita no cartão Assaí o cliente receberá ainda um desconto de 5% sobre o total a compra. 

Escreva um script que peça o tipo e a quantidade de carne comprada pelo usuário e gere um cupom fiscal, 
contendo as informações da compra: tipo e quantidade de carne, preço total, tipo de pagamento, valor do desconto e valor a pagar.*/ 

/*let tipoCarne = "Picanha";
let quantidadeCarne = 1;
let kgCarne = 2.0;
let valorDesconto = 0;
let valoraPagar = 0;
let valorTotal = 0;
let totalAPagar = 0;
let desconto = 0;
let tipoPagamento = "Cartão Assai"*/

function mercado(tipoCarne, quantidadeCarne, kgCarne, valorDesconto, valoraPagar, valorTotal, totalAPagar ,desconto, tipoPagamento ){

if (tipoCarne == "File Duplo") {
    if (quantidadeCarne <=5) {
        kgCarne = 4.9;
    }
    else if (quantidadeCarne > 5) {
        kgCarne = 5.8;
    }
}
else if (tipoCarne == "Alcatra") {
    if (quantidadeCarne <=5) {
        kgCarne = 5.9
    }
    else if (quantidadeCarne > 5) {
        kgCarne = 6.8
    }
}
else if (tipoCarne == "Picanha") {
    if (quantidadeCarne <=5) {
        kgCarne = 6.9
    }
    else if (quantidadeCarne > 5) {
        kgCarne = 7.8
    }
}
if (tipoPagamento == "Cartão Assai") {
    desconto = 0.05;
}

totalAPagar = quantidadeCarne + kgCarne;
valorDesconto = totalAPagar * desconto;
totalAPagarcomDesconto = totalAPagar - desconto;

console.log("TIPO DE CARNE: "+ tipoCarne+"\n PREÇO TOTAL: "+totalAPagar+"\n TIPO DE PAGAMENTO: "+tipoPagamento+"\n VALOR DESCONTO: "+
 valorDesconto+"\n VALOR A PAGAR: "+totalAPagarcomDesconto);

}

module.exports = mercado;
