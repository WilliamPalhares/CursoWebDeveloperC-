using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proj02.Model; //importando o conteúdo do namespace

namespace Proj02
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario e = new Estagiario();
            e.IdFuncionario = 1;
            e.Nome = "Pedro";
            e.Salario = 1500.0;
            e.Funcao = "Programador";

            Console.WriteLine("Id: {0}, Nome: {1}", e.IdFuncionario, e.Nome);
            Console.WriteLine("Salario: {0:c}, Funcao: {1}", e.Salario, e.Funcao);

            Console.ReadKey();
        }
    }

}
