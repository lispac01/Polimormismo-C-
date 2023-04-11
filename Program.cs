using System;


namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
        var figura1 = new Figura();
        
        double b;
        double a;
        double lado;
        double alto;
        double ancho;

        Console.WriteLine("Ingrese la base del triangulo");
        b =  Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo");
        a =  Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado del triangulo");
        lado =  Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el alto del rectangulo");
        alto = Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del rectangulo");
        ancho = Double.Parse(Console.ReadLine());

        



        var figura2 = new Triangulo(a,b,lado);
        var figura3 = new Rectangulo(alto,ancho);

        figura1.MetodoArea();
        figura2.MetodoArea();
        figura3.MetodoArea();
       
       Console.WriteLine($"El area del triangulo de base  {figura2.base_t} y altura  {figura2.Altura} es : " +figura2.GetArea());  
       Console.WriteLine($"El area del rectangulo de alto {figura3.alto} y altura  {figura3.ancho} es : " +figura3.GetArea());  
       Console.WriteLine($"El perimetro del triangulos de lado {figura2.lado} es :"+ figura2.GetPerimetro());
       Console.WriteLine($"El perimetro del rectangulo de alto {figura3.alto} y altura  {figura3.ancho} es : " +figura3.GetPerimetro());
       

        }
    }
}