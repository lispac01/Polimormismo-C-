namespace Figura
{
    public class Circulo: Figura
    {
        public double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override void MetodoArea()
        {
            Console.WriteLine("El area de un circulo es: PI*radio*radio");
        }

        public double GetArea(){
            return 3.1415*radio*radio;
        }


    }
}