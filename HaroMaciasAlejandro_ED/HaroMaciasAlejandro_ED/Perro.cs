using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaroMaciasAlejandro_ED
{
    class Perro:Animal
    {
        private string raza;
        private string microchip;

        public string Nombre { get; private set; }
        public string FechaNacimiento { get; private set; }
        public string Peso { get; private set; }

        public Perro(string nombre, string fechaNacimiento, double peso, string raza, string microchip):base(nombre,fechaNacimiento,peso)
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
            return "Perro [raza=" + raza + ",Nombre="+Nombre+ ",Fecha Nacimiento"+FechaNacimiento+",Peso"+ Peso + ",microchip=" + microchip + "]";
        }

    }
}
