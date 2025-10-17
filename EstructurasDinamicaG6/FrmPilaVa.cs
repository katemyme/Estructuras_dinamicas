using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicaG6
{
    public partial class FrmPilaVA : Form
    {
        Stack<int> pila = new Stack<int>();
        public FrmPilaVA()
        {
            InitializeComponent();
        }

        private void FrmPilaVA_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            tbEdad.Clear();
            tbEdad.Focus();
            Mostrar();
        }

        private void Mostrar ()
        {
            string msn = "";
            foreach (int edad in pila)
            {
                msn += " " + edad + " | ";
            }
            lblEdades.Text= msn;
        }

        private void lblEdades_Click(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else    
                MessageBox.Show("La pila está vacía");
            return; 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"{pila.Peek()}");
            }
            else
            {    
                MessageBox.Show("La pila está vacía");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Stack<int> pilaOrdenada = new Stack<int>();
            while (pila.Count > 0)
            {
                int temp = pila.Pop();
                while (pilaOrdenada.Count > 0 && pilaOrdenada.Peek() > temp)
                {
                    pila.Push(pilaOrdenada.Pop());
                }
                pilaOrdenada.Push(temp);
            }
            pila = pilaOrdenada;
            string mgn = "";
            foreach (int edad in pilaOrdenada)
            {
                mgn += " " + edad + " | ";
            }
            lblOrdenada.Text = mgn;
        }
    }

}
