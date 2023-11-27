/*1. Faça um script para o cálculo de uma folha de pagamento, sabendo que os descontos 
são do Imposto de Renda, que depende do salário bruto (conforme tabela abaixo) e 10% para o INSS e que o FGTS 
corresponde a 11% do Salário Bruto, mas não é descontado (é a empresa que deposita). O Salário 
Líquido corresponde ao Salário Bruto menos os descontos. O script deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês.

Desconto do IR:
Salário Bruto até 900 (inclusive) - isento
Salário Bruto até 1500 (inclusive) - desconto de 5%
Salário Bruto até 2500 (inclusive) - desconto de 10%
Salário Bruto acima de 2500 - desconto de 20% 

Imprima na tela as informações, dispostas conforme o exemplo abaixo. 
    
    
    **No exemplo o valor da hora é 5 e a quantidade de hora é 220.** 
    
    Salário Bruto: (5h * R$ 220,00)        : R$ 1100,00
    (-) IR (5%)                                        : R$   55,00
    (-) INSS ( 10%)                                : R$  110,00
    FGTS (11%)                                     : R$  121,00
    Total de descontos                           : R$  165,00
    Salário Liquido                                 : R$  935,00
    
    Impressão na tela conforme o exemplo acima.*/


    //let valorHora = 5;
    //let horasTrabalhadas = 220;

function calcularSalario(valorHora, horasTrabalhadas){
    let inss=0;
    let salarioBruto=0;

    salarioBruto = valorHora * horasTrabalhadas;
    
    inss = salarioBruto * 0.1;

    

        let percentual = 0;
        let desconto = 0;   

    if (salarioBruto <= 900) {
        percentual = 0;
        console.log("isento de IR");
        
     }
 
     else if (salarioBruto > 900 && salarioBruto <= 1500) {
         percentual = 5;
     }
 
     else if (salarioBruto > 1500 && salarioBruto <= 2500) {
        percentual = 10;
     }
 
     else if (salarioBruto > 2500) {
        percentual = 20;
     }
     
     salarioliquido = salarioBruto - inss-(salarioBruto*(percentual/100));
  
   

    console.log("Salário Bruto: R$ "+ salarioBruto);
    console.log("Salário Liquido: R$ "+ salarioliquido);
}
    
    module.exports = calcularSalario;


