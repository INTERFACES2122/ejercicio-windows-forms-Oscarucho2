using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Formuarios
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (Nombre_TextBox.Text == "" || ApellidoPaterno_TextBox.Text == "" || ApellidoMaterno_TextBox.Text == "")
            {
                MessageBox.Show("Ningún campo puede quedar vacío");
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(DataGridAlumno);
                fila.Cells[0].Value = Nombre_TextBox.Text;
                fila.Cells[1].Value = ApellidoPaterno_TextBox.Text;
                fila.Cells[2].Value = ApellidoMaterno_TextBox.Text;

                DataGridAlumno.Rows.Add(fila);
                Nombre_TextBox.Text = "";
                ApellidoPaterno_TextBox.Text = "";
                ApellidoMaterno_TextBox.Text = "";

              
            }

            
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            DataGridAlumno.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int i;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          
        }

        
    }
}
