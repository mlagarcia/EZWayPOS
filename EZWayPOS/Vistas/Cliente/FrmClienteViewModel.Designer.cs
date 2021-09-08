
namespace EZWayPOS.Vistas.Cliente
{
    partial class FrmClienteViewModel
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
      this.txtCliente = new System.Windows.Forms.TextBox();
      this.gridCliente = new System.Windows.Forms.DataGridView();
      this.CboTipoBusqueda = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
      this.SuspendLayout();
      // 
      // btnBuscar
      // 
      this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.Location = new System.Drawing.Point(365, 18);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 30);
      this.btnBuscar.TabIndex = 5;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtCliente
      // 
      this.txtCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCliente.Location = new System.Drawing.Point(12, 20);
      this.txtCliente.Name = "txtCliente";
      this.txtCliente.Size = new System.Drawing.Size(228, 26);
      this.txtCliente.TabIndex = 4;
      // 
      // gridCliente
      // 
      this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridCliente.Location = new System.Drawing.Point(12, 66);
      this.gridCliente.Name = "gridCliente";
      this.gridCliente.ReadOnly = true;
      this.gridCliente.Size = new System.Drawing.Size(428, 277);
      this.gridCliente.TabIndex = 3;
      this.gridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellDoubleClick);
      // 
      // CboTipoBusqueda
      // 
      this.CboTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CboTipoBusqueda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CboTipoBusqueda.FormattingEnabled = true;
      this.CboTipoBusqueda.Location = new System.Drawing.Point(246, 19);
      this.CboTipoBusqueda.Name = "CboTipoBusqueda";
      this.CboTipoBusqueda.Size = new System.Drawing.Size(113, 28);
      this.CboTipoBusqueda.TabIndex = 6;
      // 
      // FrmClienteViewModel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 362);
      this.Controls.Add(this.CboTipoBusqueda);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtCliente);
      this.Controls.Add(this.gridCliente);
      this.Name = "FrmClienteViewModel";
      this.Text = "FrmClienteViewModel";
      this.Load += new System.EventHandler(this.FrmClienteViewModel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.ComboBox CboTipoBusqueda;
    }
}