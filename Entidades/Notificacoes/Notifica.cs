using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Notificacoes
{
    internal class Notifica
    {
        //Construtor para não dar erro
        public Notifica() 

        {
            //Iniciado a propriedade de lista para não dar erro
            Notificacoes = new List<Notifica>(); 
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifica> Notificacoes;
        
        //Válida se dado mandado para API é uma string
        public bool ValidaPropriedadeString(string valor, string nomePropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor)  || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
                return true;
        }

        //Válida se dado mandado para API é uma maior de zero e não possui espaço em branco
        public bool ValidaPropriedadeSDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }
    }
}


