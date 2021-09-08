
namespace EZWayPOS.Vistas.MarcaVehiculo
{
    partial class FrmMarcaVehiculo
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
      this.CboFundacion = new System.Windows.Forms.ComboBox();
      this.CboPais = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.TxtMarcaVehiculo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CboFundacion);
      this.panel1.Controls.Add(this.CboPais);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.btnAgregar);
      this.panel1.Controls.Add(this.TxtMarcaVehiculo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(11, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(354, 252);
      this.panel1.TabIndex = 0;
      // 
      // CboFundacion
      // 
      this.CboFundacion.FormattingEnabled = true;
      this.CboFundacion.Location = new System.Drawing.Point(149, 85);
      this.CboFundacion.Name = "CboFundacion";
      this.CboFundacion.Size = new System.Drawing.Size(152, 21);
      this.CboFundacion.TabIndex = 8;
      // 
      // CboPais
      // 
      this.CboPais.FormattingEnabled = true;
      this.CboPais.Location = new System.Drawing.Point(149, 125);
      this.CboPais.Name = "CboPais";
      this.CboPais.Size = new System.Drawing.Size(152, 21);
      this.CboPais.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(11, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Pais";
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(183, 183);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(91, 49);
      this.button2.TabIndex = 5;
      this.button2.Text = "Salir";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgregar.Location = new System.Drawing.Point(88, 183);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(89, 49);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
      // 
      // TxtMarcaVehiculo
      // 
      this.TxtMarcaVehiculo.Location = new System.Drawing.Point(149, 37);
      this.TxtMarcaVehiculo.Multiline = true;
      this.TxtMarcaVehiculo.Name = "TxtMarcaVehiculo";
      this.TxtMarcaVehiculo.Size = new System.Drawing.Size(152, 31);
      this.TxtMarcaVehiculo.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(8, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Año de Fundacion";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(11, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Marca Vehiculo";
      // 
      // FrmMarcaVehiculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(377, 278);
      this.Controls.Add(this.panel1);
      this.Name = "FrmMarcaVehiculo";
      this.Text = "Agregar Marca";
      this.Load += new System.EventHandler(this.FrmMarcaVehiculo_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TxtMarcaVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboFundacion;
    }
}