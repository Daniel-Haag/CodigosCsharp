using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Quem é a pessoa mais velha?");
            Console.WriteLine("Dados da primeira pessoa:");
            primeiraPessoa = primeiraPessoa.LerDados();
            Console.WriteLine("Dados da segunda pessoa:");
            segundaPessoa = segundaPessoa.LerDados();

            if(primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine(primeiraPessoa.Nome + " é mais velho(a) que " + segundaPessoa.Nome);
            }
            else if(primeiraPessoa.Idade == segundaPessoa.Idade)
            {
                Console.WriteLine("As duas pessoas tem a mesma idade.");
            }
            else
            {
                Console.WriteLine(segundaPessoa.Nome + " é mais velho(a) que " + primeiraPessoa.Nome);
            }

            Console.Read();
        }
    }
}
