using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pessoa
{
    public class Cadastro
    {

        public List<Pessoa> Pessoas;
        public Cadastro()
        {
            this.Pessoas = new List<Pessoa>();
        }

        //ADICIONAR ELEMENTO NA LISTA
        public void Inserir(Pessoa pes)
        {
            this.Pessoas.Add(pes);
            Console.WriteLine("Registro adicionado com sucesso");
            return;
        }

        public void ImprimirPessoa(int id)
        {
            Pessoa sujeito = this.Pessoas.Find(pes => pes.Id == id);
            if(sujeito == null)
            {
                Console.WriteLine("Registro não foi encontrado");
                return;
            }
            else
            {
                this.ImprimirPessoa(sujeito);
                return;
            }
        }

        //IMPRIMIR TODOS ELEMENTOS JÁ ADICIONADOS NA LISTA.
        public void ImprimirTudo()
        {
            foreach (Pessoa item in this.Pessoas)
            {
                this.ImprimirPessoa(item);
                Console.WriteLine("##########################################");           
            }
        }

        private void ImprimirPessoa(Pessoa pessoa) 
        {
            Console.WriteLine("Id: {0}", pessoa.Id);
            Console.WriteLine("Nome: {0}", pessoa.Nome);
            Console.WriteLine("Endereço: {0}", pessoa.Endereco);
            Console.WriteLine("Telefone: {0}", pessoa.Telefone);
            Console.WriteLine("CPF: {0}", pessoa.CPF);
        }
    }
}
