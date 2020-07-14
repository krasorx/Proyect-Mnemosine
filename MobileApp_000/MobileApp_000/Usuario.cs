using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp_000
{
    public class Usuario
    {
        public  String Nombre { get; set; }
        public  String Email { get; set; }
        public  double SaldoInicial { get; set; }
        public  double SaldoActual { get; set; }
        public  double SaldoFinal { get; set; }
        private int dimL;

        //private Transaccion transaccion;    //hacer una lista
        //private List<Transaccion> transacciones;

        public Usuario()
        {
            this.dimL = 0;
        }

        public Usuario(string nombre, string email, double saldoInicial, double saldoActual, double saldoFinal)
        {
            Nombre = nombre;
            Email = email;
            SaldoInicial = saldoInicial;
            SaldoActual = saldoActual;
            SaldoFinal = saldoFinal;
            //this.transacciones = transacciones;
            this.dimL = 0;
        }

        public Usuario(string nombre, string email, double saldoInicial)
        {
            Nombre = nombre;
            Email = email;
            SaldoInicial = saldoInicial;
            this.dimL = 0;
        }

        /*
        public void AddTransaccion(DateTime dateTime, decimal importe, String categoria)
        {
            // Crea y agrega una nueva transaccion al final
            var a = new Transaccion(dateTime, importe, categoria);
            transacciones.Add(a);
            dimL++;
        }
        */

        public void CalcularSaldoFinal()
        {
            SaldoActual = SaldoInicial;
            //Recorrer los elementos de la lista, y restarlos o sumarlos (sumar gasto, restar ganancias)
            // al saldoActual
            SaldoFinal = SaldoActual;



        }
        // Se debe crear una lista de Gastos

        public void CarpetaUsuario()
        {

        }

    }
}
