using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort_formas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearDataGridView();
        }

        private void CrearDataGridView()
        {
         
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

         
            dataGridView1.Columns.Add("Numero", "Numero");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Sueldo", "Sueldo");

            txtNumero.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
           
        }

        private void MostrarDataGridView(Empleado[] Arreglo)
        {
          
            CrearDataGridView();

           
            foreach (Empleado e in Arreglo)
                dataGridView1.Rows.Add(e.Numero, e.Nombre, e.Sueldo);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Empleado unEmpleado = new Empleado();

             try
             {
                  
                unEmpleado.Numero = int.Parse(txtNumero.Text);
                unEmpleado.Nombre = txtNombre.Text;
                unEmpleado.Sueldo = double.Parse(txtSueldo.Text);
             }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

            dataGridView1.Rows.Add(unEmpleado.Numero, unEmpleado.Nombre, unEmpleado.Sueldo);
            MessageBox.Show("Datos agregados correctamente");
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            string[] Nombres = {"Sara", "Luz", "Ithzel", "Danna", "Alejandra", "Jean", "Carlo", "Antonio", "Jafet", "Cesar", "Abigail" };

            for(int i=0; i<=10; i++)
            {
                Empleado unEmpleado = new Empleado();

                try
                {

                    unEmpleado.Numero = aleatorio.Next(1,100);
                    unEmpleado.Nombre = Nombres[aleatorio.Next(Nombres.Length)];
                    unEmpleado.Sueldo = aleatorio.NextDouble()*2000;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                dataGridView1.Rows.Add(unEmpleado.Numero, unEmpleado.Nombre, unEmpleado.Sueldo);

                
            }


        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int Comparaciones = 0, Movimientos = 0, MiliSegundos = 0;
            int CantEmpleados = dataGridView1.Rows.Count - 1;

            Empleado[] ArregloEmpleados = new Empleado[CantEmpleados];

            Empleado unEmpleado;

            for(int i=0; i<CantEmpleados; i++)
            {
                unEmpleado = new Empleado();

                unEmpleado.Numero = int.Parse(dataGridView1[0, i].Value.ToString());
                unEmpleado.Nombre = dataGridView1[1, i].Value.ToString();
               unEmpleado.Sueldo = double.Parse(dataGridView1[2, i].Value.ToString());

                ArregloEmpleados[i] = new Empleado();

                ArregloEmpleados[i] = unEmpleado;
            }

            if(radAscendente.Checked && radOrdenarNumero.Checked)
            {
                ClaseOrdenadora<Empleado>.QuickSort(ArregloEmpleados, ClaseOrdenadora<Empleado>.Ascendente, out Comparaciones, out Movimientos, out MiliSegundos);
                MostrarDataGridView(ArregloEmpleados);
                MessageBox.Show("Datos ordenados de forma ascendente por número "+ "\n\nComparaciones = " + Comparaciones.ToString() + "\n\nIntercambios realizados = " 
                    + Movimientos.ToString() + "\n\nTiempo = " + MiliSegundos.ToString() + " ms.", "DATOS ORDENADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(radDescendente.Checked && radOrdenarNumero.Checked)
            {
                ClaseOrdenadora<Empleado>.QuickSort(ArregloEmpleados, ClaseOrdenadora<Empleado>.Descendente, out Comparaciones, out Movimientos, out MiliSegundos);
                MostrarDataGridView(ArregloEmpleados);
                MessageBox.Show("Datos ordenados de forma descendente por número"+ "\n\nComparaciones = " + Comparaciones.ToString() + "\n\nIntercambios realizados = "
                    + Movimientos.ToString() + "\n\nTiempo = " + MiliSegundos.ToString() + " ms.", "DATOS ORDENADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
