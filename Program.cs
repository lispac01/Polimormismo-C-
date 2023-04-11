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
        double alto;
        double ancho;

        Console.WriteLine("Ingrese la base del triangulo");
        b =  Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo");
        a =  Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el alto del rectangulo");
        alto = Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del rectangulo");
        ancho = Double.Parse(Console.ReadLine());




        var figura2 = new Triangulo(a,b);
        var figura3 = new Rectangulo(alto,ancho);

        figura1.MetodoArea();
        figura2.MetodoArea();
        figura3.SetAlto(50);
        figura3.MetodoArea();
       
       Console.WriteLine($"El area del triangulo de base  {figura2.base_t} y altura  {figura2.Altura} es : " +figura2.GetArea());  
       Console.WriteLine($"El area del rectangulo de alto {figura3.SetAlto} y altura  {figura3.ancho} es : " +figura3.GetArea());  

        }
    }
}