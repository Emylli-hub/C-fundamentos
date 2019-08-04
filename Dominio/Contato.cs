using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contato : Entidade
    { 
        [Display(Name = "Telefone")]
        public string NumeroTelefone { get; set; }
        public string NumeroTelefoneResidencial { get; set; }
        public int EMail { get; set; }
        public string Skype { get; set; }

    }
}
