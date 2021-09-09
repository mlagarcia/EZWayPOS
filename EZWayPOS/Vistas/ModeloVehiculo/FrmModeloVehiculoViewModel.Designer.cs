
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.txtModelo = new System.Windows.Forms.TextBox();
      this.gridModeloVehiculo = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridModeloVehiculo)).BeginInit();
      this.SuspendLayout();
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Image = global::EZWayPOS.Properties.Resources.search;
      this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnBuscar.Location = new System.Drawing.Point(602, 20);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(158, 32);
      this.btnBuscar.TabIndex = 5;
      this.btnBuscar.Text = "Buscar y Mostrar";
      this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtModelo
      // 
      this.txtModelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModelo.Location = new System.Drawing.Point(15, 25);
      this.txtModelo.Name = "txtModelo";
      this.txtModelo.Size = new System.Drawing.Size(568, 25);
      this.txtModelo.TabIndex = 4;
      // 
      // gridModeloVehiculo
      // 
      this.gridModeloVehiculo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.gridModeloVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.gridModeloVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gridModeloVehiculo.DefaultCellStyle = dataGridViewCellStyle2;
      this.gridModeloVehiculo.Location = new System.Drawing.Point(15, 57);
      this.gridModeloVehiculo.Name = "gridModeloVehiculo";
      this.gridModeloVehiculo.ReadOnly = true;
      this.gridModeloVehiculo.Size = new System.Drawing.Size(745, 303);
      this.gridModeloVehiculo.TabIndex = 3;
      this.gridModeloVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellContentClick);
      this.gridModeloVehiculo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellContentDoubleClick);
      this.gridModeloVehiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloVehiculo_CellDoubleClick);
      // 
      // FrmModeloVehiculoViewModel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 372);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtModelo);
      this.Controls.Add(this.gridModeloVehiculo);
      this.Name = "FrmModeloVehiculoViewModel";
      this.Text = "Buscar Modelo";
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