using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaroMaciasAlejandro_ED
{
    class Reptil:Animal
    {
        private string especie;
        private bool venenoso;


        public Reptil(string nombre, string fechaNacimiento, double peso, string especie, bool venenoso):base(nombre,fechaNacimiento,peso)
        {
            this.especie = especie;
            this.venenoso = venenoso;
        }

        public string getEspecie()
        {
            return especie;
        }


        public bool isVenenoso()
        {
            return venenoso;
        }
        
        string toString()
        {
            return "Reptil [especie=" + especie + ", venenoso=" + venenoso + "]";
        }
    }
}
