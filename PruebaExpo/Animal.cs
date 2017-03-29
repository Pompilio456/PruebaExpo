using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExpo
{
    public class Animal
    {
        string nombre;
        string habitad;
        public Animal(string nombre,string habitad)
        {
            this.nombre = nombre;
            this.habitad = habitad;
        }

        public string Datos()=> "El animal se llama "+nombre
    }
}
