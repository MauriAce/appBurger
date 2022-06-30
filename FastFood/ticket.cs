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
   class ticket
    {
        string fecha;
        string nomUsuario;
        string nroTicket;
        string nomCliente;
        string comida;
        string bebida;
        string guarnicion;
        string observaciones;
        string montoTotal;
        string formaPago;
        int cantCom;
        int cantBeb;
        int cantGua;

        public int CantCom
        {
            get { return cantCom; }
            set {   cantCom = value; }
        }
        public int CantBeb
        {
            get { return cantBeb; }
            set { cantBeb = value; }
        }
        public int CantGua
        {
            get { return cantGua; }
            set { cantGua = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string NomUsuario
        {
            get { return nomUsuario; }
            set { nomUsuario = value; }
        }
        public string NroTicket
        {
            get { return nroTicket; }
            set {   nroTicket = value; }
        }
        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }

        public string Comida
        {
            get { return comida; }
            set { comida = value; }
        }
        public string Bebida
        {
            get { return bebida; }
            set { bebida = value; }
        }
        public string Guarnicion
        {
            get { return guarnicion; }
            set { guarnicion = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public string MontoTotal
        {
            get { return montoTotal; }
            set { montoTotal= value; }
        }
        public string FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }

        public ticket()

        {
            fecha = "";
            nomUsuario = "";
            nroTicket = "";
            nomCliente = "";
            comida = "";
            bebida = "";
            guarnicion = "";
            observaciones = "";
            montoTotal = "";
            formaPago = "";
            //cantCom= "";








        }
    }
}