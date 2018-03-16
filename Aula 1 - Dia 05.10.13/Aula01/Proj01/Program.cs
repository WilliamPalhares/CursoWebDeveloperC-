using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proj01.Model; //importando o conteúdo do namespace

namespace Proj01
{
    class Program
    {
        //Função (Método) principal do programa
        static void Main(string[] args)
        {
            //Hello World
            //Comando de impressão em prompt
            Console.WriteLine("Aula 01 de C#");
            //snnipet -> [cw] + 2x[tab]
            Console.WriteLine("COTI Informática");
            //Pausar a execução no DOS

            //Objeto para a Classe Pessoa
            Pessoa p = new Pessoa(1, "Ana", "ana@gmail");

            //p.IdPessoa = 1;
            //p.Nome = "Sergio Mendes";
            //p.Email = "sergio.coti@gmail.com";

            //Imprimir [cw] + 2x[tab]
            Console.WriteLine("\nDados de Pessoa:");
            Console.WriteLine("Id....: " + p.IdPessoa);
            Console.WriteLine("Nome..: " + p.Nome);
            Console.WriteLine("Email.: " + p.Email);

            Console.ReadKey();
        }
    }

}
