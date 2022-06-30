// Alumno : Acevedo, Mauricio Sebastian
//Instituto de Formacion Tecnica Superior Nro 11 ´
//Carrera: Desarrollo de Software
//Materia: Desarrollo de Sistemas Orientado a Objetos
//TP Integrador
//Profesor:Pablo Avellaneda
//1er Cuatrimestre-2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var port = new Form2();
            port.Show();
          //  this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
