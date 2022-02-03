using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        // delegate
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            
           int fib, n, z;
           n=3;

                 
                     z=(n+1) + (n-2);
                System.Console.WriteLine("res é: " + z);
                
          

            

            
            
            
            
            int k, result;
            result = 0;
            for(k=0; k<5; k++)
            {
                if((k%3)==1)
                {
                    result=result+k;
                }
                else
                {
                    result=result+1;
                }
            }
            System.Console.WriteLine("Resultado é: " + result);
            
            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            //teste de delegate da classe calculadora
            Operacao op = new Operacao(Calculadora.Subtrair);
            
            // chamada para multcast delegate
            //op += Calculadora.Somar;
            
            op.Invoke(14,7);
            //outra opção
            // Operacao op = Calculadora.Somar;
            // op(6,1);
            
            // exemplo de constante
            const double pi = 3.14;
            System.Console.WriteLine(pi);

            // teste classe DataPropriedade - Propriedade em vez de Get e Set
            DataPropriedade dataP = new DataPropriedade();
            dataP.Mes = 12;

            dataP.ApresentarMesP();
        

            
            // teste classe Data - Get e Set
            Data data = new Data();
            data.SetMes(2);

            data.ApresentarMes();

            
            // teste classe Log
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);
            
            // teste classe Pessoa
            Pessoa p1 = new Pessoa("Jesus","Cristo");
            p1.Apresentar();

            // teste classe Aluno
            Aluno a1 = new Aluno("Fulano", "de Tal", "dotNet");
            a1.Apresentar();
        }
    }  
}


