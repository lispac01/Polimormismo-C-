﻿using System;


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
        double radio;

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

         Console.WriteLine("Ingrese el radio del circulo");
        radio = Double.Parse(Console.ReadLine());


        



        var figura2 = new Triangulo(a,b,lado);
        var figura3 = new Rectangulo(alto,ancho);
        var figura4 = new Circulo(radio);

        figura1.MetodoArea();
        figura2.MetodoArea();
        figura3.MetodoArea();
        figura4.MetodoArea();
       
       figura2.ImprimirTriangulo();
       Console.WriteLine($"El area del triangulo de base  {figura2.base_t} y altura  {figura2.altura} es : " +figura2.GetArea());  
       Console.WriteLine($"El perimetro del triangulos de lado {figura2.lado} es :"+ figura2.GetPerimetro());
       figura3.ImprimirRectangulo();
       Console.WriteLine($"El area del rectangulo de alto {figura3.alto} y altura  {figura3.ancho} es : " +figura3.GetArea());  
       Console.WriteLine($"El perimetro del rectangulo de alto {figura3.alto} y altura  {figura3.ancho} es : " +figura3.GetPerimetro());
       figura4.ImprimirCirculo();
       Console.WriteLine($"El area del circulo de radio {figura4.radio} es: "+ figura4.GetArea());
       Console.WriteLine($"El perimetro del circulo de radio {figura4.radio} es: "+figura4.GetPerimetro());
      
       

        }
    }
}