using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_incorrecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("NO SRP");
            Jugador jugador = new Jugador("tony", "Ladron", 10, 50);
            jugador.Atacar();
            jugador.Curar();
            jugador.CargarModelo3D();
            jugador.Animar();
        }
    }
}
