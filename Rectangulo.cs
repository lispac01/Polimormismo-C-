namespace Figura
{
    public class Rectangulo: Figura
    {
       

       private double alto;
       public double ancho;

       public void SetAlto(double alto){

        this.alto = alto;

       }

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