using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaDinamicaOrdenada
{
    public partial class Form1 : Form
    {
        ColaDinamicaOrdenada<CentroCultural> listaCentrosCulturales = new ColaDinamicaOrdenada<CentroCultural>();

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
        }

        public void CargarDatos()
        {
            dtgCentrosCulturales.Rows.Clear();

            foreach (CentroCultural centroCultural in listaCentrosCulturales)
            {
                dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento, centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
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

        private void btnAgregar_Click(object sender, EventArgs e)
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

                    listaCentrosCulturales.AgregarNodo(centroCultural);

                    CargarDatos();
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarAleatorio_Click(object sender, EventArgs e)
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
                    CentroCultural randomCC = new CentroCultural();

                    randomCC.CodigoPostal = random.Next(intCodigoPostalMinimo, intCodigoPostalMaximo);
                    randomCC.Presupuesto = random.Next();
                    randomCC.Posicionamiento = arrayPosiciones[random.Next(arrayPosiciones.Length)];
                    randomCC.FechaConstruccion = new DateTime(random.Next(1950, 2021), random.Next(1, 13), random.Next(1, 31));
                    randomCC.Mantenimiento = arrayMantenimiento[random.Next(arrayMantenimiento.Length)];
                    randomCC.Sector = arrayTipoSector[random.Next(arrayTipoSector.Length)];
                    randomCC.RutaImagen = arrayImagenes[random.Next(arrayImagenes.Length)];

                    listaCentrosCulturales.AgregarNodo(randomCC);
                    CargarDatos();
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
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
                        listaCentrosCulturales.EliminarNodo(centroCultural);
                        CargarDatos();
                        LimpiarDatos();
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

        private void btnEliminarTope_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se eliminará el registro que está al inicio de la tabla ¿está seguro que desea eliminarla?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listaCentrosCulturales.EliminarNodo();
                    CargarDatos();
                    LimpiarDatos();
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
                        listaCentrosCulturales.Vaciar();
                        CargarDatos();
                        LimpiarDatos();
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

        public void BuscarNodo()
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                try
                {
                    CentroCultural BuscarCentroCultural = new CentroCultural();
                    BuscarCentroCultural.CodigoPostal = int.Parse(txtBuscar.Text);

                    CentroCultural centroBuscado = listaCentrosCulturales.BuscarNodo(BuscarCentroCultural);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNodo();
            txtBuscar.Clear();
        }

        private void dtgCentrosCulturales_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCentrosCulturales.SelectedRows.Count == 1)
            {
                CentroCultural centroCultural = new CentroCultural();
                centroCultural.CodigoPostal = int.Parse(dtgCentrosCulturales.SelectedRows[0].Cells[0].Value.ToString());

                CentroCultural centroBuscado = listaCentrosCulturales.BuscarNodo(centroCultural);

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

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
