using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EguiaRodriguezJosueFrancisco
{
    class CentroCultural : IEquatable<CentroCultural>
    {
        private int _intCodigoPostal;
        public int CodigoPostal
        {
            get { return _intCodigoPostal; }
            set 
            {
                if (value >= 0)
                {
                    _intCodigoPostal = value;
                }
                else
                {
                    throw new Exception("El código postal no debe ser menor o igual a cero");
                }
            }
        }


        private double _dblPresupuesto;
        public double Presupuesto
        {
            get { return _dblPresupuesto; }
            set 
            {
                if (value > 0)
                {
                    _dblPresupuesto = value;
                }
                else
                {
                    throw new Exception("El valor de una empresa no debe ser menor o igual a cero");
                }
            }
        }


        private char _chrPosicionamiento;
        public char Posicionamiento
        {
            get { return _chrPosicionamiento; }
            set 
            { 
                if (value == 'N' || value == 'S' || value == 'E' || value == 'O')
                {
                    _chrPosicionamiento = value;
                }
                else
                {
                    throw new Exception($"La posicion {value} no es válida");
                }
            }
        }


        private DateTime _dtmFechaConstruccion;
        public DateTime FechaConstruccion
        {
            get { return _dtmFechaConstruccion; }
            set 
            {
                if (value.Year >= 1900)
                {
                    _dtmFechaConstruccion = value;
                }
                else
                {
                    throw new Exception("La fecha introducida no es válida");
                }
            }
        }


        private bool _blnMantenimiento;
        public bool Mantenimiento
        {
            get { return _blnMantenimiento; }
            set 
            {
                if (value == true || value == false)
                {
                    _blnMantenimiento = value;
                }
                else
                {
                    throw new Exception("Tipo de dato no válido");
                }
            }
        }



        private string _strSector;
        public string Sector
        {
            get { return _strSector; }
            set 
            {
                if (value == "Público" || value == "Privado")
                {
                    _strSector = value;
                }
                else
                {
                    throw new Exception($"{value} es un sector no válido");
                }
            }
        }


        private string _strRutaImagen;
        public string RutaImagen
        {
            get { return _strRutaImagen; }
            set 
            {
                if (_strRutaImagen == "")
                {
                    throw new Exception("La ruta de la imagen no puede estar vacía");
                }
                else
                {
                    _strRutaImagen = value;
                }
            }
        }

        public bool Equals(CentroCultural otroCentroCultural)
        {
            if (CodigoPostal == otroCentroCultural.CodigoPostal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
