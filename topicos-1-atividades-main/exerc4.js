/*   Um posto está vendendo combustíveis com a seguinte tabela de descontos:
    - Álcool: até 20 litros, desconto de 3% por litro acima de 20 litros, desconto de 5% por litro
    - Gasolina: até 20 litros, desconto de 4% por litro acima de 20 litros, desconto de 6% por litro

    Escreva um algoritmo que leia o número de litros vendidos, o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), 
    calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 2,50 o preço do litro do álcool é R$ 1,90
    */

    //let litros = 1;
    //let tipo = "A";
    //let valor = 0
function combustivel(litros,tipo,valor){

    if (tipo == "A") {
        valor = litros * 1.90;
    }
    else if (tipo == "G") {
        valor = litros * 2.50;
    }

    console.log("O combustivel será "+ tipo + ", o valor será : R$ "+ valor);
}

module.exports = combustivel;
