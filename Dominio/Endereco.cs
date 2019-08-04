﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Endereco : Entidade 
    {
        //Logradouro
        //Numero
        //Complemento
        //Bairro
        //CEP
        //Cidade
        //Estado

        //Adicionar Endereco como propriedade de Pessoa

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

    }
}
