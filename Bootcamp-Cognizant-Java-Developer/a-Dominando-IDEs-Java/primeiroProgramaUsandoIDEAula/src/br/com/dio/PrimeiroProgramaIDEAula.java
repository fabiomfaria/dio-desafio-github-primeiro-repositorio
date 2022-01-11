package br.com.dio;

import br.com.dio.model.Gato;

public class PrimeiroProgramaIDEAula {

	public static void main(String[] args) {
		Gato gato = new Gato(null, null, null);
		//Livro livro = new Livro();

		System.out.println(gato);

	}

	class Livro {
		private String nome;
		private String npag;

		public Livro(String nome, String npag) {
			this.setNome(nome);
			this.setNpag(npag);
		}

		public String getNome() {
			return nome;
		}

		public void setNome(String nome) {
			this.nome = nome;
		}

		public String getNpag() {
			return npag;
		}

		public void setNpag(String npag) {
			this.npag = npag;
		}
	}
}
