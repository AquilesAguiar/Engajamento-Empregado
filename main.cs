using System;

class MainClass {
  public static void Main (string[] args) {
   Empregado Profissional1 = new Empregado("Aquiles","Aguiar",50000);
   
   Empregado Profissional2 = new Empregado("Flamengo","Campeão",100000000);

   //Throw 
   //Profissional2.Salario = 0;

   //Aumenta Salario
  //Profissional2.Salario = Empregado.aumetaSal(Profissional2.Salario);


   Console.WriteLine($"Profissional 1 {Profissional1.Salario}");

   Console.WriteLine($"Profissional 2 {Profissional2.Salario}");
  }
}