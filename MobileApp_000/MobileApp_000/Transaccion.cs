using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace MobileApp_000.Models
{
    public class Transaccion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private DateTime dateTime;
        private decimal importe;
        private String categoria;          
        private String descripcion;
        public DateTime MyDateTime { get; set; }
        public decimal MyImporte { get; set; }
        public String MyCategory { get; set; }
        public String MyDescription { get; set; }


        public Transaccion()
        {

        }
        public Transaccion(DateTime dateTime, decimal importe, String categoria)
        {
            this.dateTime = dateTime;
            this.importe = importe;
            this.categoria = categoria;
            this.descripcion = "";
        }

        public Transaccion(DateTime dateTime, decimal importe, String categoria,String descripcion)
        {
            this.dateTime = dateTime;
            this.importe = importe;
            this.categoria = categoria;
            this.descripcion = descripcion;
        }

        public DateTime GetDateTime()
        {
            return this.dateTime;
        }
        public decimal GetImporte()
        {
            return this.importe;
        }
        public String GetCategoria()
        {
            return this.categoria;
        }
        public String GetDescripcion()
        {
            return this.descripcion;
        }

        public void SetDateTime(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
        public void SetImporte(decimal importe)
        {
            this.importe = importe;
        }
        public void SetCategoria(String categoria)
        {
            this.categoria = categoria;
        }
        public void SetDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
