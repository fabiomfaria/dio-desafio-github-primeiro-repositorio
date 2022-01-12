using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal interface IAnimal
    {
        void Nome(String nome);
        void Dono(String nomeDono);
        void Especie(string especie);
    }
    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome) 
        { 
            this.Nome = nome; 
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void IAnimal.Especie(string especie) 
        {
            this.Especie = especie; 
        }
    }
}
