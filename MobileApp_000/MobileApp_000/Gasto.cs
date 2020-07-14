using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp_000
{
    public class Gasto
    {
        public decimal MyImpTot { get; set; }
        public string MyCate { get; set; }

        public Gasto()
        {

        }

        public Gasto(decimal gasto, string categoria)
        {
            MyImpTot = gasto;
            MyCate = categoria;
        }



    }
}
