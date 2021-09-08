
namespace EZWayPOS.Vistas.MarcaVehiculo
{
    partial class FrmMarcaVehiculoViewModel
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
      this.txtMarca = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.gridMarcaVehiculo = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridMarcaVehiculo)).BeginInit();
      this.SuspendLayout();
      // 
      // txtMarca
      // 
      this.txtMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMarca.Location = new System.Drawing.Point(16, 19);
      this.txtMarca.Name = "txtMarca";
      this.txtMarca.Size = new System.Drawing.Size(334, 26);
      this.txtMarca.TabIndex = 1;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(369, 13);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 34);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // gridMarcaVehiculo
      // 
      this.gridMarcaVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridMarcaVehiculo.Location = new System.Drawing.Point(16, 59);
      this.gridMarcaVehiculo.Name = "gridMarcaVehiculo";
      this.gridMarcaVehiculo.ReadOnly = true;
      this.gridMarcaVehiculo.Size = new System.Drawing.Size(428, 277);
      this.gridMarcaVehiculo.TabIndex = 0;
      this.gridMarcaVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMarcaVehiculo_CellContentClick_1);
      this.gridMarcaVehiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMarcaVehiculo_CellDoubleClick);
      // 
      // FrmMarcaVehiculoViewModel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(463, 370);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtMarca);
      this.Controls.Add(this.gridMarcaVehiculo);
      this.Name = "FrmMarcaVehiculoViewModel";
      this.Text = "Marcas de Vehiculos";
      this.Load += new System.EventHandler(this.FrmListadoMarcaVehiculo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridMarcaVehiculo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridMarcaVehiculo;
    }
}