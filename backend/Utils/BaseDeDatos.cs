using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Utils
{
    public class BaseDeDatos
    {
        public static Dictionary<int, Genero> TABLA_GENEROS = new Dictionary<int, Genero>();
        public static Dictionary<int, TipoTelefono> TIPO_TELEFONO = new Dictionary<int, TipoTelefono>();
        public static Dictionary<int, Cliente> TABLA_CLIENTES = new Dictionary<int, Cliente>();
        public static void agregarGenero(Genero genero)
        {
            if (genero.id == 0)
            {
                genero.id = new Random().Next();
            }
            TABLA_GENEROS[genero.id] = genero;
        }
        public static Array getGenero() 
        {
            return TIPO_TELEFONO.Values.ToArray();
        }

        public static void agregarTelefono(TipoTelefono telefono)
        {
            if (telefono.Id == 0)
            {
                telefono.Id = new Random().Next();
            }
            TIPO_TELEFONO[telefono.Id] = telefono;
        }

        public static Array getTelefono()
        {
            return TIPO_TELEFONO.Values.ToArray();
        }

        public static void agregarCliente(Cliente cliente)
        {
            if(cliente.Id == 0)
            {
                cliente.Id = new Random().Next();
            }
            TABLA_CLIENTES[cliente.Id] = cliente;
        }

        public static Array getCliente()
        {
            return TABLA_CLIENTES.Values.ToArray();
        }
    }
}
