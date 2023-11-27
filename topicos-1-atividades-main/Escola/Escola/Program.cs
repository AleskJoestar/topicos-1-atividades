using Escola.RegrasDeNegocio;

internal class Program
{
    public static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[2];
        
        funcionarios[0] = new Professor("Anderson", 25, 2000, "Portugues");
        funcionarios[1] = new Administrativo("José", 30, 3.000, "RH");
        funcionarios[2].CalcularSalario();

        Console.WriteLine($"O salario do professor será {funcionarios[2].ToString()}");





        //Console.WriteLine($"O Salario do professor será {Professor.Salario}");
        //Console.WriteLine($"O Salario do administrativo será {Administrativo.Salario}");
        

    }


}
