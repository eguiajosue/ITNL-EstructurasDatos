using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArbolBinarioDeBusqueda
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda<CentroCultural> arbolCentrosCulturales = new ArbolBinarioBusqueda<CentroCultural>();

        public string strRutaDot, ubicacionFigura = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPosicionamiento.DropDownStyle = ComboBoxStyle.DropDownList;

            dtgCentrosCulturales.ReadOnly = true;
            dtgCentrosCulturales.AllowUserToAddRows = false;
            dtgCentrosCulturales.AllowUserToDeleteRows = false;
            dtgCentrosCulturales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCentrosCulturales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCentrosCulturales.AllowUserToOrderColumns = false;
            dtgCentrosCulturales.MultiSelect = false;
            dtgCentrosCulturales.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtgCentrosCulturales.AllowUserToOrderColumns = false;
            dtgCentrosCulturales.AllowUserToResizeColumns = false;
            dtgCentrosCulturales.AllowUserToResizeRows = false;

            dtgCentrosCulturales.Columns.Add("codigoPostal", "Código Postal");
            dtgCentrosCulturales.Columns.Add("presupuesto", "Presupuesto");
            dtgCentrosCulturales.Columns.Add("posicionamiento", "Posicionamiento");
            dtgCentrosCulturales.Columns.Add("fechaConstruccion", "Fecha de Construcción");
            dtgCentrosCulturales.Columns.Add("mantenimiento", "¿Se encuentra en mantenimiento?");
            dtgCentrosCulturales.Columns.Add("tipoSector", "Tipo de Sector");

            radPublico.Checked = true;
            radPreOrden.Checked = true;
        }

        public void CargarDatos()
        {
            if (radPreOrden.Checked)
            {
                dtgCentrosCulturales.Rows.Clear();

                foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPreOrden())
                {
                    dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
                }
            }

            if (radInOrden.Checked)
            {
                dtgCentrosCulturales.Rows.Clear();

                foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerInOrden())
                {
                    dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
                }
            }

            if (radPostOrden.Checked)
            {
                dtgCentrosCulturales.Rows.Clear();

                foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPostOrden())
                {
                    dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
                }
            }
        }

        public void LimpiarDatos()
        {
            foreach (Control c in grpDatosCentroCultural.Controls)
            {
                if (c is TextBox txt) txt.Clear();
            }

            chkMantenimiento.Checked = false;
            radPublico.Checked = true;
            radPrivado.Checked = false;
            cboPosicionamiento.Text = null;
            picImagen.Image = null;
            picImagen.ImageLocation = null;
            dtmFechaConstruccion.Value = DateTime.Today;
            dtgCentrosCulturales.ClearSelection();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Archivos JPEG (*.jpeg) | *.jpg",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picImagen.ImageLocation = openFileDialog.FileName;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de querer agregar un nuevo elemento a la lista?", "Agregar Elemento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CentroCultural centroCultural = new CentroCultural();

                    centroCultural.CodigoPostal = int.Parse(txtCodigoPostal.Text);
                    centroCultural.Presupuesto = double.Parse(txtPresupuesto.Text);
                    centroCultural.FechaConstruccion = dtmFechaConstruccion.Value;
                    centroCultural.Posicionamiento = char.Parse(cboPosicionamiento.Text);
                    centroCultural.Mantenimiento = chkMantenimiento.Checked;
                    if (radPublico.Checked) centroCultural.Sector = "Público";
                    if (radPrivado.Checked) centroCultural.Sector = "Privado";
                    centroCultural.RutaImagen = picImagen.ImageLocation;

                    arbolCentrosCulturales.AgregarNodo(centroCultural);

                    CargarDatos();
                    LimpiarDatos();
                    DibujarFigura();
                }

                await Task.Delay(1000);
                picArbolBinarioGrafo.ImageLocation = $"{ubicacionFigura}\\Figura.jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGenerarAleatorio_Click(object sender, EventArgs e)
        {
            int intCodigoPostalMinimo = 00000;
            int intCodigoPostalMaximo = 99999;

            string[] arrayImagenes = {
                @"..\..\Resources\img_1.png",
                @"..\..\Resources\img_2.png",
                @"..\..\Resources\img_3.png",
                @"..\..\Resources\img_4.png",
                @"..\..\Resources\img_5.png",
                @"..\..\Resources\img_6.png",
                @"..\..\Resources\img_7.png",
                @"..\..\Resources\img_8.png",
                @"..\..\Resources\img_9.png",
                @"..\..\Resources\img_10.png",
                @"..\..\Resources\img_11.png",
                @"..\..\Resources\img_12.png",
                @"..\..\Resources\img_13.png",
                @"..\..\Resources\img_14.png",
                @"..\..\Resources\img_15.png"
            };

            char[] arrayPosiciones = { 'N', 'S', 'E', 'O' };
            bool[] arrayMantenimiento = { true, false };
            string[] arrayTipoSector = { "Público", "Privado" };

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    CentroCultural centroCulturalAleatorio = new CentroCultural();

                    centroCulturalAleatorio.CodigoPostal = random.Next(intCodigoPostalMinimo, intCodigoPostalMaximo);
                    centroCulturalAleatorio.Presupuesto = random.Next();
                    centroCulturalAleatorio.Posicionamiento = arrayPosiciones[random.Next(arrayPosiciones.Length)];
                    centroCulturalAleatorio.FechaConstruccion = new DateTime(random.Next(1950, 2021), random.Next(1, 13), random.Next(1, 31));
                    centroCulturalAleatorio.Mantenimiento = arrayMantenimiento[random.Next(arrayMantenimiento.Length)];
                    centroCulturalAleatorio.Sector = arrayTipoSector[random.Next(arrayTipoSector.Length)];
                    centroCulturalAleatorio.RutaImagen = arrayImagenes[random.Next(arrayImagenes.Length)];

                    arbolCentrosCulturales.AgregarNodo(centroCulturalAleatorio);
                    CargarDatos();
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DibujarFigura();
            await Task.Delay(1000);
            picArbolBinarioGrafo.ImageLocation = $"{ubicacionFigura}\\Figura.jpg";
        }

        private async void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgCentrosCulturales.SelectedRows.Count == 1)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el elemento seleccionado", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        CentroCultural centroCultural = new CentroCultural();
                        centroCultural.CodigoPostal = int.Parse(dtgCentrosCulturales.SelectedRows[0].Cells[0].Value.ToString());

                        MessageBox.Show($"Se ha eliminado siguiente Centro Cultural:\n{centroCultural.MostrarDatos()}", "Eliminacion de Nodo");

                        arbolCentrosCulturales.EliminarNodo(centroCultural);
                        CargarDatos();
                        LimpiarDatos();

                        DibujarFigura();
                        await Task.Delay(1000);
                        picArbolBinarioGrafo.ImageLocation = $"{ubicacionFigura}\\Figura.jpg";
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (dtgCentrosCulturales.Rows.Count != 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea vaciar la lista completamente?", "Vaciar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        arbolCentrosCulturales.Vaciar();
                        CargarDatos();
                        LimpiarDatos();
                        picArbolBinarioGrafo.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra actualmente vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                try
                {
                    CentroCultural BuscarCentroCultural = new CentroCultural();
                    BuscarCentroCultural.CodigoPostal = int.Parse(txtBuscar.Text);

                    CentroCultural centroBuscado = arbolCentrosCulturales.BuscarNodo(BuscarCentroCultural);

                    txtCodigoPostal.Text = centroBuscado.CodigoPostal.ToString();
                    txtPresupuesto.Text = centroBuscado.Presupuesto.ToString();
                    cboPosicionamiento.Text = centroBuscado.Posicionamiento.ToString();
                    dtmFechaConstruccion.Value = centroBuscado.FechaConstruccion;
                    if (centroBuscado.Sector == "Público") radPublico.Checked = true;
                    if (centroBuscado.Sector == "Privado") radPrivado.Checked = true;
                    picImagen.ImageLocation = centroBuscado.RutaImagen;

                    MessageBox.Show("¡Centro Cultural encontrado!", "Busqueda");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Para buscar un centro cultural no debe estar el cuadro de texto en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            try
            {
                string Resultado = "";

                if (radPreOrden.Checked)
                {
                    foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPreOrden())
                    {
                        Resultado += $"{centroCultural.ToString()} - ";
                    }
                    MessageBox.Show($"Salida: {Resultado}", "Recorrido PreOrden");
                }

                if (radInOrden.Checked)
                {
                    foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerInOrden())
                    {
                        Resultado += $"{centroCultural.ToString()} - ";
                    }
                    MessageBox.Show($"Salida: {Resultado}", "Recorrido InOrden");
                }

                if (radPostOrden.Checked)
                {
                    foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPostOrden())
                    {
                        Resultado += $"{centroCultural.ToString()} - ";
                    }
                    MessageBox.Show($"Salida: {Resultado}", "Recorrido PostOrden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!arbolCentrosCulturales.Vacia)
            {
                DibujarFigura();
                
                await Task.Delay(1000);
                picArbolBinarioGrafo.ImageLocation = $"{ubicacionFigura}\\Figura.jpg";
            }
            else
            {
                MessageBox.Show("El árbol binario de busqueda se encuentra vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigurarRutas_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "Seleccione la ruta donde desee crear el archivo Figura";
            openFileDialog.ShowNewFolderButton = true;

            if (ubicacionFigura != "" || ubicacionFigura != null)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ubicacionFigura = openFileDialog.SelectedPath;
                }
            }
        }

        private void DibujarFigura()
        {
            string Resultado = CrearArchivoDot();
            MessageBox.Show($"{Resultado}", "Arbol Binario en Lenguaje Dot");
            InvocarDibujar();
        }

        private string CrearArchivoDot()
        {
            string Resultado = "";
            arbolCentrosCulturales.CrearArchivoDot(ref Resultado);

            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "Seleccione la ruta donde desee crear el archivo Figura";
            openFileDialog.ShowNewFolderButton = true;

            if (ubicacionFigura == "" || ubicacionFigura == null)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ubicacionFigura = openFileDialog.SelectedPath;
                }
            }

            StreamWriter nombreArchivo = new StreamWriter($"{ubicacionFigura}\\Figura"); 
            nombreArchivo.WriteLine(Resultado);
            nombreArchivo.Close();
            return Resultado;
        }

        private void InvocarDibujar()
        {
            strRutaDot = @"..\..\Resources\Graphviz\bin\dot.exe";

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = false,
                    UseShellExecute = true,
                    FileName = @"..\..\Resources\DibujarFigura.bat",
                    WindowStyle = ProcessWindowStyle.Normal,
                    Arguments = $"\"{ubicacionFigura}\" \"{strRutaDot}\""
                }
            };
            process.Start();
            process.WaitForExit();
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            dtgCentrosCulturales.Rows.Clear();

            foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPreOrden())
            {
                dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
            }
        }

        private void radInOrden_CheckedChanged(object sender, EventArgs e)
        {
            dtgCentrosCulturales.Rows.Clear();

            foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerInOrden())
            {
                dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
            }
        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            dtgCentrosCulturales.Rows.Clear();

            foreach (CentroCultural centroCultural in arbolCentrosCulturales.RecorrerPostOrden())
            {
                dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
            }
        }

        private void dtgCentrosCulturales_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCentrosCulturales.SelectedRows.Count == 1)
            {
                CentroCultural centroCultural = new CentroCultural();
                centroCultural.CodigoPostal = int.Parse(dtgCentrosCulturales.SelectedRows[0].Cells[0].Value.ToString());

                CentroCultural centroBuscado = arbolCentrosCulturales.BuscarNodo(centroCultural);

                txtCodigoPostal.Text = centroBuscado.CodigoPostal.ToString();
                txtPresupuesto.Text = centroBuscado.Presupuesto.ToString();
                cboPosicionamiento.Text = centroBuscado.Posicionamiento.ToString();
                dtmFechaConstruccion.Value = centroBuscado.FechaConstruccion;
                if (centroBuscado.Sector == "Público") radPublico.Checked = true;
                if (centroBuscado.Sector == "Privado") radPrivado.Checked = true;
                if (centroBuscado.Mantenimiento == true) chkMantenimiento.Checked = true;
                if (centroBuscado.Mantenimiento == false) chkMantenimiento.Checked = false;
                picImagen.ImageLocation = centroBuscado.RutaImagen;
            }
        }

        private void dtgCentrosCulturales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value is char)
                {
                    char value = (char)e.Value;

                    switch (value)
                    {
                        case 'N': e.Value = "Norte"; break;
                        case 'S': e.Value = "Sur"; break;
                        case 'E': e.Value = "Este"; break;
                        case 'O': e.Value = "Oeste"; break;
                    }
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Si" : "No";
                    e.FormattingApplied = true;
                }
            }
        }

    }
}
