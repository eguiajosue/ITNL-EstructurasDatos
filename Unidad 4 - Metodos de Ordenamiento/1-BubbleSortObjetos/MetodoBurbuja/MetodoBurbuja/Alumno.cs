using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja
{
    internal class Alumno : IComparable<Alumno>
    {
        private string _strNumeroControl;

        public string NumeroControl
        {
            get { return _strNumeroControl; }
            set { _strNumeroControl = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strApellido;

        public string Apellido
        {
            get { return _strApellido; }
            set { _strApellido = value; }
        }

        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        private string _strCarrera;

        public string Carrera
        {
            get { return _strCarrera; }
            set { _strCarrera = value; }
        }

        private double _dblCalificacion;

        public double Calificacion
        {
            get { return _dblCalificacion; }
            set { _dblCalificacion = value; }
        }

        private bool _blnRegular;

        public bool Regular
        {
            get { return _blnRegular; }
            set { _blnRegular = value; }
        }

        public int CompareTo(Alumno otroAlumno)
        {
            return Calificacion.CompareTo(otroAlumno.Calificacion);
        }
    }
}
