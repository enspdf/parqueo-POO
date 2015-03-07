using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parqueadero;

namespace Parqueadero
{
    class ClPrq
    {
        private string _tipovehiculo;
        public string TipoVehiculo
        {
            set { _tipovehiculo = value; }
            get { return _tipovehiculo; }
        }

        public int TarifaVehiculo
        {
            get
            {
                if (_tipovehiculo == "Carro")
                {
                    return 3500;
                }
                else
                {
                    return 2500;
                }
            }
        }

        private int _numerohoras;
        public int NumeroHoras
        {
            set { _numerohoras = value; }
            get { return _numerohoras; }
        }

        private string _nombrecliente;
        public string NombreCliente
        {
            set { _nombrecliente = value; }
            get { return _nombrecliente; }
        }

        private string _numeroidentificacion;
        public string NumeroIdentificacion
        {
            set { _numeroidentificacion = value; }
            get { return _numeroidentificacion; }
        }

        private string _placa;
        public string Placa
        {
            set { _placa = value; }
            get { return _placa; }
        }
    }
}
