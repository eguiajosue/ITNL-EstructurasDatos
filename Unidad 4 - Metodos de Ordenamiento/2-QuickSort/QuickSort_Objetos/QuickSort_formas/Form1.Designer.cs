
namespace QuickSort_formas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTipoDeOrden = new System.Windows.Forms.GroupBox();
            this.radOrdenarSueldo = new System.Windows.Forms.RadioButton();
            this.radOrdenarNumero = new System.Windows.Forms.RadioButton();
            this.radOrdenarNombre = new System.Windows.Forms.RadioButton();
            this.grpCriterioOrdenamiento = new System.Windows.Forms.GroupBox();
            this.radDescendente = new System.Windows.Forms.RadioButton();
            this.radAscendente = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.grpTipoDeOrden.SuspendLayout();
            this.grpCriterioOrdenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoDeOrden
            // 
            this.grpTipoDeOrden.Controls.Add(this.radOrdenarSueldo);
            this.grpTipoDeOrden.Controls.Add(this.radOrdenarNumero);
            this.grpTipoDeOrden.Controls.Add(this.radOrdenarNombre);
            this.grpTipoDeOrden.Location = new System.Drawing.Point(12, 287);
            this.grpTipoDeOrden.Name = "grpTipoDeOrden";
            this.grpTipoDeOrden.Size = new System.Drawing.Size(135, 98);
            this.grpTipoDeOrden.TabIndex = 20;
            this.grpTipoDeOrden.TabStop = false;
            this.grpTipoDeOrden.Text = "Ordenar por";
            // 
            // radOrdenarSueldo
            // 
            this.radOrdenarSueldo.AutoSize = true;
            this.radOrdenarSueldo.Location = new System.Drawing.Point(13, 68);
            this.radOrdenarSueldo.Name = "radOrdenarSueldo";
            this.radOrdenarSueldo.Size = new System.Drawing.Size(58, 17);
            this.radOrdenarSueldo.TabIndex = 2;
            this.radOrdenarSueldo.TabStop = true;
            this.radOrdenarSueldo.Text = "Sueldo";
            this.radOrdenarSueldo.UseVisualStyleBackColor = true;
            // 
            // radOrdenarNumero
            // 
            this.radOrdenarNumero.AutoSize = true;
            this.radOrdenarNumero.Checked = true;
            this.radOrdenarNumero.Location = new System.Drawing.Point(12, 22);
            this.radOrdenarNumero.Name = "radOrdenarNumero";
            this.radOrdenarNumero.Size = new System.Drawing.Size(62, 17);
            this.radOrdenarNumero.TabIndex = 1;
            this.radOrdenarNumero.TabStop = true;
            this.radOrdenarNumero.Text = "Número";
            this.radOrdenarNumero.UseVisualStyleBackColor = true;
            // 
            // radOrdenarNombre
            // 
            this.radOrdenarNombre.AutoSize = true;
            this.radOrdenarNombre.Location = new System.Drawing.Point(12, 45);
            this.radOrdenarNombre.Name = "radOrdenarNombre";
            this.radOrdenarNombre.Size = new System.Drawing.Size(62, 17);
            this.radOrdenarNombre.TabIndex = 0;
            this.radOrdenarNombre.Text = "Nombre";
            this.radOrdenarNombre.UseVisualStyleBackColor = true;
            // 
            // grpCriterioOrdenamiento
            // 
            this.grpCriterioOrdenamiento.Controls.Add(this.radDescendente);
            this.grpCriterioOrdenamiento.Controls.Add(this.radAscendente);
            this.grpCriterioOrdenamiento.Location = new System.Drawing.Point(12, 205);
            this.grpCriterioOrdenamiento.Name = "grpCriterioOrdenamiento";
            this.grpCriterioOrdenamiento.Size = new System.Drawing.Size(135, 74);
            this.grpCriterioOrdenamiento.TabIndex = 19;
            this.grpCriterioOrdenamiento.TabStop = false;
            this.grpCriterioOrdenamiento.Text = "Criterio de ordenamiento";
            // 
            // radDescendente
            // 
            this.radDescendente.AutoSize = true;
            this.radDescendente.Location = new System.Drawing.Point(13, 45);
            this.radDescendente.Name = "radDescendente";
            this.radDescendente.Size = new System.Drawing.Size(89, 17);
            this.radDescendente.TabIndex = 1;
            this.radDescendente.TabStop = true;
            this.radDescendente.Text = "Descendente";
            this.radDescendente.UseVisualStyleBackColor = true;
            // 
            // radAscendente
            // 
            this.radAscendente.AutoSize = true;
            this.radAscendente.Checked = true;
            this.radAscendente.Location = new System.Drawing.Point(13, 22);
            this.radAscendente.Name = "radAscendente";
            this.radAscendente.Size = new System.Drawing.Size(82, 17);
            this.radAscendente.TabIndex = 0;
            this.radAscendente.TabStop = true;
            this.radAscendente.Text = "Ascendente";
            this.radAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(306, 145);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(306, 61);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 15;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(306, 24);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(217, 180);
            this.dataGridView1.TabIndex = 13;
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Controls.Add(this.txtSueldo);
            this.grpDatosEmpleado.Controls.Add(this.lblSueldo);
            this.grpDatosEmpleado.Controls.Add(this.txtNombre);
            this.grpDatosEmpleado.Controls.Add(this.lblNombre);
            this.grpDatosEmpleado.Controls.Add(this.txtNumero);
            this.grpDatosEmpleado.Controls.Add(this.lblNumero);
            this.grpDatosEmpleado.Location = new System.Drawing.Point(12, 12);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Size = new System.Drawing.Size(272, 174);
            this.grpDatosEmpleado.TabIndex = 12;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(79, 98);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(30, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(37, 101);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(79, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(75, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(37, 49);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(24, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "No.";
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(306, 95);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 36);
            this.btnAleatorio.TabIndex = 21;
            this.btnAleatorio.Text = "Generar datos aleatorios";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 397);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.grpTipoDeOrden);
            this.Controls.Add(this.grpCriterioOrdenamiento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDatosEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTipoDeOrden.ResumeLayout(false);
            this.grpTipoDeOrden.PerformLayout();
            this.grpCriterioOrdenamiento.ResumeLayout(false);
            this.grpCriterioOrdenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.grpDatosEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoDeOrden;
        private System.Windows.Forms.RadioButton radOrdenarSueldo;
        private System.Windows.Forms.RadioButton radOrdenarNumero;
        private System.Windows.Forms.RadioButton radOrdenarNombre;
        private System.Windows.Forms.GroupBox grpCriterioOrdenamiento;
        private System.Windows.Forms.RadioButton radDescendente;
        private System.Windows.Forms.RadioButton radAscendente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAleatorio;
    }
}

