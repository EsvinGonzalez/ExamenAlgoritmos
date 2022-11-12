using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Empleados
    {
        private float[] turnoMañana;
        private float[] turnoTarde;

        public void Cargar() 
        {
            string linea;
            turnoMañana=new float[4];
            turnoTarde=new float[4];
            Console.WriteLine("Sueldo de empleados del turno por la mañana:");
            for(int f = 0; f < 4; f++) 
            {
                Console.Write("Ingrese sueldo:  Q.");
                linea = Console.ReadLine();              
                turnoMañana[f]=float.Parse(linea);
            }
            Console.WriteLine("Sueldo de empleados del turno por la tarde:");
            for(int f = 0; f < 4; f++) 
            {
                Console.Write("Ingrese sueldo: Q.");
                linea = Console.ReadLine();              
                turnoTarde[f]=float.Parse(linea);
            }
        }

        public void CalcularGastostotales() 
        {
            float mañana=0;
            float tarde=0;
            for(int f = 0; f < 4; f++)
            {
                mañana=mañana+turnoMañana[f];
                tarde=tarde+turnoTarde[f];
            }
            Console.WriteLine("Gastos del turno de la mañana:  Q."+mañana);
            Console.WriteLine("Gastos del turno de la tarde:  Q."+tarde );
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Empleados pv = new Empleados();
            pv.Cargar();
            pv.CalcularGastostotales();
        }
    }
}