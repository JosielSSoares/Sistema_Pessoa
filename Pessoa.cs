using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pessoa
{
    public class Pessoa: AbsPessoa
    {   
        //LISTA QUE CONTEM AS PROPRIEDADES DA INTERFACE IPESSOAS ATRIBUIDAS AO OBJETO DEPENDENTES;
        public List<AbsPessoa> Dependentes;
        public Pessoa()
        {   //INICIALIZAÇÃO DA LISTA, PORÉM ESTÁ VÁZIA.
            this.Dependentes = new List<AbsPessoa>();    
        }
    }
}
