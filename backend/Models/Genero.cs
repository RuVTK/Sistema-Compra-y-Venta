using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Utils;

namespace backend.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public void guardar()
        {
            if (this.id == 0)
            {
                this.id = new Random().Next();
            }
            BaseDeDatos.agregarGenero(this);
        }

        public static Array getDatos()
        {
            return BaseDeDatos.getGenero();
        }
    }

    
}
