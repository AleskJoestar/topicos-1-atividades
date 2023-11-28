using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscolar.RegrasDeNegocio
{
    internal class Biblioteca
    {
        private List<Livro> livrosDisponiveis = new List<Livro>();
        private List<Revista> revistasDisponiveis = new List<Revista>();
        private List<Usuario> usuariosCadastrados = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public void AdicionarLivro(Livro livro)
        {
            livrosDisponiveis.Add(livro);
        }

        public void AdicionarRevista(Revista revista)
        {
            revistasDisponiveis.Add(revista);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            usuariosCadastrados.Add(usuario);
        }

        public void ListarLivros()
        {
            Console.WriteLine("Livros cadastrados na biblioteca:");
            foreach (var livro in livrosDisponiveis)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}, Páginas: {livro.NumeroPaginas}");
            }
        }

        public void RealizarEmprestimo(Usuario usuario, Livro livro, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista)
        {
            if (livrosDisponiveis.Contains(livro))
            {
                livrosDisponiveis.Remove(livro);
                Emprestimo emprestimo = new Emprestimo
                {
                    Usuario = usuario,
                    Livro = livro,
                    DataEmprestimo = dataEmprestimo,
                    DataDevolucaoPrevista = dataDevolucaoPrevista
                };
                emprestimos.Add(emprestimo);
                Console.WriteLine("Empréstimo realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Livro não disponível para empréstimo.");
            }
        }
    }
}
