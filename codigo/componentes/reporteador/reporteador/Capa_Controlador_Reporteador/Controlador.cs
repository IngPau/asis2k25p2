using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_Reporteador
{
    class Controlador
    {
        //inicio de codigo Sergio Izeppi, Carne: 0901-22-8946 en la fecha 11/09/2025

        //public void EliminarReporte()
        //{
        //   sentencias.EliminarReporte();
        //}

        public DataTable ObtenerReportes()
        {
            return sentencias.ObtenerReporte();
        }

        //fin de codigo de Sergio Izeppi
    }
}

