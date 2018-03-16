using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proj03.Model; //importando o conteúdo do namespace

namespace Proj03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe -> Objeto
            Cliente c = new Cliente();
            c.IdCliente = 1;
            c.Nome = "Joao";
            
            //Todo atributo de associação deve ser inicializado, pois
            //trata-se de uma Classe
            c.Residencia = new Endereco(); //inicializar -> espaço de memória
            c.Residencia.IdEndereco = 1;
            c.Residencia.Logradouro = "Av Rio Branco 185 - Centro RJ";

            //Imprimindo
            Console.WriteLine("Id do Cliente..: " + c.IdCliente);
            Console.WriteLine("Nome...........: " + c.Nome);
            Console.WriteLine("Logradouro.....: " + c.Residencia.Logradouro);
            Console.ReadKey();
        }
    }
}
