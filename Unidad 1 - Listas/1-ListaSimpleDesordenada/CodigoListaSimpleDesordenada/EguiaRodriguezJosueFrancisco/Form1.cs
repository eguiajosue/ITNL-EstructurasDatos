using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EguiaRodriguezJosueFrancisco
{
    public partial class Form1 : Form
    {

        ListaSimpleDesordenada<CentroCultural> listaCentrosCulturales = new ListaSimpleDesordenada<CentroCultural>();
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

        // Se muestran los datos dentro de dtgCentrosCulturales
        public void CargarDatos()
        {
            dtgCentrosCulturales.Rows.Clear();

            foreach (CentroCultural centroCultural in listaCentrosCulturales)
            {
                dtgCentrosCulturales.Rows.Add(centroCultural.CodigoPostal, centroCultural.Presupuesto.ToString("C"), centroCultural.Posicionamiento ,centroCultural.FechaConstruccion.ToLongDateString(), centroCultural.Mantenimiento, centroCultural.Sector);
            }
        }

        // Los controles dentro del groupBox se actualizan a un valor nulo
        public void LimpiarDatos()
        {
            foreach (Control control in grpDatosCentroCultural.Controls)
            {
                if (control is TextBox txt) txt.Text = "";
            }
            chkMantenimiento.Checked = false;
            radPublico.Checked = true;
            radPrivado.Checked = false;
            cboPosicionamiento.Text = null;
            picImagen.Image = null;
            picImagen.ImageLocation = null;
            dtmFechaConstruccion.Value = DateTime.Today;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar un nuevo elemento a la lista?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Se crea un objeto del nuevo centro culturar a crear
                    CentroCultural centroCultural = new CentroCultural();

                    // Se almacenan los datos de cada control con la propiedad correspondiente
                    centroCultural.CodigoPostal = int.Parse(txtCodigoPostal.Text);
                    centroCultural.Presupuesto = double.Parse(txtPresupuesto.Text);
                    centroCultural.FechaConstruccion = dtmFechaConstruccion.Value;
                    centroCultural.Posicionamiento = char.Parse(cboPosicionamiento.Text);
                    centroCultural.Mantenimiento = chkMantenimiento.Checked;
                    if (radPublico.Checked) centroCultural.Sector = "Público";
                    if (radPrivado.Checked) centroCultural.Sector = "Privado";
                    centroCultural.RutaImagen = picImagen.ImageLocation;

                    // Se ejecuta el metodo AgregarNodo() en la lista simple pasando como parámetro el objeto recien creado
                    listaCentrosCulturales.AgregarNodo(centroCultural);

                    // Se limpian los datos para crear un nuevo Centro Culturar y se actualiza dtgCentrosCulturales con los nuevos datos
                    CargarDatos();
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            // Se crea un objeto de tipo OpenFileDialog para poder abrir un explorador de archivos y poder seleccionar una imagen
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


        private void btnGenerarAleatorio_Click(object sender, EventArgs e)
        {
            int valorMinimo = 00000; // <== Valor minimo de al menos 5 dígitos para el código postal
            int valorMaximo = 99999; // <== Valor máximo de al menos 5 dígitos para el código postal

            // Se crea un arreglo con la ruta a cada una de las imagenes ubicada en la carpeta Resourses del programa
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

            char[] arrayPosiciones = { 'N', 'S', 'E', 'O' }; // <== Se crea un arreglo con los datos para las posiciones
            bool[] arrayMantenimiento = { true, false }; // <== Se crea un arreglo con los datos del estado de mantenimiento
            string[] arrayTipoSector = { "Público", "Privado" }; // <== Se crea un arreglo con los datos del tipo de sector

            // Se crea un objeto de tipo Random para poder generar los datos aleatorios
            Random random = new Random();
            // Se realiza un ciclo for para crear 10 datos de forma aleatoria
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    // Se crea un objeto para el Centro Cultural con datos aleatorios
                    CentroCultural nuevoCentroCulturalAleatorio = new CentroCultural();

                    nuevoCentroCulturalAleatorio.CodigoPostal = random.Next(valorMinimo, valorMaximo);
                    nuevoCentroCulturalAleatorio.Presupuesto = random.Next();
                    nuevoCentroCulturalAleatorio.Posicionamiento = arrayPosiciones[random.Next(arrayPosiciones.Length)];
                    nuevoCentroCulturalAleatorio.FechaConstruccion = new DateTime(random.Next(1950, 2021), random.Next(1, 13), random.Next(1, 31));
                    nuevoCentroCulturalAleatorio.Mantenimiento = arrayMantenimiento[random.Next(arrayMantenimiento.Length)];
                    nuevoCentroCulturalAleatorio.Sector = arrayTipoSector[random.Next(arrayTipoSector.Length)];
                    nuevoCentroCulturalAleatorio.RutaImagen = arrayImagenes[random.Next(arrayImagenes.Length)];

                    listaCentrosCulturales.AgregarNodo(nuevoCentroCulturalAleatorio);
                    CargarDatos();
                    dtgCentrosCulturales.ClearSelection();
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Eliminar Registro (de forma individual)
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dtgCentrosCulturales.SelectedRows.Count == 1) // <== Se verifica que se esté seleccionando una fila dentro del dtgCentrosCulturales
            {
                try
                {
                    // Se abre un DialogResult para preguntar al usuario si desea eliminar el elemento seleccionado
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el elemento seleccionado?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) // En caso de que el resultado sea "Si"... 
                    {
                        CentroCultural centroCultural = new CentroCultural(); // Se crea un objeto nuevo para la eliminación del elemento
                        centroCultural.CodigoPostal = int.Parse(dtgCentrosCulturales.SelectedRows[0].Cells[0].Value.ToString()); // <== La propiedad CodigoPostal tendrá almacenado el elemento seleccionado en el dtgCentrosCulturales
                        listaCentrosCulturales.EliminarNodo(centroCultural); // <== Se implementa el metodo EliminarNodo() pasando como parametro al objeto seleccionado
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
                MessageBox.Show("Para eliminar un dato debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        // Metodo para buscar un nodo deseado (se usa para el botón btnBuscar y para el evento KeyDown del txtBuscar)
        public void BuscarNodo()
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text)) // <== Se verifica que el txtBuscar no esté vacío o tenga unicamente espacios en blanco
            {
                try
                {
                    CentroCultural centroCultural = new CentroCultural(); 
                    centroCultural.CodigoPostal = int.Parse(txtBuscar.Text);  // <== Se crea un objeto donde se va a almacenar el valor del codigo postal introducido en el txtBuscar
                    CentroCultural centroBuscado = listaCentrosCulturales.BuscarNodo(centroCultural); // <== Se crea un objeto con el CC que se requiere buscar almacenando el objeto anterior en el metodo BuscarNodo()

                    // Las propiedades del objeto buscado (y que se haya encontrado) se muestran en sus controles respectivamente
                    txtCodigoPostal.Text = centroBuscado.CodigoPostal.ToString();
                    txtPresupuesto.Text = centroBuscado.Presupuesto.ToString();
                    cboPosicionamiento.Text = centroBuscado.Posicionamiento.ToString();
                    dtmFechaConstruccion.Value = centroBuscado.FechaConstruccion;
                    if (centroBuscado.Sector == "Público") radPublico.Checked = true;
                    if (centroBuscado.Sector == "Privado") radPrivado.Checked = true;
                    if (centroBuscado.Mantenimiento == true) chkMantenimiento.Checked = true;
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
            BuscarNodo(); // <== Se hace uso del metodo BuscarNodo() al momento de dar clic en el botón Buscar
            txtBuscar.Text = "";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarNodo(); // <== Se hace uso del metodo BuscarNodo() al momento de presionar la tecla ENTER estando dentro del txtBuscar
            }
        }


        // Este metodo se usa para que al momento de cambiar de celda o de dar doble click sobre una celda del dtgCentrosCulturales, se muestren los datos en sus controles respectivamente
        public void MostrarDatosControles()
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

        private void dtgCentrosCulturales_DoubleClick(object sender, EventArgs e)
        {
            MostrarDatosControles();
        }

        private void dtgCentrosCulturales_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dtgCentrosCulturales.SelectedRows.Count == 1)
            {
                MostrarDatosControles();
            }
        }



        private void dtgCentrosCulturales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Se da un formato para el dato de tipo `char` para que en lugar de que en el dtgCentrosCulturales se muestre 'N', 'S', 'E' y 'O' se muestre el dato completo "Norte", "Sur", "Este", "Oeste"
            //! No afecta al tipo de dato, solo es el formato en el que se visualiza en el DataGridView
            if (e.ColumnIndex == 2)
            {
                if(e.Value is char)
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
            // Se realiza el mismo formateo de datos, pero en este caso es para los de tipo bool, para que muestre "Si" o "No" en lugar de True o False
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
