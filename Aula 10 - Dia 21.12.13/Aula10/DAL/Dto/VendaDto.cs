using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Dto
{
    public class VendaDto
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string Loja { get; set; }
    }
}
