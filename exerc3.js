/*Faça um script que leia um número e exiba o dia correspondente da 
semana. (1-Domingo, 2- Segunda, etc.), se digitar outro valor deve aparecer valor inválido.*/

//let diaSemana = 1
function diaDaSemana(diaSemana){

    if (diaSemana == 1) {
        console.log("Domingo");
    } 
    else if (diaSemana == 2) {
        console.log("Segunda-Feira");
    }
    else if (diaSemana == 3) {
        console.log("Terça-Feira");
    }
    else if (diaSemana == 4) {
        console.log("Quarta-Feira");
    }
    else if (diaSemana == 5) {
        console.log("Quinta-Feira");
    }
    else if (diaSemana == 6) {
        console.log("Sexta-Feira");
    }
    else if (diaSemana == 7) {
        console.log("Sabado");
    }
}

module.exports = diaDaSemana;
