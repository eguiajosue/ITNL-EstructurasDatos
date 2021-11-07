using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace MetodoBurbuja
{
    public partial class Form1 : Form
    {
        private Alumno[] arregloAlumnos = new Alumno[50];
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgEstudiantes.Columns.Add("nControl", "Numero de Control");
            dtgEstudiantes.Columns.Add("nombre", "Nombre");
            dtgEstudiantes.Columns.Add("apellido", "Apellido");
            dtgEstudiantes.Columns.Add("fechaNacimiento", "Fecha de Nacimiento");
            dtgEstudiantes.Columns.Add("carrera", "Carrera");
            dtgEstudiantes.Columns.Add("calificacion", "Calificación");
            dtgEstudiantes.ReadOnly = true;
            dtgEstudiantes.AllowUserToAddRows = false;
            dtgEstudiantes.AllowUserToDeleteRows = false;
            dtgEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEstudiantes.AllowUserToOrderColumns = false;
            dtgEstudiantes.MultiSelect = false;
            dtgEstudiantes.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtgEstudiantes.AllowUserToOrderColumns = false;
            dtgEstudiantes.AllowUserToResizeColumns = false;
            dtgEstudiantes.AllowUserToResizeRows = false;
        }

        public void Mostrar()
        {
            dtgEstudiantes.Rows.Clear();

            foreach (Alumno alumno in arregloAlumnos)
            {
                dtgEstudiantes.Rows.Add(alumno.NumeroControl, alumno.Nombre, alumno.Apellido, alumno.FechaNacimiento.ToShortDateString(), alumno.Carrera, alumno.Calificacion.ToString("N1"));
            }
        }

        private DateTime FechaAleatoria()
        {
            DateTime dtmInicio = new DateTime(1998, 1, 1);
            int intRango = (DateTime.Today - dtmInicio).Days;
            return dtmInicio.AddDays(random.Next(intRango));
        }

        private void btn50ObjetosAleatorios_Click(object sender, EventArgs e)
        {
            Array.Resize(ref arregloAlumnos, 50);

            int[] intPreNumeroControl = { 17100, 18100, 19100, 20100, 21100 };
            int intNumeroControlMin = 000;
            int intNumeroControlMax = 999;

            string[] strNombres = {
                "Aarón",
                "Abel",
                "Adán",
                "Adrián",
                "Ángel",
                "Bruno",
                "Daniel",
                "David",
                "Edgar",
                "Fabián",
                "Fernando",
                "Francisco",
                "Gabriel",
                "Guillermo",
                "Héctor",
                "Hugo",
                "Isaac",
                "Iván",
                "Jaime",
                "Jesús",
                "Julián",
                "Julio",
                "Leonardo",
                "Lucas",
                "Luis",
                "Manuel",
                "Marco",
                "Miguel",
                "Omar",
                "Pablo",
                "Raúl",
                "Ricardo",
                "Samuel",
                "Santiango",
                "Sergio",
                "Tomás",
                "Vicente",
                "Adriana",
                "Ainara",
                "Alejandra",
                "Alicia",
                "Alma",
                "Andrea",
                "Camila",
                "Claudia",
                "Daniela",
                "Diana",
                "Gabriela",
                "Heidi",
                "Ilian",
                "Iris",
                "Itzel",
                "Karen",
                "Karina",
                "Laura",
                "Liliana",
                "María",
                "Mónica",
                "Paola",
                "Salma",
                "Sandra",
                "Sofía",
                "Susana",
                "Valeria",
                "Verónica"
            };

            string[] strApellidos = {
                "Álvaro",
                "Águilar",
                "Cruz",
                "Briones",
                "Cantú",
                "Canales",
                "Carrillo",
                "Díaz",
                "Domínguez",
                "Estrada",
                "Espinoza",
                "Flores",
                "García",
                "Garza",
                "Gómez",
                "Guerrero",
                "Gutierrez",
                "Gonzalez",
                "Herrera",
                "Jímenez",
                "López",
                "Macías",
                "Márquez",
                "Martínez",
                "Mejía",
                "Morales",
                "Navarro",
                "Ortíz",
                "Peña",
                "Pérez",
                "Ramírez",
                "Rangel",
                "Ríos",
                "Rivera",
                "Rodríguez",
                "Rosales",
                "Rosas",
                "Ruiz",
                "Salas",
                "Salazar",
                "Sánchez",
                "Sosa",
                "Soto",
                "Torres",
                "Treviño",
                "Valencia",
                "Valenzuela",
                "Vargas",
                "Vázquez",
                "Villareal"
            };

            string[] strCarreras = {
                "Administración",
                "Sistemas",
                "Contabilidad",
                "Gestión Empresarial",
                "Arquitectura",
                "Civil",
                "Industrial"
            };

            bool[] blnRegular = { true, false };

            for (int i = 0; i < 50; i++)
            {
                Alumno miAlumno = new Alumno();

                miAlumno.NumeroControl = intPreNumeroControl[random.Next(intPreNumeroControl.Length)].ToString() + random.Next(intNumeroControlMin, intNumeroControlMax);
                miAlumno.Nombre = strNombres[random.Next(strNombres.Length)];
                miAlumno.Apellido = strApellidos[random.Next(strApellidos.Length)];
                miAlumno.FechaNacimiento = FechaAleatoria();
                miAlumno.Carrera = strCarreras[random.Next(strCarreras.Length)];
                miAlumno.Calificacion = random.Next(1, 10);
                miAlumno.Regular = blnRegular[random.Next(blnRegular.Length)];

                arregloAlumnos[i] = miAlumno;
            }
            Mostrar();
        }

        private void btn5ObjetosAleatorios_Click(object sender, EventArgs e)
        {
            Array.Resize(ref arregloAlumnos, 5);

            int[] intPreNumeroControl = { 17100, 18100, 19100, 20100, 21100 };
            int intNumeroControlMin = 000;
            int intNumeroControlMax = 999;

            string[] strNombres = {
                "Aarón",
                "Abel",
                "Adán",
                "Adrián",
                "Ángel",
                "Bruno",
                "Daniel",
                "David",
                "Edgar",
                "Fabián",
                "Fernando",
                "Francisco",
                "Gabriel",
                "Guillermo",
                "Héctor",
                "Hugo",
                "Isaac",
                "Iván",
                "Jaime",
                "Jesús",
                "Julián",
                "Julio",
                "Leonardo",
                "Lucas",
                "Luis",
                "Manuel",
                "Marco",
                "Miguel",
                "Omar",
                "Pablo",
                "Raúl",
                "Ricardo",
                "Samuel",
                "Santiango",
                "Sergio",
                "Tomás",
                "Vicente",
                "Adriana",
                "Ainara",
                "Alejandra",
                "Alicia",
                "Alma",
                "Andrea",
                "Camila",
                "Claudia",
                "Daniela",
                "Diana",
                "Gabriela",
                "Heidi",
                "Ilian",
                "Iris",
                "Itzel",
                "Karen",
                "Karina",
                "Laura",
                "Liliana",
                "María",
                "Mónica",
                "Paola",
                "Salma",
                "Sandra",
                "Sofía",
                "Susana",
                "Valeria",
                "Verónica"
            };

            string[] strApellidos = {
                "Álvaro",
                "Águilar",
                "Cruz",
                "Briones",
                "Cantú",
                "Canales",
                "Carrillo",
                "Díaz",
                "Domínguez",
                "Estrada",
                "Espinoza",
                "Flores",
                "García",
                "Garza",
                "Gómez",
                "Guerrero",
                "Gutierrez",
                "Gonzalez",
                "Herrera",
                "Jímenez",
                "López",
                "Macías",
                "Márquez",
                "Martínez",
                "Mejía",
                "Morales",
                "Navarro",
                "Ortíz",
                "Peña",
                "Pérez",
                "Ramírez",
                "Rangel",
                "Ríos",
                "Rivera",
                "Rodríguez",
                "Rosales",
                "Rosas",
                "Ruiz",
                "Salas",
                "Salazar",
                "Sánchez",
                "Sosa",
                "Soto",
                "Torres",
                "Treviño",
                "Valencia",
                "Valenzuela",
                "Vargas",
                "Vázquez",
                "Villareal"
            };

            string[] strCarreras = {
                "Administración",
                "Sistemas",
                "Contabilidad",
                "Gestión Empresarial",
                "Arquitectura",
                "Civil",
                "Industrial"
            };

            bool[] blnRegular = { true, false };

            for (int i = 0; i < 5; i++)
            {
                Alumno miAlumno = new Alumno();

                miAlumno.NumeroControl = intPreNumeroControl[random.Next(intPreNumeroControl.Length)].ToString() + random.Next(intNumeroControlMin, intNumeroControlMax);
                miAlumno.Nombre = strNombres[random.Next(strNombres.Length)];
                miAlumno.Apellido = strApellidos[random.Next(strApellidos.Length)];
                miAlumno.FechaNacimiento = FechaAleatoria();
                miAlumno.Carrera = strCarreras[random.Next(strCarreras.Length)];
                miAlumno.Calificacion = random.NextDouble() * 100;
                miAlumno.Regular = blnRegular[random.Next(blnRegular.Length)];

                arregloAlumnos[i] = miAlumno;
            }
            Mostrar();
        }
        
        private void Izquierda(ref int intCantidadInteraciones, ref int intContador)
        {
            if (chkSennal.Checked)
            {
                Alumno Auxiliar;

                bool Sennal = true;

                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    Sennal = false;

                    for (int j = 0; j < arregloAlumnos.Length - i - 1; j++)
                    {
                        intCantidadInteraciones++;
                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j + 1]) == 1)
                        {
                            Sennal = true;
                            Auxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j + 1];
                            arregloAlumnos[j + 1] = Auxiliar;
                            intContador++;

                            if (radPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Estado de la señal: {Sennal}\nSe ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}", "Intercambio de Elementos con Señal");
                            }
                        }
                        
                    }
                }
                Mostrar();
            } 
            else if (chkSennal.Checked == false)
            {
                Alumno Auxiliar;

                for (int i = 0; i < arregloAlumnos.Length; i++)
                {
                    for (int j = 0; j < arregloAlumnos.Length - i - 1; j++)
                    {
                        intCantidadInteraciones++;
                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j + 1]) == 1)
                        {
                            Auxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j + 1];
                            arregloAlumnos[j + 1] = Auxiliar;
                            intContador++;

                            if (radPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}", "Intercambio de Elementos");
                            }
                        }
                    }
                }
                Mostrar();
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int intContador = 0;
            int intCantidadIteraciones = 0;

            Izquierda(ref intCantidadIteraciones, ref intContador);

            stopwatch.Stop();

            MessageBox.Show($"Movimientos realizados: {intContador}\nNumero de iteraciones: {intCantidadIteraciones}\nTiempo: {stopwatch.ElapsedMilliseconds} ms");
        }

        private void Derecha(ref int intCantidadIteraciones, ref int intContador)
        {
            if (chkSennal.Checked)
            {
                Alumno alumnoAuxiliar;

                bool Sennal = true;

                for (int i = arregloAlumnos.Length - 1; i > 0; i--)
                {
                    Sennal = false;

                    for (int j = arregloAlumnos.Length - 1; j > 0; j--)
                    {
                        intCantidadIteraciones++;
                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j - 1]) == -1)
                        {
                            Sennal = true;
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j - 1];
                            arregloAlumnos[j - 1] = alumnoAuxiliar;
                            intContador++;

                            if (radPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}", "Intercambio de Elementos con Señal");
                            }
                        }
                    }
                }
                Mostrar();
            }
            else if (chkSennal.Checked == false)
            {
                Alumno alumnoAuxiliar;
                for (int i = arregloAlumnos.Length - 1; i > 0; i--)
                {
                    for (int j = arregloAlumnos.Length - 1; j > 0; j--)
                    {
                        intCantidadIteraciones++;
                        if (arregloAlumnos[j].CompareTo(arregloAlumnos[j - 1]) == -1)
                        {
                            alumnoAuxiliar = arregloAlumnos[j];
                            arregloAlumnos[j] = arregloAlumnos[j - 1];
                            arregloAlumnos[j - 1] = alumnoAuxiliar;
                            intContador++;

                            if (radPasoAPaso.Checked)
                            {
                                Mostrar();
                                MessageBox.Show($"Se ha intercambiado el elemento: {arregloAlumnos[j + 1].Calificacion} con {arregloAlumnos[j].Calificacion}", "Intercambio de Elementos");
                            }
                        }
                    }
                }
                Mostrar();
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int intContador = 0;
            int intCantidadIteraciones = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            Derecha(ref intCantidadIteraciones, ref intContador);

            stopwatch.Stop();

            MessageBox.Show($"Movimientos realizados: {intContador}\nNumero de iteraciones: {intCantidadIteraciones}\nTiempo: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
