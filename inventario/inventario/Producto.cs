using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        public Producto( int codigo, string nombre, int cantidad, int costo)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._costo = costo;

        }
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

      
        public override string ToString()
        {
            return "Código: " + Codigo + "  " + " Nombre: " + Nombre + "  " + " Cantidad: " + Cantidad + "  " + " Costo: $ " + Costo + ".";
        }
    }
}
    
