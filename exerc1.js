/***1.** Faça um script que recebe o salário de um colaborador
 *  e o  reajuste segundo o seguinte critério, baseado no 
 * salário atual: 

- salários até R$ 280,00 (incluindo) : aumento de 20%
- salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
- salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
- salários de R$ 1500,00 em diante : aumento de 5%
 Após o aumento ser realizado,
    
    **informe na tela:**
    
    - o salário antes do reajuste;
    - o percentual de aumento aplicado;
    - o valor do aumento;
    - o novo salário, após o aumento.*/

    let salario = 600;

    function calcularReajuste(salario) {
        let percentual = 0;
        let aumento = 0;
    }

    if (salario <= 280) {
       percentual = 20
    }

    else if (salario > 280 && salario <= 700) {
        percentual = 15
    }

    else if (salario >= 700 && salario <= 1500) {
        percentual = 10
    }

    else if (salario < 1500) {
        percentual = 5
    }
   

    aumento = (salario * percentual) / 100;
    const novoSalario = salario + aumento;

    console.log("Salário antes do reajuste: R$ "+ salario);
    console.log("Percentual de aumento: "+ percentual);
    console.log("Valor do aumento: R$ "+ aumento);
    console.log("Novo salário após o aumento: R$ "+ novoSalario);





