﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Utils;

namespace backend.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public string email { get; set; }
        public TipoTelefono tipoTelefono { get; set; }
        public string telefono { get; set; }
        public string direccion {  get; set; }
        public Genero genero { get; set; }

        public void guardar()
        {
            if (this.Id == 0)
            {
                this.Id = new Random().Next();
            }
            BaseDeDatos.agregarCliente(this);
        }

        public static Array getDatos()
        {
            return BaseDeDatos.getCliente();
        }
    }
}
