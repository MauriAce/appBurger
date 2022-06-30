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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show(" PAGO REALIZADO ");
            MessageBox.Show(" TICKET GUARDADO ");

            var ticket = new ticket();
            //ticket.Fecha = DateTimePicker;
            ticket.NomUsuario = textBox4.Text;
            ticket.NroTicket = textBox1.Text;
            ticket.NomCliente = textBox1.Text;
            ticket.Comida = comboBox1.Text;
            ticket.Bebida = comboBox2.Text;
            ticket.Guarnicion = comboBox3.Text;
            ticket.Observaciones = textBox2.Text;
            ticket.MontoTotal = textBox3.Text;
            ticket.FormaPago = comboBox4.Text;
            //
            ticket.CantCom = (int)numericUpDown1.Value;
            ticket.CantBeb = (int)numericUpDown2.Value;
            ticket.CantGua = (int)numericUpDown3.Value;

            var impresora = new Impresora();
            impresora.imprimir(ticket);

            var port = new Form3();

            //     form3          form2
            port.textBox2.Text = textBox4.Text;
            port.textBox4.Text = textBox1.Text;
            //comida
            port.textBox5.Text = comboBox1.Text + " cant: "+ numericUpDown1.Value;
            //Bebida
            port.textBox6.Text = comboBox2.Text + " cant: " + numericUpDown2.Value; ;
            //Guarnicion
            port.textBox7.Text = comboBox3.Text + " cant: " + numericUpDown3.Value; ;
            port.textBox8.Text = textBox2.Text;
            port.textBox9.Text = textBox3.Text;
            port.textBox10.Text = comboBox4.Text;
            //
            port.textBox3.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            //  " + DateTime.Now.Year.ToString()  + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());

            port.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e )
        {
            object suma = comboBox5.Text + numericUpDown1.Value;
             textBox5.Text = (string)suma;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        // bebida
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            

            int b = (Convert.ToInt32(comboBox6.Text));
            int c = (int)(numericUpDown2.Value * b);
            textBox8.Text = c.ToString();

                     

        }
        // guarnicion
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
                int be = (Convert.ToInt32(comboBox7.Text));
                int df = (int)(numericUpDown3.Value * be);
                textBox9.Text = df.ToString();
        }
        // comida
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
                int a = (Convert.ToInt32(comboBox5.Text));
                int d = (int)(numericUpDown1.Value * a);
                textBox5.Text =d.ToString();


            
           
        }

        

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

            int total;

            total = int.Parse(textBox5.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text);

            textBox3.Text = total.ToString();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int total;

            total = int.Parse(textBox5.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text);

            textBox3.Text = total.ToString();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sobreMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Hola, me llamo Mauricio soy estudiante del ITFS11, en la Tecnicatura de Desarrollo de Sofware y realicé este proyecto como trabajo práctico de la materia -Desarrollo de Sistemas Orientado a Objetos- ");
        }

        private void sobreBurgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Enero del año 2022 abrimos nuestro primer local en Argentina en el barrio de Caballito, Ciudad autónoma de Buenos Aires con el objetivo de ofrecer una nueva propuesta en el mercado . " +
                " Nuestras hamburguesas son preparadas en el momento para que los clientes puedan disfrutar de su auténtico sabor y calidad. En Burger´s usamos 100% carne vacuna cocida a la perfección, lechuga crujiente, tomates frescos y un delicioso pan tostado para ofrecerte la mejor hamburguesa ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
/*
 * 
 *  fecha = "";
            nomUsuario = "";
            nroTicket = "";
            nomCliente = "";
            comida = "";
            bebida = "";
            guarnicion = "";
            observaciones = "";
            montoTotal = "";
            formaPago = "";


(Convert.ToInt32(cmbmes.Text)

 * */