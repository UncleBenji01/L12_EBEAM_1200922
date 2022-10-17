using System.Diagnostics.CodeAnalysis;

namespace LAB12_EBEAM_1200922
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Procesar los arreglos llamdo puntos (Notas) ");
            Arreglo ar = new Arreglo();

            ar.calcular();
            ar.mostrar();
           // ar.media();
        }

        class Arreglo
        {
            private double[] puntos;
            public double suma = 0;
            public void calcular()
            {
                puntos=new double[15];
                for (int v = 0; v < 15; v++)
                {
                    Console.WriteLine(" Ingrese una Nota :");
                    string sum;
                    sum=Console.ReadLine();
                    puntos[v]=double.Parse(sum);
                    suma = suma +puntos[v];
                }
            }
            public void mostrar ()
            {
                for (int v = 0; v < 15; v++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine(puntos[v]);
                }
                Console.WriteLine("La suma es : " + suma);
                Console.WriteLine("Y su promedio es : " + suma/15);
                Console.ReadKey();
            }

        }
    }
}