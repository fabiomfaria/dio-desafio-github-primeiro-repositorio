namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
      
        // declarando as variaveis com READONLY elas só aceitão atribuições na inialização ou nos construtores
        private readonly string nome = "Fábio";
        private readonly string sobrenome;

        //ctor atalho para criar construtor
        /* public Pessoa()
        {
           nome = string.Empty;
           sobrenome = string.Empty; 
        } */

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe Pessoal");
        }

        public void Apresentar()
        {
           System.Console.WriteLine($"Olá, meu nome é {nome} e meu sobrenome é {sobrenome}"); 
        }
    }
}