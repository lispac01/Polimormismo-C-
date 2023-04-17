using System;
namespace Figura
{
    public class Triangulo: Figura
    {

     public double altura;
     public double base_t;
     public double lado;

    public Triangulo(double a,double b,double lado){
      this.altura = a;
      this.base_t = b;
      this.lado = lado;
    }      

      public void ImprimirTriangulo()
      {
       Console.WriteLine("Soy un triangulo");
      }
      public override  void MetodoArea()
      {
        
        Console.WriteLine("el area de un triangulo es: (base * altura)/2 ");
        
      }

      public double GetArea(){

        return (base_t*altura)/2;
      }

      public double GetPerimetro()
      {
        return 3*lado;
      }
       
        
    }
}