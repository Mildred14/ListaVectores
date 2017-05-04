using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
      class Inventario
        {
            public Producto[] p = new Producto[15];
            public int indice = 0;

            public void agregar(Producto producto)
            {
                if (indice < 15)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        if (p[i] == null)
                        {
                            p[indice] = producto;
                            indice++;
                            break;
                        }
                    }
                }
            }

            public void insertar(Producto producto, int posicion)
            {
                if (p[posicion] == null)
                {
                    p[posicion] = producto;
                }
                else if (indice < 15)
                {
                    if (p[posicion + 1] != null)
                    {
                        p[posicion] = producto;
                    }
                }
            }

            public Producto buscar(int _search)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (p[i] != null)
                    {
                        if (p[i].Codigo == _search)
                        {
                            return p[i];
                        }
                    }
                }

                return null;
            }

            public int eliminar(int _search)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (p[i] != null)
                    {
                        if (p[i].Codigo == _search)
                        {
                            p[i] = null;
                            indice--;
                            return 1;
                        }
                    }
                }

                return 0;
            }

            public string reporte()
            {
                string cadena = "";

                for (int i= 0; i < 15; i++)
                {
                    if (p[i] != null)
                    {
                        cadena += p[i].ToString() + Environment.NewLine;
                    }
                }

                return cadena;
            }
        }
}
