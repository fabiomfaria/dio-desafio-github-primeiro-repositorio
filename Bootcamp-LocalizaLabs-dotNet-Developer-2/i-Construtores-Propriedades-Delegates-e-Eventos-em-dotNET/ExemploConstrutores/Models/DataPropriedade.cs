namespace ExemploConstrutores.Models
{
    public class DataPropriedade
    {
        private int mes;
        private bool mesValido;

       public int Mes
       {
           get
           {
               return this.mes;
           }

           set
           {
               if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
           }
       } 

        public void ApresentarMesP()
        {
          if(this.mesValido)
          {
              System.Console.WriteLine(this.mes);
          }  
          else
          {
              System.Console.WriteLine("Mês inválido");
          }
        }

    }
}