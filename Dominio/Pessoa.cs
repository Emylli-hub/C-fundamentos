using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pessoa : Entidade
    {
        public Pessoa()
        {
            Endereco = new Endereco();
            Contato = new Contato(); 
        }
        #region Propridades

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        #endregion



        #region  Metodos

        public string DadosPessoa()
            {
                string pessoaDados = $" {Id}-{Nome}-{Contato.NumeroTelefone}-{Contato.Skype}-{Endereco.Cidade}";

                return pessoaDados;
            }

            
        #endregion
    }
}
