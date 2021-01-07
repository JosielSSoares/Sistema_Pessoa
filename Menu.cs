using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pessoa
{
    public class Menu
    {
        private Cadastro cadastro;
        public Menu()
        {
            this.cadastro = new Cadastro();
        }

        public void Exibir()
        {
            string opcao = "0";
            while (opcao != "4")
            {
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1 - Inserir Pessoa");
                Console.WriteLine("2 - Imprimir Pessoa");
                Console.WriteLine("3 - Imprimir Tudo");
                Console.WriteLine("4 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Pessoa sujeito = this.obterDados();
                    this.cadastro.Inserir(sujeito);
                    Console.ReadLine();
                    
                }
                else if (opcao == "2")
                {

                    Console.WriteLine("Metodo em construção");
                    Console.ReadLine();
                }
                if (opcao == "3")
                {
                    this.cadastro.ImprimirTudo();
                    Console.ReadLine();
             
                }
                Console.Clear();
            }
            Console.WriteLine("Programa encerrado. Aperte enter para continuar");
            return;
        }
         private Pessoa obterDados()
        {
            Pessoa sujeito = new Pessoa();
            Console.Write("Informe o ID da Pessoa:");
            sujeito.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o Nome da Pessoa:");
            sujeito.Nome = Console.ReadLine();

            Console.Write("Informe o Endereco da Pessoa:");
            sujeito.Endereco = Console.ReadLine(); 

            Console.Write("Informe o Telefone:");
            sujeito.Telefone = Console.ReadLine(); 

            Console.Write("Informe o CPF:");
            sujeito.CPF = Console.ReadLine(); 

            return sujeito;
        }
    }
}
