using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; //ORM

namespace DAL.Model
{
    [Table("Venda")]
    public class Venda
    {
        [Key] //chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity
        [Column("IdVenda")]
        public int IdVenda { get; set; }

        [Column("DataVenda")]
        public DateTime DataVenda { get; set; }

        [Column("Valor")]
        public double Valor { get; set; }

        //Propriedade para representar a chave estrangeira
        //Só é necessária pois estamos trabalhando com EntityFramework
        [Column("IdLoja")] //nome da coluna na tabela
        public int IdLojaFK { get; set; }

        //Associação -> 1 Loja
        [ForeignKey("IdLojaFK")] //nome do atributo da Classe
        public virtual Loja Loja { get; set; }
    }
}
