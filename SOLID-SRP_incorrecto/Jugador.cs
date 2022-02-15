using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_incorrecto
{
    class Jugador
    {


        public string Nombre { get; set; }
        public string Clase { get; set; }
        public float Fuerza { get; set; }
        public float Salud { get; set; }
        public Jugador(string nombre, string clase, float fuerza, float salud)
        {
            Nombre = nombre;
            Clase = clase;
            Fuerza = fuerza;
            Salud = salud;
        }

        public void Atacar()
        {
            Console.WriteLine("Atacando con " + Fuerza + " De fuerza");
            Console.WriteLine("...Guardando Arma");
        }
        public void Curar()
        {
            Console.WriteLine("Estado de salud = " + Salud);
            Console.WriteLine("Curando...");
            Salud += 1;
            Console.WriteLine("Estado de salud = " + Salud);
        }
        public void CargarModelo3D()
        {
            Console.WriteLine("Cargando modelo del jugador... " + Nombre);
        }
        public void Animar()
        {
            Console.WriteLine("INGRESE 1 para cargar animación básica\n2 Para animación completa");
            Console.ReadLine();
            Console.WriteLine("Animando a " + Nombre);
            Console.ReadKey();
        }
    }
}
