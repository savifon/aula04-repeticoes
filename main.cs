using System;

/*
Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
*/

class MainClass {
  public static void Main (string[] args) {
		bool valido = false;
		double nota;

		while (valido==false){
			Console.Write ("Informe uma nota entre 0 e 10: ");
			nota = double.Parse(Console.ReadLine());

			if (nota >= 0 && nota <= 10)
				valido = true;
			else
				Console.WriteLine("* VALOR INVÁLIDO *");
		}
  }
}