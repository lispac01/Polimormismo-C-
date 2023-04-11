using System;
namespace Figura
{
    public class Triangulo: Figura
    {

     private double altura;
     public double base_t;

     public double Altura 
     {
    
      get { return altura;}
      set { altura = value;}
     }


    public Triangulo(double a,double b){
      this.altura = a;
      this.base_t = b;
    }      

      public override  void MetodoArea()
      {
        
        Console.WriteLine("el area de un triangulo es: (base * altura)/2 ");
        
      }

      public double GetArea(){

        return (base_t*altura)/2;
      }
       
        
    }
}