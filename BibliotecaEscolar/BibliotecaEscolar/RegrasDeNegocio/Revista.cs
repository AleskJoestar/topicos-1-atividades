using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscolar.RegrasDeNegocio
{
    internal class Revista : Livro
    {
        public int EdicaoRevista {  get; set; }

        /*public Revista(string titulo, string autor, int anopublicacao,  int numeropaginas, int edicaorevista) 
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anopublicacao;
            NumeroPaginas = numeropaginas;
            EdicaoRevista = edicaorevista;
        }*/
    }
}
