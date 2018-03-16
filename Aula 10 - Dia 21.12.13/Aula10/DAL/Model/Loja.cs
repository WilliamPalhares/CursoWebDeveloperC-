using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //ORM

namespace DAL.Model
{
    [Table("Loja")]
    public class Loja
    {
        [Key] //Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity
        [Column("IdLoja")]
        public int IdLoja { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        //Associação -> N Vendas
        public List<Venda> Vendas { get; set; }
    }
}
