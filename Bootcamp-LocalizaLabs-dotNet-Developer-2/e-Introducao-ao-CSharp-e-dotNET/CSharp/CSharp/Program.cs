using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = (Pessoas)1;
            Console.WriteLine(pessoa);

            Pessoas pessoa2 = Pessoas.Jesus;
            Console.WriteLine(pessoa2);

            Pessoas pessoa3 = (Pessoas)2;
            Console.WriteLine(pessoa3);
            
            Pessoa person = new Pessoa();
            person.Nome = "Fábio";
            person.Idade = "25";
            person.Estado = "SC";

            var person2 = new Pessoa();
            person2.Nome = "Jesus";
            person2.Idade = "33";
            person2.Estado = "NJ";

            Animal animal = new Animal();
            animal.Nome = "Billy";
            animal.NomeDono = "Fábio";
            animal.Especie = "cachorro";

            
            Console.WriteLine("Hello World!");
        }
    }
}
