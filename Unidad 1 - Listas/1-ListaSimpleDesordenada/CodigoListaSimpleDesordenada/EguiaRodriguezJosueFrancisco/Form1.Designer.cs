
namespace EguiaRodriguezJosueFrancisco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatosCentroCultural = new System.Windows.Forms.GroupBox();
            this.lblLimpiar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnGenerarAleatorio = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.dtmFechaConstruccion = new System.Windows.Forms.DateTimePicker();
            this.cboPosicionamiento = new System.Windows.Forms.ComboBox();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.chkMantenimiento = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPrivado = new System.Windows.Forms.RadioButton();
            this.radPublico = new System.Windows.Forms.RadioButton();
            this.lblFechaConstruccion = new System.Windows.Forms.Label();
            this.lblPosicionamiento = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.dtgCentrosCulturales = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.grpDatosCentroCultural.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCentrosCulturales)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosCentroCultural
            // 
            this.grpDatosCentroCultural.Controls.Add(this.lblLimpiar);
            this.grpDatosCentroCultural.Controls.Add(this.btnVaciar);
            this.grpDatosCentroCultural.Controls.Add(this.btnEliminarRegistro);
            this.grpDatosCentroCultural.Controls.Add(this.btnCargarImagen);
            this.grpDatosCentroCultural.Controls.Add(this.btnGenerarAleatorio);
            this.grpDatosCentroCultural.Controls.Add(this.btnAgregar);
            this.grpDatosCentroCultural.Controls.Add(this.picImagen);
            this.grpDatosCentroCultural.Controls.Add(this.dtmFechaConstruccion);
            this.grpDatosCentroCultural.Controls.Add(this.cboPosicionamiento);
            this.grpDatosCentroCultural.Controls.Add(this.txtPresupuesto);
            this.grpDatosCentroCultural.Controls.Add(this.txtCodigoPostal);
            this.grpDatosCentroCultural.Controls.Add(this.chkMantenimiento);
            this.grpDatosCentroCultural.Controls.Add(this.groupBox1);
            this.grpDatosCentroCultural.Controls.Add(this.lblFechaConstruccion);
            this.grpDatosCentroCultural.Controls.Add(this.lblPosicionamiento);
            this.grpDatosCentroCultural.Controls.Add(this.lblPresupuesto);
            this.grpDatosCentroCultural.Controls.Add(this.lblCodigoPostal);
            this.grpDatosCentroCultural.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCentroCultural.Location = new System.Drawing.Point(12, 66);
            this.grpDatosCentroCultural.Name = "grpDatosCentroCultural";
            this.grpDatosCentroCultural.Size = new System.Drawing.Size(849, 192);
            this.grpDatosCentroCultural.TabIndex = 0;
            this.grpDatosCentroCultural.TabStop = false;
            this.grpDatosCentroCultural.Text = "Datos del Centro Cultural";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.BackColor = System.Drawing.Color.LightBlue;
            this.lblLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLimpiar.ForeColor = System.Drawing.Color.White;
            this.lblLimpiar.Location = new System.Drawing.Point(6, 154);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(501, 27);
            this.lblLimpiar.TabIndex = 15;
            this.lblLimpiar.Text = "Limpiar Formulario";
            this.lblLimpiar.UseVisualStyleBackColor = false;
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.Maroon;
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.Location = new System.Drawing.Point(703, 147);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(140, 34);
            this.btnVaciar.TabIndex = 12;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(703, 107);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(140, 34);
            this.btnEliminarRegistro.TabIndex = 11;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCargarImagen.Location = new System.Drawing.Point(525, 154);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(151, 27);
            this.btnCargarImagen.TabIndex = 8;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // btnGenerarAleatorio
            // 
            this.btnGenerarAleatorio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnGenerarAleatorio.Location = new System.Drawing.Point(703, 56);
            this.btnGenerarAleatorio.Name = "btnGenerarAleatorio";
            this.btnGenerarAleatorio.Size = new System.Drawing.Size(140, 34);
            this.btnGenerarAleatorio.TabIndex = 10;
            this.btnGenerarAleatorio.Text = "Generar datos aleatorios";
            this.btnGenerarAleatorio.UseVisualStyleBackColor = false;
            this.btnGenerarAleatorio.Click += new System.EventHandler(this.btnGenerarAleatorio_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(703, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImagen.Location = new System.Drawing.Point(525, 19);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(151, 128);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 12;
            this.picImagen.TabStop = false;
            // 
            // dtmFechaConstruccion
            // 
            this.dtmFechaConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaConstruccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaConstruccion.Location = new System.Drawing.Point(137, 89);
            this.dtmFechaConstruccion.Name = "dtmFechaConstruccion";
            this.dtmFechaConstruccion.Size = new System.Drawing.Size(150, 20);
            this.dtmFechaConstruccion.TabIndex = 3;
            // 
            // cboPosicionamiento
            // 
            this.cboPosicionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicionamiento.FormattingEnabled = true;
            this.cboPosicionamiento.Items.AddRange(new object[] {
            "N",
            "S",
            "E",
            "O"});
            this.cboPosicionamiento.Location = new System.Drawing.Point(138, 120);
            this.cboPosicionamiento.Name = "cboPosicionamiento";
            this.cboPosicionamiento.Size = new System.Drawing.Size(149, 21);
            this.cboPosicionamiento.TabIndex = 4;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.Location = new System.Drawing.Point(138, 58);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(150, 20);
            this.txtPresupuesto.TabIndex = 2;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(138, 29);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoPostal.TabIndex = 1;
            // 
            // chkMantenimiento
            // 
            this.chkMantenimiento.AutoSize = true;
            this.chkMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMantenimiento.Location = new System.Drawing.Point(319, 28);
            this.chkMantenimiento.Name = "chkMantenimiento";
            this.chkMantenimiento.Size = new System.Drawing.Size(188, 17);
            this.chkMantenimiento.TabIndex = 5;
            this.chkMantenimiento.Text = "¿Se encuentra en mantenimiento?";
            this.chkMantenimiento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPrivado);
            this.groupBox1.Controls.Add(this.radPublico);
            this.groupBox1.Location = new System.Drawing.Point(319, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Sector";
            // 
            // radPrivado
            // 
            this.radPrivado.AutoSize = true;
            this.radPrivado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrivado.Location = new System.Drawing.Point(27, 51);
            this.radPrivado.Name = "radPrivado";
            this.radPrivado.Size = new System.Drawing.Size(61, 17);
            this.radPrivado.TabIndex = 7;
            this.radPrivado.TabStop = true;
            this.radPrivado.Text = "Privado";
            this.radPrivado.UseVisualStyleBackColor = true;
            // 
            // radPublico
            // 
            this.radPublico.AutoSize = true;
            this.radPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPublico.Location = new System.Drawing.Point(27, 28);
            this.radPublico.Name = "radPublico";
            this.radPublico.Size = new System.Drawing.Size(60, 17);
            this.radPublico.TabIndex = 6;
            this.radPublico.TabStop = true;
            this.radPublico.Text = "Publico";
            this.radPublico.UseVisualStyleBackColor = true;
            // 
            // lblFechaConstruccion
            // 
            this.lblFechaConstruccion.AutoSize = true;
            this.lblFechaConstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConstruccion.Location = new System.Drawing.Point(15, 93);
            this.lblFechaConstruccion.Name = "lblFechaConstruccion";
            this.lblFechaConstruccion.Size = new System.Drawing.Size(117, 13);
            this.lblFechaConstruccion.TabIndex = 4;
            this.lblFechaConstruccion.Text = "Fecha de Construccion";
            // 
            // lblPosicionamiento
            // 
            this.lblPosicionamiento.AutoSize = true;
            this.lblPosicionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionamiento.Location = new System.Drawing.Point(48, 123);
            this.lblPosicionamiento.Name = "lblPosicionamiento";
            this.lblPosicionamiento.Size = new System.Drawing.Size(84, 13);
            this.lblPosicionamiento.TabIndex = 3;
            this.lblPosicionamiento.Text = "Posicionamiento";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(66, 61);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(66, 13);
            this.lblPresupuesto.TabIndex = 2;
            this.lblPresupuesto.Text = "Presupuesto";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(60, 32);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostal.TabIndex = 1;
            this.lblCodigoPostal.Text = "Código Postal";
            // 
            // dtgCentrosCulturales
            // 
            this.dtgCentrosCulturales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCentrosCulturales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCentrosCulturales.Location = new System.Drawing.Point(18, 280);
            this.dtgCentrosCulturales.Name = "dtgCentrosCulturales";
            this.dtgCentrosCulturales.Size = new System.Drawing.Size(853, 260);
            this.dtgCentrosCulturales.TabIndex = 3;
            this.dtgCentrosCulturales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgCentrosCulturales_CellFormatting);
            this.dtgCentrosCulturales.SelectionChanged += new System.EventHandler(this.dtgCentrosCulturales_SelectionChanged);
            this.dtgCentrosCulturales.DoubleClick += new System.EventHandler(this.dtgCentrosCulturales_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(792, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 22);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(486, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 22);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(483, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(126, 13);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar por Código Postal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 552);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgCentrosCulturales);
            this.Controls.Add(this.grpDatosCentroCultural);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centros Culturales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatosCentroCultural.ResumeLayout(false);
            this.grpDatosCentroCultural.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCentrosCulturales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCentroCultural;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblFechaConstruccion;
        private System.Windows.Forms.Label lblPosicionamiento;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.DateTimePicker dtmFechaConstruccion;
        private System.Windows.Forms.ComboBox cboPosicionamiento;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.CheckBox chkMantenimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPrivado;
        private System.Windows.Forms.RadioButton radPublico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGenerarAleatorio;
        private System.Windows.Forms.DataGridView dtgCentrosCulturales;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button lblLimpiar;
    }
}

