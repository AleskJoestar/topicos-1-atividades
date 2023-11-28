using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEscolar.RegrasDeNegocio;

namespace BibliotecaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("====================== BIBLIOTECA ======================");
            Biblioteca biblioteca = new Biblioteca();
            Livro livro = new Livro();
            int op;

            do
            {
                Console.WriteLine("\n\n$Escolha sua opção:\n" +
                    "1 - Cadastrar LIVRO\n" +
                    "2 - Cadastrar REVISTA\n" +
                    "3 - Cadastrar USUARIO\n" +
                    "4 - Mostrar Produtos Cadastrados\n" +
                    "0 - Sair");
                Console.Write("Sua Escolha: ");
                while (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.Write("Apenas Numeros\n" +
                                  "Sua Escolha: ");
                }
                switch (op)
                {
                    default:
                        Console.WriteLine("Escolha Inválida!");
                        break;
                    case 0:
                        Console.WriteLine("Volte Sempre!");
                        break;
                    case 1:

                        Console.WriteLine("--------- Cadastro Livro ---------");                    
                        Console.Write("Digite o Titulo do Livro: ");
                        livro.Titulo = Console.ReadLine().ToUpper();
                        Console.Write("Digite o Autor do Livro: ");
                        livro.Autor = Console.ReadLine().ToLower();
                        Console.Write("Digite o Ano da publicação do Livro: ");
                        livro.AnoPublicacao = Convert.ToInt32(Console.ReadLine().ToLower());
                        Console.Write("Digite o Numero de paginas do Livro: ");
                        livro.NumeroPaginas = Convert.ToInt32(Console.ReadLine().ToLower());
                        biblioteca.AdicionarLivro(livro);
                        Console.WriteLine($"O Livro {livro.Autor} foi cadastrado com sucesso");
                        break;
                    case 2:
                        Console.WriteLine("\nLista de Livros");
                        biblioteca.ListarLivros();
                        break;
                    /*case 3:
                        Console.WriteLine("--------- Cadastro Camera Fotográfica---------");
                        Console.Write("Digite o Nome da Camera Fotográfica: ");
                        nome = Console.ReadLine().ToUpper();
                        Console.Write("Digite o Marca da Camera Fotográfica: ");
                        marca = Console.ReadLine().ToLower();
                        Console.Write("Digite o Ano de Fabricação da Camera Fotográfica: ");
                        while (!int.TryParse(Console.ReadLine(), out anoFabric))
                        {
                            Console.Write("Digite o Ano de Fabricação da Camera Fotográfica(Somente Numero| Ex: 2012): ");
                        }
                        Console.Write("Digite a Resolução da Camera Fotográfica: ");
                        string resolucao = Console.ReadLine().ToUpper();

                        Camera cadCame = new Camera(nome, marca, anoFabric, resolucao);

                        Console.WriteLine("Adicionar mais detalhes? (S/N)");
                        _cond = Console.ReadLine().ToUpper();
                        while (_cond.Equals("S") || _cond.Equals("SIM"))
                        {
                            Console.WriteLine("*Nova Descrição: ");
                            string desc = Console.ReadLine().ToLower();

                            cadCame.Detalhes(desc);

                            Console.WriteLine("Adicionar mais detalhes? (S/N)");
                            _cond = Console.ReadLine().ToUpper();
                        }

                        produtos.Add(cadCame);
                        break;
                    case 4:
                        Console.WriteLine("\nProdutos Loja Eletrônicos");
                        foreach (ProdutoEletronico produto in produtos)
                        {
                            Console.WriteLine($"Nome: {produto.getNome()}\n" +
                                $"Marca: {produto.getMarca()}\n" +
                                $"Ano Fabricação: {produto.getAnoFabricacao()}\n");
                        }
                        break;*/
                }
            } while (op != 0);





        }
    }
}
