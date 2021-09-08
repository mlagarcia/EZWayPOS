
namespace EZWayPOS.Vistas.ModeloVehiculo
{
  partial class FrmModeloVehiculoViewModel
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
      this.btnBuscar = new System.Windows.Forms.Button();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.gridModeloVehiculo = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridModeloVehiculo)).BeginInit();
      this.SuspendLayout();
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(533, 12);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 32);
      this.btnBuscar.TabIndex = 5;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtModelo
      // 
      this.txtModelo.Location = new System.Drawing.Point(12, 18);
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(503, 20);
      this.txtModelo.TabIndex = 4;
      // 
      // gridModeloVehiculo
      // 
      this.gridModeloVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridModeloVehiculo.Location = new System.Drawing.Point(12, 50);
      this.gridModeloVehiculo.Name = "gridModeloVehiculo";
      this.gridModeloVehiculo.ReadOnly = true;
      this.gridModeloVehiculo.Size = new System.Drawing.Size(758, 303);
      this.gridModeloVehiculo.TabIndex = 3;
      this.gridModeloVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellContentClick);
      this.gridModeloVehiculo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellContentDoubleClick);
      this.gridModeloVehiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellDoubleClick);
      // 
      // FrmModeloVehiculoViewModel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 375);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtModelo);
      this.Controls.Add(this.gridModeloVehiculo);
      this.Name = "FrmModeloVehiculoViewModel";
      this.Text = "FrmModeloVehiculoViewModel";
      this.Load += new System.EventHandler(this.FrmModeloVehiculoViewModel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridModeloVehiculo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.TextBox txtModelo;
    private System.Windows.Forms.DataGridView gridModeloVehiculo;
  }
}