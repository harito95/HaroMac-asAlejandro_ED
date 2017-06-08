using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaroMaciasAlejandro_ED
{
    class Gato:Animal
    {
        private string raza;
        private string microchip;


        public Gato(string nombre, string fechaNacimiento, double peso, string raza,string microchip):base(nombre,fechaNacimiento,peso)
        {
       
            this.raza = raza;
            this.microchip = microchip;
        }


        public string getRaza()
        {
            return raza;
        }


        public string getMicrochip()
        {
            return microchip;
        }


        
     string toString()
        {
            return "Gato [raza=" + raza + ", microchip=" + microchip + "]";
        }
    }
}
