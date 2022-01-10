programa
{
	
	funcao inicio()
	{
		real jan,fev,mar,media, total
		cadeia vendedor

		escreva("Digite o nome do vendedor:")
		leia(vendedor)
		escreva("Digite as vendas de Janeiro: ")
		leia(jan)
		escreva("Digite as vendas de Fevereiro: ")
		leia(fev)
		escreva("Digite as vendas de Março: ")
		leia(mar)
		media=(jan+fev+mar)/3
		total=jan+fev+mar
		escreva("O vendedor: " + vendedor + " teve uma média trimestral: " + media + " e um total de vendas: " + total)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 313; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */