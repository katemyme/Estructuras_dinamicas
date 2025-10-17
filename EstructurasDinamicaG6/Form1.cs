using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstructurasDinamicaG6
{
    public partial class FrmPilaAG : Form
    {
        Stack<int> pila = new Stack<int>();
        public FrmPilaAG()
        {
            InitializeComponent();
        }

        private void Agregar()
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            Mostrar();
        }
        private void Mostrar()
        {
            string msn = "";
            foreach (int edad in pila)
            {
                msn += " " + edad + " |";
            }
            lblEdades.Text = msn;
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Agregar();
                tbEdad.Clear();
                tbEdad.Focus();
                Mostrar();
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
            {
                MessageBox.Show("Pila Vacía.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"{pila.Peek()}");
            }
            else
            {
                MessageBox.Show("Pila Vacía.");
            }
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        { 
            Stack<int> pilaAux = new Stack<int>();
            while (pila.Count > 0)
            {
                int temp = pila.Pop();
                while (pilaAux.Count > 0 && pilaAux.Peek() > temp)
                {
                    pila.Push(pilaAux.Pop());
                }
                pilaAux.Push(temp);
            }
            pila = pilaAux;
            
            string msn = "";
            foreach (int edad in pila)
            {
                msn += " " + edad + " |";
            }
            lblEdades2.Text = msn;
        }
    }
}
