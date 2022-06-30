// Alumno : Acevedo, Mauricio Sebastian
//Instituto de Formacion Tecnica Superior Nro 11 ´
//Carrera: Desarrollo de Software
//Materia: Desarrollo de Sistemas Orientado a Objetos
//TP Integrador
//Profesor:Pablo Avellaneda
//1er Cuatrimestre-2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
     class Impresora
    {
        public void imprimir(ticket ticket)
        {
            var archivo = new StreamWriter(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".txt");
            archivo.WriteLine(" _____________________________________________________________");
            archivo.WriteLine("|                        BURGER´S                             |" );
            archivo.WriteLine("|                    Comidas Rápidas                          |");
            archivo.WriteLine("|                                                             | ");
            archivo.WriteLine("|          Documento no VALIDO  como factura                  |");
            archivo.WriteLine("|                                                             | ");
            archivo.WriteLine("|_____________________________________________________________|");
            archivo.WriteLine("    Fecha              :  " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "        " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
            
            archivo.WriteLine("    Nombre del Empleado:  " + ticket.NomUsuario);
            archivo.WriteLine("    Numero de ticket   :  " + DateTime.Now.Year.ToString()  + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());
            archivo.WriteLine("    Nombre del cliente :  " + ticket.NomCliente);
            archivo.WriteLine("    Comida             :  " + ticket.Comida + " cant: " + ticket.CantCom);
            archivo.WriteLine("    Bebida             :  " + ticket.Bebida + " cant: " + ticket.CantBeb);
            archivo.WriteLine("    Guarnicion         :  " + ticket.Guarnicion + " cant: " + ticket.CantGua);
            archivo.WriteLine("    Observaciones      :  " + ticket.Observaciones);
            archivo.WriteLine("    Monto Total        :  " + ticket.MontoTotal);
            archivo.WriteLine("    Forma de pago      :  " + ticket.FormaPago);
            archivo.WriteLine(" ");
            archivo.WriteLine(" _____________________________________________________________");
            archivo.WriteLine("|     Con su Pedido debe entregarse una factura valida        |");
            archivo.WriteLine("|_____________________________________________________________| ");


            archivo.Close();
        }
    }
}
/*
 * 
 * nomUsuario = "";
            nroTicket = "";
            nomCliente = "";
            comida = "";
            bebida = "";
            guarnicion = "";
            observaciones = "";
            montoTotal = "";
            formaPago = "";

 */