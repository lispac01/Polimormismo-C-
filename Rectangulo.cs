namespace Figura
{
    public class Rectangulo: Figura
    {
       

       public double alto;
       public double ancho;

       

       public Rectangulo(double alto,double ancho)
       {
            this.alto = alto;
            this.ancho = ancho;
       }

       public override void MetodoArea(){
        Console.WriteLine("El area de un rectangulo es ancho*largo");

       }

       public double GetArea()
       {
        return alto*ancho;
       }
        
        
    }
}