namespace MetodoBurbuja
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
            this.dtgEstudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSennal = new System.Windows.Forms.CheckBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDirecto = new System.Windows.Forms.RadioButton();
            this.radPasoAPaso = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn5ObjetosAleatorios = new System.Windows.Forms.Button();
            this.btn50ObjetosAleatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEstudiantes
            // 
            this.dtgEstudiantes.AllowUserToAddRows = false;
            this.dtgEstudiantes.AllowUserToDeleteRows = false;
            this.dtgEstudiantes.AllowUserToResizeRows = false;
            this.dtgEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantes.Location = new System.Drawing.Point(16, 110);
            this.dtgEstudiantes.MultiSelect = false;
            this.dtgEstudiantes.Name = "dtgEstudiantes";
            this.dtgEstudiantes.ReadOnly = true;
            this.dtgEstudiantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstudiantes.Size = new System.Drawing.Size(717, 793);
            this.dtgEstudiantes.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSennal);
            this.groupBox2.Controls.Add(this.btnDerecha);
            this.groupBox2.Controls.Add(this.btnIzquierda);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de ordenamiento";
            // 
            // chkSennal
            // 
            this.chkSennal.AutoSize = true;
            this.chkSennal.Location = new System.Drawing.Point(278, 45);
            this.chkSennal.Name = "chkSennal";
            this.chkSennal.Size = new System.Drawing.Size(75, 17);
            this.chkSennal.TabIndex = 9;
            this.chkSennal.Text = "Con Señal";
            this.chkSennal.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.SystemColors.Control;
            this.btnDerecha.FlatAppearance.BorderSize = 0;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDerecha.Location = new System.Drawing.Point(142, 37);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(130, 32);
            this.btnDerecha.TabIndex = 8;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzquierda.FlatAppearance.BorderSize = 0;
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzquierda.Location = new System.Drawing.Point(6, 37);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(130, 32);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radDirecto);
            this.groupBox3.Controls.Add(this.radPasoAPaso);
            this.groupBox3.Location = new System.Drawing.Point(228, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preferencias";
            // 
            // radDirecto
            // 
            this.radDirecto.AutoSize = true;
            this.radDirecto.Checked = true;
            this.radDirecto.Location = new System.Drawing.Point(6, 29);
            this.radDirecto.Name = "radDirecto";
            this.radDirecto.Size = new System.Drawing.Size(88, 17);
            this.radDirecto.TabIndex = 1;
            this.radDirecto.TabStop = true;
            this.radDirecto.Text = "Directamente";
            this.radDirecto.UseVisualStyleBackColor = true;
            // 
            // radPasoAPaso
            // 
            this.radPasoAPaso.AutoSize = true;
            this.radPasoAPaso.Location = new System.Drawing.Point(6, 52);
            this.radPasoAPaso.Name = "radPasoAPaso";
            this.radPasoAPaso.Size = new System.Drawing.Size(84, 17);
            this.radPasoAPaso.TabIndex = 0;
            this.radPasoAPaso.Text = "Paso a paso";
            this.radPasoAPaso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn5ObjetosAleatorios);
            this.groupBox1.Controls.Add(this.btn50ObjetosAleatorios);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar";
            // 
            // btn5ObjetosAleatorios
            // 
            this.btn5ObjetosAleatorios.BackColor = System.Drawing.SystemColors.Control;
            this.btn5ObjetosAleatorios.FlatAppearance.BorderSize = 0;
            this.btn5ObjetosAleatorios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5ObjetosAleatorios.Location = new System.Drawing.Point(6, 22);
            this.btn5ObjetosAleatorios.Name = "btn5ObjetosAleatorios";
            this.btn5ObjetosAleatorios.Size = new System.Drawing.Size(194, 29);
            this.btn5ObjetosAleatorios.TabIndex = 3;
            this.btn5ObjetosAleatorios.Text = "5 objetos aleatorios";
            this.btn5ObjetosAleatorios.UseVisualStyleBackColor = false;
            this.btn5ObjetosAleatorios.Click += new System.EventHandler(this.btn5ObjetosAleatorios_Click);
            // 
            // btn50ObjetosAleatorios
            // 
            this.btn50ObjetosAleatorios.BackColor = System.Drawing.SystemColors.Control;
            this.btn50ObjetosAleatorios.FlatAppearance.BorderSize = 0;
            this.btn50ObjetosAleatorios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn50ObjetosAleatorios.Location = new System.Drawing.Point(6, 57);
            this.btn50ObjetosAleatorios.Name = "btn50ObjetosAleatorios";
            this.btn50ObjetosAleatorios.Size = new System.Drawing.Size(194, 29);
            this.btn50ObjetosAleatorios.TabIndex = 2;
            this.btn50ObjetosAleatorios.Text = "50 objetos aleatorios";
            this.btn50ObjetosAleatorios.UseVisualStyleBackColor = false;
            this.btn50ObjetosAleatorios.Click += new System.EventHandler(this.btn50ObjetosAleatorios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 915);
            this.Controls.Add(this.dtgEstudiantes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Bubble Sort con objetos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgEstudiantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radDirecto;
        private System.Windows.Forms.RadioButton radPasoAPaso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn50ObjetosAleatorios;
        private System.Windows.Forms.Button btn5ObjetosAleatorios;
        private System.Windows.Forms.CheckBox chkSennal;
    }
}

