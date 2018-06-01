using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones
{
    public partial class Form1 : Form
    {

        Expresion nueva = new Expresion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text;

            nueva.LeerExpresion(expresion);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            nueva.Recorrido = "";
            nueva.RecorridoPreOrden(nueva.Inicio);
            txtTRecorrido.Text = nueva.mostrar();
        }

        private void btnPosOrden_Click(object sender, EventArgs e)
        {
            nueva.Recorrido = "";
            nueva.RecorridoPosOrden(nueva.Inicio);
            txtTRecorrido.Text = nueva.mostrar();
        }
    }
}
