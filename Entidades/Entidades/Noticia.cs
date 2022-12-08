using Entidades.Notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    //Serve para o banco criar com o nome que eu colocar [Table("TB_NOTICIA")]
    [Table("TB_NOTICIA")]
    //Erdou a classe Notifica
    internal class Noticia : Notifica
    {
        [Column("NTC_ID")]
        public string Id { get; set; }

        [Column("NTC TITULO")]
        [MaxLength(255)]
        public string? Titulo { get; set; }

        [Column("NTC_INFORMACAO")]
        public string? Informacao { get; set; }

        [Column("NTC_ATIVO")]
        public bool Ativo { get; set; }

        [Column("NTC_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("NTC_DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]

        public string? UserId {get; set;}
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
