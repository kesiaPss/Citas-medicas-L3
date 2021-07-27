namespace Citas_Medicas
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCitaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCitasMedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCitasProgramadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.citaMedicaToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem,
            this.listaDeCitasMedicasToolStripMenuItem,
            this.registrarseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citaMedicaToolStripMenuItem
            // 
            this.citaMedicaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.citaMedicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCitaMedicaToolStripMenuItem});
            this.citaMedicaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.citaMedicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("citaMedicaToolStripMenuItem.Image")));
            this.citaMedicaToolStripMenuItem.Name = "citaMedicaToolStripMenuItem";
            this.citaMedicaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.citaMedicaToolStripMenuItem.Text = "Cita Medica";
            // 
            // crearCitaMedicaToolStripMenuItem
            // 
            this.crearCitaMedicaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.crearCitaMedicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("crearCitaMedicaToolStripMenuItem.Image")));
            this.crearCitaMedicaToolStripMenuItem.Name = "crearCitaMedicaToolStripMenuItem";
            this.crearCitaMedicaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.crearCitaMedicaToolStripMenuItem.Text = "Crear Cita Medica";
            this.crearCitaMedicaToolStripMenuItem.Click += new System.EventHandler(this.crearCitaMedicaToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaciónToolStripMenuItem.Image")));
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.facturarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturarToolStripMenuItem.Image")));
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // listaDeDoctoresYEspecialidadesToolStripMenuItem
            // 
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctoresToolStripMenuItem,
            this.especialidadesToolStripMenuItem});
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeDoctoresYEspecialidadesToolStripMenuItem.Image")));
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Name = "listaDeDoctoresYEspecialidadesToolStripMenuItem";
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.listaDeDoctoresYEspecialidadesToolStripMenuItem.Text = "Doctores y Especialidades";
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.doctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDoctoresToolStripMenuItem});
            this.doctoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doctoresToolStripMenuItem.Image")));
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            // 
            // mantenimientoDoctoresToolStripMenuItem
            // 
            this.mantenimientoDoctoresToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.mantenimientoDoctoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDoctoresToolStripMenuItem.Image")));
            this.mantenimientoDoctoresToolStripMenuItem.Name = "mantenimientoDoctoresToolStripMenuItem";
            this.mantenimientoDoctoresToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.mantenimientoDoctoresToolStripMenuItem.Text = "Mantenimiento Doctores";
            this.mantenimientoDoctoresToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDoctoresToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEspecialidadesToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("especialidadesToolStripMenuItem.Image")));
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // mantenimientoEspecialidadesToolStripMenuItem
            // 
            this.mantenimientoEspecialidadesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.mantenimientoEspecialidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoEspecialidadesToolStripMenuItem.Image")));
            this.mantenimientoEspecialidadesToolStripMenuItem.Name = "mantenimientoEspecialidadesToolStripMenuItem";
            this.mantenimientoEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.mantenimientoEspecialidadesToolStripMenuItem.Text = "Mantenimiento Especialidades";
            // 
            // listaDeCitasMedicasToolStripMenuItem
            // 
            this.listaDeCitasMedicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarCitasProgramadasToolStripMenuItem});
            this.listaDeCitasMedicasToolStripMenuItem.Enabled = false;
            this.listaDeCitasMedicasToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.listaDeCitasMedicasToolStripMenuItem.Name = "listaDeCitasMedicasToolStripMenuItem";
            this.listaDeCitasMedicasToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.listaDeCitasMedicasToolStripMenuItem.Text = "Lista de Citas Medicas";
            // 
            // buscarCitasProgramadasToolStripMenuItem
            // 
            this.buscarCitasProgramadasToolStripMenuItem.Name = "buscarCitasProgramadasToolStripMenuItem";
            this.buscarCitasProgramadasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.buscarCitasProgramadasToolStripMenuItem.Text = "Buscar Citas Programadas";
            this.buscarCitasProgramadasToolStripMenuItem.Click += new System.EventHandler(this.buscarCitasProgramadasToolStripMenuItem_Click);
            // 
            // registrarseToolStripMenuItem
            // 
            this.registrarseToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.registrarseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.registrarseToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.registrarseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarseToolStripMenuItem.Image")));
            this.registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            this.registrarseToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.registrarseToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Peru;
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Peru;
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(778, 383);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCitaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCitasMedicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCitasProgramadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeDoctoresYEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}