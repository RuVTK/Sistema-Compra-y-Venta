using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Utils;

namespace backend.Models
{
    public class TipoTelefono
    {
        public int Id { get; set; }
        public string descripcion { get; set; }

        public void guardar()
        {
            if (this.Id == 0)
            {
                this.Id = new Random().Next();
            }
            BaseDeDatos.agregarTelefono(this);
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
