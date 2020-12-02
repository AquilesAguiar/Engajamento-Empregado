using System;
class Empregado {
  string nome,sobrenome;
  double salario;

  public Empregado(string n,string s,double sal){
    nome = n;

    sobrenome = s;

    salario = sal;
  }

  public string Nome{ get {return nome;} set{nome = value;} }
  
  public string Sobrenome{  get {return sobrenome;}  set{sobrenome = value;}}

  public double Salario{get {return salario;} set{if(value <= 0 ){
      throw new System.ArgumentException("Salário Inválido");
      }
    else{
      salario = value;
      }
    } 
  }

  public static double aumetaSal(double sal){
    return sal*1.1;
  }

}