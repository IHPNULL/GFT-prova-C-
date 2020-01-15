using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoac> lista = new List<Pessoac>();

            Pessoac pessoa1 = new Pessoac("Joao", 15);
            Pessoac pessoa2 = new Pessoac("Leandro", 21);
            Pessoac pessoa3 = new Pessoac("paulo", 17);
            Pessoac pessoa4 = new Pessoac("jessica", 18);

            lista.Add(pessoa1);
            lista.Add(pessoa2);
            lista.Add(pessoa3);
            lista.Add(pessoa4);


            foreach (Pessoac pessoac in lista)
            {
                Console.WriteLine(pessoac.Nome + "  " + pessoac.Idade);
            }

            List<Pessoac> sorted = lista.OrderBy(Pessoac => Pessoac.Idade).ToList();

            int tam = lista.Count();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Resultado exercicio 1:\nPessoa mais velha: " + sorted[tam - 1].Nome);
            Console.WriteLine("-----------------------------------------------");


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Resultado exercicio 2 e 3: \n");
            Console.WriteLine("A lista possui " + lista.Count() + " itens.\n");

            List<Pessoac> maiores = new List<Pessoac>();

            for (int i=0;i<lista.Count();i++)
            {
                if (lista[i].Idade >= 18)
                {
                    maiores.Add(new Pessoac(lista[i].Nome, lista[i].Idade));
                }
            }

            Console.WriteLine("A lista de maiores de idade possui " + maiores.Count() + " pessoas\n");

            foreach (Pessoac pessoac in maiores)
            {
                Console.WriteLine(pessoac.Nome + "  " + pessoac.Idade);
            }
            foreach(Pessoac i in lista)
            {
                if (i.Nome == "jessica")
                    Console.WriteLine("\nA jessica existe\n");
            }


            Console.WriteLine("-----------------------------------------------");


            Vendedor v = new Vendedor("vlademir", 46, 4000);
            Gerente g = new Gerente("craudio", 32, 7000);
            Supervisor s = new Supervisor("juliana", 17, 15000);

            Console.WriteLine(v.Nome + " Ganha " + v.Salario + " e tem " + v.Idade + " anos. se receber uma bonificaçao este mes receberá " + v.Bonificacao());
            Console.WriteLine(g.Nome + " Ganha " + g.Salario + " e tem " + g.Idade + " anos. se receber uma bonificaçao este mes receberá " + g.Bonificacao());
            Console.WriteLine(s.Nome + " Ganha " + s.Salario + " e tem " + s.Idade + " anos. se receber uma bonificaçao este mes receberá " + s.Bonificacao());
        }
    }



    class Pessoac
    {
        public Pessoac(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;
        }

        public int Idade { get; set; }
        public string Nome { get; set; }

    }

    class Funcionarios
    {
        private string nome;
        private int idade;
        private double salario;

        public Funcionarios(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
        }

        public double Bonificacao()
        {
            return this.Salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Salario { get => salario; set => salario = value; }
    }

    class Gerente : Funcionarios
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public double Bonificacao()
        {
            return (this.Salario+10000);
        }
    }
    class Supervisor : Funcionarios
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public double Bonificacao()
        {
            return (this.Salario + 5000);
        }
    }
    class Vendedor : Funcionarios
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public double Bonificacao()
        {
            return (this.Salario + 3000);

        }
    }
}