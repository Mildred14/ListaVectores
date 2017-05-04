using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Inventario i = new Inventario();
        int codigo;
        string nombre;
        int cantidad;
        int precio;
        Producto p1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
            codigo = Convert.ToInt32(textBox1.Text);
            nombre = textBox2.Text;
            cantidad = Convert.ToInt32(textBox3.Text);
            precio = Convert.ToInt32(textBox4.Text);
            p1=new Producto(codigo, nombre, cantidad, precio);
            i.agregar(p1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eliminar;
            codigo = Convert.ToInt32(textBox1.Text);
            eliminar = i.eliminar(codigo);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text += i.reporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(textBox1.Text);       
            textBox1.Text = i.buscar(codigo).ToString();
            textBox5.Text += codigo.ToString();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int posicion = Convert.ToInt32(textBox6.Text);
            p1 = new Producto(codigo, nombre, cantidad, precio);
            i.agregar(p1);
            i.insertar(p1,posicion-1);
            textBox6.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
