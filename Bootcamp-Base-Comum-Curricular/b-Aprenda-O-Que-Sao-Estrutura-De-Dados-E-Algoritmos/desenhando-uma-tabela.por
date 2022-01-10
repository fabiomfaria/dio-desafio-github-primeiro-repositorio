

programa
{
	funcao inicio()
	{
		
		cadeia nome[] = { "Fulano  ", "Beltrano" , "Cicrano ", "Fabio   ", "Fulana  ", "Maria   " }
		real altura[] = { 1.68, 1.72, 1.81, 1.80, 1.64, 1.67 }

		
		escreva ("_____________________________\n")
		escreva ("          RELATORIO          \n")
		escreva ("_____________________________\n")

			  
		para (inteiro posicao = 0; posicao < 6; posicao++)
		{
			escreva (nome[posicao], "\t","|","\t", altura [posicao], "\n")
		}
	}
}


/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 272; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */