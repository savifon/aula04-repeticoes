using System;

class MainClass {
  public static void Main (string[] args) {
		/*
		//Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

		bool valido = false;
		double nota;

		while (!valido){
			Console.Write ("Informe uma nota entre 0 e 10: ");
			nota = double.Parse(Console.ReadLine());

			if (nota >= 0 && nota <= 10)
				valido = true;
			else
				Console.WriteLine("* VALOR INVÁLIDO *");
		}
		*/

		//Faça um programa que leia 5 números e informe o maior número.
		double numero, maiornumero=-1;
		for (int i=0; i<5; ++i) {
			Console.Write ("Informe um número: ");
			numero = double.Parse(Console.ReadLine());

			if (numero > maiornumero)
				maiornumero = numero;
		}

		Console.WriteLine ("O maior número informado foi: {0}", maiornumero);
  }
}