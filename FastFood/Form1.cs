// Alumno : Acevedo, Mauricio Sebastian
//Instituto de Formacion Tecnica Superior Nro 11 ´
//Carrera: Desarrollo de Software
//Materia: Desarrollo de Sistemas Orientado a Objetos
//TP Integrador
//Profesor:Pablo Avellaneda
//1er Cuatrimestre-2022

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if ((textBox1.Text == "juan" && textBox2.Text == "1234" || textBox1.Text == "maria" && textBox2.Text == "1234") && checkBox1.Checked )
            {
                MessageBox.Show(" Bienevenido " + textBox1.Text + " acceso ACEPTADO ");

               
                var port = new Form2();


                //     form2          form1
                port.textBox4.Text = textBox1.Text;
                port.Show();

            }
            else
            {
                MessageBox.Show(" ERROR, usuario o contraseña incorrecta  o seleccionar sos usuario de BURGER`S ?");
            }



            /////
           // var port = new Form2();


            //     form2          form1
           // port.textBox4.Text = textBox1.Text;
           // port.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}