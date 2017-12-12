namespace GeneradorCertificados
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
            this.components = new System.ComponentModel.Container();
            this.BarraProcesos = new System.Windows.Forms.ProgressBar();
            this.mostrar1 = new System.Windows.Forms.Label();
            this.txtRutaSalida = new System.Windows.Forms.TextBox();
            this.btnRutaSalida = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtRutaEntrada = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.abrirarchivo = new System.Windows.Forms.OpenFileDialog();
            this.guardararchivo = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListaProyecto = new System.Windows.Forms.ComboBox();
            this.lblproyecto = new System.Windows.Forms.Label();
            this.ReportteSalida = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblAyuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraProcesos
            // 
            this.BarraProcesos.Location = new System.Drawing.Point(273, 284);
            this.BarraProcesos.Name = "BarraProcesos";
            this.BarraProcesos.Size = new System.Drawing.Size(115, 19);
            this.BarraProcesos.TabIndex = 17;
            // 
            // mostrar1
            // 
            this.mostrar1.AutoSize = true;
            this.mostrar1.Location = new System.Drawing.Point(140, 284);
            this.mostrar1.Name = "mostrar1";
            this.mostrar1.Size = new System.Drawing.Size(0, 13);
            this.mostrar1.TabIndex = 16;
            // 
            // txtRutaSalida
            // 
            this.txtRutaSalida.Enabled = false;
            this.txtRutaSalida.Location = new System.Drawing.Point(15, 210);
            this.txtRutaSalida.Name = "txtRutaSalida";
            this.txtRutaSalida.Size = new System.Drawing.Size(373, 20);
            this.txtRutaSalida.TabIndex = 15;
            // 
            // btnRutaSalida
            // 
            this.btnRutaSalida.Enabled = false;
            this.btnRutaSalida.Location = new System.Drawing.Point(15, 181);
            this.btnRutaSalida.Name = "btnRutaSalida";
            this.btnRutaSalida.Size = new System.Drawing.Size(178, 23);
            this.btnRutaSalida.TabIndex = 14;
            this.btnRutaSalida.Text = "Directorio de Salida de Archivos";
            this.btnRutaSalida.UseVisualStyleBackColor = true;
            this.btnRutaSalida.Click += new System.EventHandler(this.btnRutaSalida_Click_1);
            // 
            // btnReporte
            // 
            this.btnReporte.Enabled = false;
            this.btnReporte.Location = new System.Drawing.Point(273, 250);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(115, 23);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "Generar Certificados";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtRutaEntrada
            // 
            this.txtRutaEntrada.Enabled = false;
            this.txtRutaEntrada.Location = new System.Drawing.Point(15, 153);
            this.txtRutaEntrada.Name = "txtRutaEntrada";
            this.txtRutaEntrada.Size = new System.Drawing.Size(373, 20);
            this.txtRutaEntrada.TabIndex = 12;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Enabled = false;
            this.btnExaminar.Location = new System.Drawing.Point(15, 124);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(125, 23);
            this.btnExaminar.TabIndex = 11;
            this.btnExaminar.Text = "Archivo de Entrada";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccionar Archivo CSV de Entrada";
            // 
            // abrirarchivo
            // 
            this.abrirarchivo.FileName = "openFileDialog1";
            this.abrirarchivo.Filter = " | *.csv";
            this.abrirarchivo.RestoreDirectory = true;
            // 
            // ListaProyecto
            // 
            this.ListaProyecto.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.ListaProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaProyecto.FormattingEnabled = true;
            this.ListaProyecto.Location = new System.Drawing.Point(15, 61);
            this.ListaProyecto.Name = "ListaProyecto";
            this.ListaProyecto.Size = new System.Drawing.Size(373, 21);
            this.ListaProyecto.TabIndex = 20;
            this.ListaProyecto.SelectedIndexChanged += new System.EventHandler(this.ListaProyecto_SelectedIndexChanged);
            // 
            // lblproyecto
            // 
            this.lblproyecto.AutoSize = true;
            this.lblproyecto.Location = new System.Drawing.Point(12, 45);
            this.lblproyecto.Name = "lblproyecto";
            this.lblproyecto.Size = new System.Drawing.Size(105, 13);
            this.lblproyecto.TabIndex = 21;
            this.lblproyecto.Text = "Seleccione Proyecto";
            // 
            // ReportteSalida
            // 
            this.ReportteSalida.DocumentMapWidth = 55;
            this.ReportteSalida.Location = new System.Drawing.Point(53, 250);
            this.ReportteSalida.Name = "ReportteSalida";
            this.ReportteSalida.Size = new System.Drawing.Size(59, 53);
            this.ReportteSalida.TabIndex = 18;
            this.ReportteSalida.Visible = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(15, 9);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(384, 26);
            this.lblAyuda.TabIndex = 19;
            this.lblAyuda.Text = "El archivo CSV solo debe tener en la columna A los numero de control de los cuale" +
    "s se desea obtener los certificados.";
            this.lblAyuda.Click += new System.EventHandler(this.lblAyuda_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 312);
            this.Controls.Add(this.lblproyecto);
            this.Controls.Add(this.ListaProyecto);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.BarraProcesos);
            this.Controls.Add(this.mostrar1);
            this.Controls.Add(this.txtRutaSalida);
            this.Controls.Add(this.btnRutaSalida);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtRutaEntrada);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportteSalida);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Dimensional";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarraProcesos;
        private System.Windows.Forms.Label mostrar1;
        private System.Windows.Forms.TextBox txtRutaSalida;
        private System.Windows.Forms.Button btnRutaSalida;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtRutaEntrada;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog abrirarchivo;
        private System.Windows.Forms.SaveFileDialog guardararchivo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        
        private System.Windows.Forms.BindingSource proyectoBindingSource1;
        
        private System.Windows.Forms.ComboBox ListaProyecto;
        private System.Windows.Forms.Label lblproyecto;
        private Microsoft.Reporting.WinForms.ReportViewer ReportteSalida;
        private System.Windows.Forms.Label lblAyuda;
    }
}

