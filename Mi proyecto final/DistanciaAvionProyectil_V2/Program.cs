using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaAvionProyectil_V2
{
    class Program
    {
        public double CalculoHipotenusa(double x, double y)
        {
            double hip = 0.0;
            hip = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return hip;
        }

        public void CalculoDistancia()
        {
            double vi_avion = 222.222;
            double vi_proyectil = 222.222;
            double a_avion = 20.0;
            double a_proyectil = 10.0;
            double d_avion = 0.0;
            double d_proyectil = 0.0;
            double d_total = 0.0;
            int t = 0;

            do
            {
                d_avion = (vi_avion * t) + (a_avion * (t ^ 2)) / 2;
                d_proyectil = (vi_proyectil * t) + (a_proyectil * (t ^ 2)) / 2;
                d_total = CalculoHipotenusa(d_avion, d_proyectil);
                t = t + 1;
                Console.WriteLine("Para t= " + t + "seg, La distancia entre ellos es de: " + d_total + ".");
            } while (d_total < 10000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Saludos somos el grupo Innovators, seccion 0463, los integrantes son:\n");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Andres Cabrera 17-EIIT-1-050\n" +
                "Aurely Reyes 17-EIIT-1-030\n" +
                "Jumery Mateo 17-EIIT-1-013\n" +
                "Radames Aquino 17-EIIT-1-130\n" +
                "Karla Beltre 17-EIIT-1-132\n" +
                "Oscar Rivera 17-EIIT-1-133");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("	Problema: Un avion que viaja 800 Km/hr. Dispara un proyectil autoimpulsado, en el momento del disparo,\n" +
          " el avion hace un giro de 90 0 y acelera a 20 mtrs/seg2. El proyectil sigue su curso, acelerando a 10 mtrs./seg2.Disene \n" +
          "un programa que escriba cada segundo, la distancia que separa al avion del proyectil, hasta que esten a 10,000 mtrs. o mas.\n");
            Console.WriteLine("Presione una Tecla para continuar.");
            Console.ReadKey();
            Program d = new Program();
            d.CalculoDistancia();

        }
    }
}
