using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pessoa
{
    public interface iPessoa
    {
        int Id { get; set; }

        string Nome { get; set; }

        string Endereco { get; set; }

        string Telefone { get; set; }

        string CPF { get; set; }

    }
}
