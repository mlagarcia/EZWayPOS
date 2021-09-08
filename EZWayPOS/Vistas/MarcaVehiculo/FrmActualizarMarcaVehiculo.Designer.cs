
namespace EZWayPOS.Vistas.MarcaVehiculo
{
    partial class FrmActualizarMarcaVehiculo
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtId = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.CboFundacion = new System.Windows.Forms.ComboBox();
      this.CboPais = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.TxtMarcaVehiculo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtId);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.CboFundacion);
      this.panel1.Controls.Add(this.CboPais);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.btnEliminar);
      this.panel1.Controls.Add(this.btnActualizar);
      this.panel1.Controls.Add(this.TxtMarcaVehiculo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(299, 252);
      this.panel1.TabIndex = 1;
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(144, 25);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(152, 20);
      this.txtId.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(11, 27);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 18);
      this.label4.TabIndex = 9;
      this.label4.Text = "Id #";
      // 
      // CboFundacion
      // 
      this.CboFundacion.FormattingEnabled = true;
      this.CboFundacion.Location = new System.Drawing.Point(144, 99);
      this.CboFundacion.Name = "CboFundacion";
      this.CboFundacion.Size = new System.Drawing.Size(152, 21);
      this.CboFundacion.TabIndex = 8;
      // 
      // CboPais
      // 
      this.CboPais.FormattingEnabled = true;
      this.CboPais.Location = new System.Drawing.Point(144, 135);
      this.CboPais.Name = "CboPais";
      this.CboPais.Size = new System.Drawing.Size(152, 21);
      this.CboPais.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(11, 134);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Pais";
      // 
      // btnEliminar
      // 
      this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.Location = new System.Drawing.Point(183, 192);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(91, 49);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActualizar.Location = new System.Drawing.Point(88, 192);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(89, 49);
      this.btnActualizar.TabIndex = 4;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // TxtMarcaVehiculo
      // 
      this.TxtMarcaVehiculo.Location = new System.Drawing.Point(144, 51);
      this.TxtMarcaVehiculo.Multiline = true;
      this.TxtMarcaVehiculo.Name = "TxtMarcaVehiculo";
      this.TxtMarcaVehiculo.Size = new System.Drawing.Size(152, 31);
      this.TxtMarcaVehiculo.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(8, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Año de Fundacion";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(8, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Marca Vehiculo";
      // 
      // FrmActualizarMarcaVehiculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(334, 284);
      this.Controls.Add(this.panel1);
      this.Name = "FrmActualizarMarcaVehiculo";
      this.Text = "Actualizar Marca";
      this.Load += new System.EventHandler(this.FrmActualizarMarcaVehiculo_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboFundacion;
        private System.Windows.Forms.ComboBox CboPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox TxtMarcaVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}