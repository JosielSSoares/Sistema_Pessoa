﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pessoa
{
    public abstract class AbsPessoa: iPessoa
    {
        public AbsPessoa()
        { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }


    }
}
