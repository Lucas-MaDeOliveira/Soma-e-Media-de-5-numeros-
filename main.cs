using System;

class Program {
  public static void Main (string[] args) {
    int soma=0;
    int media;
    for(int i=0; i<5; i++)
    {
      Console.WriteLine ("Digite um número");
      int numero = Convert.ToInt32(Console.ReadLine());
      soma=soma+numero;
    }
    media = soma/5;
    Console.WriteLine ("A média é: "+media);
    
  }
}