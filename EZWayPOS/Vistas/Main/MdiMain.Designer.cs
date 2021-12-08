
namespace EZWayPOS.Vistas.Main
{
    partial class MdiMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoTransmisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeVehiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.fileMenu,
            this.sesiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(781, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVehiculoToolStripMenuItem,
            this.toolStripSeparator2,
            this.marcasToolStripMenuItem,
            this.modeloToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // agregarVehiculoToolStripMenuItem
            // 
            this.agregarVehiculoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarVehiculoToolStripMenuItem.Name = "agregarVehiculoToolStripMenuItem";
            this.agregarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.agregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo";
            this.agregarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.agregarVehiculoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.marcasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModeloToolStripMenuItem,
            this.buscarModeloToolStripMenuItem});
            this.modeloToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // agregarModeloToolStripMenuItem
            // 
            this.agregarModeloToolStripMenuItem.Name = "agregarModeloToolStripMenuItem";
            this.agregarModeloToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.agregarModeloToolStripMenuItem.Text = "Agregar Modelo";
            this.agregarModeloToolStripMenuItem.Click += new System.EventHandler(this.agregarModeloToolStripMenuItem_Click);
            // 
            // buscarModeloToolStripMenuItem
            // 
            this.buscarModeloToolStripMenuItem.Name = "buscarModeloToolStripMenuItem";
            this.buscarModeloToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarModeloToolStripMenuItem.Text = "Buscar Modelo";
            this.buscarModeloToolStripMenuItem.Click += new System.EventHandler(this.buscarModeloToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.buscarToolStripMenuItem1});
            this.empleadoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.empleadoToolStripMenuItem.Text = "Cliente";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(110, 21);
            this.fileMenu.Text = "&Configuración";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeVehiculoToolStripMenuItem,
            this.tipoDeVehiculoToolStripMenuItem,
            this.estadoVehiculoToolStripMenuItem,
            this.tipoMotorToolStripMenuItem,
            this.tipoTransmisionToolStripMenuItem,
            this.tiposDeVehiculoToolStripMenuItem1});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.newToolStripMenuItem.Text = "Vehículos";
            // 
            // tiposDeVehiculoToolStripMenuItem
            // 
            this.tiposDeVehiculoToolStripMenuItem.Name = "tiposDeVehiculoToolStripMenuItem";
            this.tiposDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tiposDeVehiculoToolStripMenuItem.Text = "Colores";
            this.tiposDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.tiposDeVehiculoToolStripMenuItem_Click);
            // 
            // tipoDeVehiculoToolStripMenuItem
            // 
            this.tipoDeVehiculoToolStripMenuItem.Name = "tipoDeVehiculoToolStripMenuItem";
            this.tipoDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tipoDeVehiculoToolStripMenuItem.Text = "Cuerpos de vehículo";
            this.tipoDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeVehiculoToolStripMenuItem_Click);
            // 
            // estadoVehiculoToolStripMenuItem
            // 
            this.estadoVehiculoToolStripMenuItem.Name = "estadoVehiculoToolStripMenuItem";
            this.estadoVehiculoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.estadoVehiculoToolStripMenuItem.Text = "Estados de vehículo";
            this.estadoVehiculoToolStripMenuItem.Click += new System.EventHandler(this.estadoVehiculoToolStripMenuItem_Click);
            // 
            // tipoMotorToolStripMenuItem
            // 
            this.tipoMotorToolStripMenuItem.Name = "tipoMotorToolStripMenuItem";
            this.tipoMotorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tipoMotorToolStripMenuItem.Text = "Tipos de motor";
            this.tipoMotorToolStripMenuItem.Click += new System.EventHandler(this.tipoMotorToolStripMenuItem_Click);
            // 
            // tipoTransmisionToolStripMenuItem
            // 
            this.tipoTransmisionToolStripMenuItem.Name = "tipoTransmisionToolStripMenuItem";
            this.tipoTransmisionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tipoTransmisionToolStripMenuItem.Text = "Tipos de transmisión";
            this.tipoTransmisionToolStripMenuItem.Click += new System.EventHandler(this.tipoTransmisionToolStripMenuItem_Click);
            // 
            // tiposDeVehiculoToolStripMenuItem1
            // 
            this.tiposDeVehiculoToolStripMenuItem1.Name = "tiposDeVehiculoToolStripMenuItem1";
            this.tiposDeVehiculoToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.tiposDeVehiculoToolStripMenuItem1.Text = "Tipos de vehículo";
            this.tiposDeVehiculoToolStripMenuItem1.Click += new System.EventHandler(this.tiposDeVehiculoToolStripMenuItem1_Click);
            // 
            // sesiToolStripMenuItem
            // 
            this.sesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.sesiToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesiToolStripMenuItem.Name = "sesiToolStripMenuItem";
            this.sesiToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.sesiToolStripMenuItem.Text = "Sesión";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 560);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(781, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(781, 582);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MdiMain";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.MdiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tiposDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeVehiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoTransmisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModeloToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buscarModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}



