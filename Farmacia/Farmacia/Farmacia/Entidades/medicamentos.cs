using System;

namespace Farmacia.Entidades
{
    internal class Medicamentos
    {
        private string id;
        private string nombre;
        private string descripcion;
        private string fecha_ingreso;
        private double precio_unitario;
        private int cantidad;

        public Medicamentos()
        {
        }

        public Medicamentos(string id, string nombre, string descripcion, string fecha_ingreso, double precio_unitario, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_ingreso = fecha_ingreso;
            this.precio_unitario = precio_unitario;
            this.cantidad = cantidad;
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public string Fecha_ingreso
        {
            get
            {
                return fecha_ingreso;
            }
            set
            {
                fecha_ingreso = value;
            }
        }

        public Double Precio_unitario
        {
            get
            {
                return precio_unitario;
            }
            set
            {
                precio_unitario = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
    }
}