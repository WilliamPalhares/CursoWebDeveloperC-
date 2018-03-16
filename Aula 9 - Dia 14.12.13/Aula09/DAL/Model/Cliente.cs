using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //ORM

namespace DAL.Model
{
    [Table("Cliente")] //Anotação / etiqueta
    public class Cliente
    {
        [Key] //chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        public string Email { get; set; }
    }

}
