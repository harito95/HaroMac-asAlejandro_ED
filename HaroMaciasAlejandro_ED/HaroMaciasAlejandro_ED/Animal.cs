using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaroMaciasAlejandro_ED
{
    abstract class Animal:IPesable
    {
        private string nombre;
        private string fechaNacimiento;
        private double peso;
        private string comentarios;
        public Animal(string nombre, string fechaNacimiento, double peso)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;

        }
        public string getComentarios()
        {
            return comentarios;
        }
        public void setComentarios(string comentarios)
        {
            this.comentarios = comentarios;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public double getPeso()
        {
            return peso;
        }

        void IPesable.Pesar(double kilos)
        {
            throw new NotImplementedException();
        }
    }
}
