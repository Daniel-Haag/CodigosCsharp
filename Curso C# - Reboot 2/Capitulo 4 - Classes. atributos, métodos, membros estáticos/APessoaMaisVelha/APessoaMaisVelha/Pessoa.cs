using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APessoaMaisVelha
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa LerDados()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa.Idade = int.Parse(Console.ReadLine());

            return pessoa;
        }
    }
}
