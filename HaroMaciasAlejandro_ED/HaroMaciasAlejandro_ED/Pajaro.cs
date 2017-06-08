using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaroMaciasAlejandro_ED
{
    class Pajaro:Animal
    {
        private string especie;
        private bool cantor;

        public Pajaro(string nombre, string fechaNacimiento, double peso, string especie, bool cantor):base(nombre,fechaNacimiento,peso)
        {
            this.especie = especie;
            this.cantor = cantor;
        }

        public string getEspecie()
        {
            return especie;
        }
        public bool isCantor()
        {
            return cantor;
        }

        
        string toString()
        {
            return "Pajaro [especie=" + especie + ", cantor=" + cantor + "]";
        }
    }
}
