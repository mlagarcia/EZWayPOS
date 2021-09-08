
namespace EZWayPOS.Vistas.ModeloVehiculo
{
    partial class FrmActualizarModeloVehiculo
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
      this.CboMarca = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.CboCuerpo = new System.Windows.Forms.ComboBox();
      this.CboAnioLanzamiento = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.TxtModeloVehiculo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CboMarca);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtId);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.CboCuerpo);
      this.panel1.Controls.Add(this.CboAnioLanzamiento);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.btnActualizar);
      this.panel1.Controls.Add(this.TxtModeloVehiculo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(319, 262);
      this.panel1.TabIndex = 2;
      // 
      // CboMarca
      // 
      this.CboMarca.FormattingEnabled = true;
      this.CboMarca.Location = new System.Drawing.Point(156, 97);
      this.CboMarca.Name = "CboMarca";
      this.CboMarca.Size = new System.Drawing.Size(160, 21);
      this.CboMarca.TabIndex = 12;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(3, 97);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(52, 18);
      this.label5.TabIndex = 11;
      this.label5.Text = "Marca";
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(156, 24);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(160, 20);
      this.txtId.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(3, 26);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 18);
      this.label4.TabIndex = 9;
      this.label4.Text = "Id #";
      // 
      // CboCuerpo
      // 
      this.CboCuerpo.FormattingEnabled = true;
      this.CboCuerpo.Location = new System.Drawing.Point(156, 129);
      this.CboCuerpo.Name = "CboCuerpo";
      this.CboCuerpo.Size = new System.Drawing.Size(160, 21);
      this.CboCuerpo.TabIndex = 8;
      this.CboCuerpo.SelectedIndexChanged += new System.EventHandler(this.CboCuerpo_SelectedIndexChanged);
      // 
      // CboAnioLanzamiento
      // 
      this.CboAnioLanzamiento.FormattingEnabled = true;
      this.CboAnioLanzamiento.Location = new System.Drawing.Point(156, 164);
      this.CboAnioLanzamiento.Name = "CboAnioLanzamiento";
      this.CboAnioLanzamiento.Size = new System.Drawing.Size(160, 21);
      this.CboAnioLanzamiento.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 129);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(123, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Cuerpo Vehiculo";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(218, 191);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(98, 49);
      this.button2.TabIndex = 5;
      this.button2.Text = "Eliminar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActualizar.Location = new System.Drawing.Point(113, 191);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(86, 49);
      this.btnActualizar.TabIndex = 4;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // TxtModeloVehiculo
      // 
      this.TxtModeloVehiculo.Location = new System.Drawing.Point(156, 57);
      this.TxtModeloVehiculo.Multiline = true;
      this.TxtModeloVehiculo.Name = "TxtModeloVehiculo";
      this.TxtModeloVehiculo.Size = new System.Drawing.Size(160, 31);
      this.TxtModeloVehiculo.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 163);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(151, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Año de Lanzamiento";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(2, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(123, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Modelo Vehiculo";
      // 
      // FrmActualizarModeloVehiculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(343, 286);
      this.Controls.Add(this.panel1);
      this.Name = "FrmActualizarModeloVehiculo";
      this.Text = "FrmActualizarModeloVehiculo";
      this.Load += new System.EventHandler(this.FrmActualizarModeloVehiculo_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboCuerpo;
        private System.Windows.Forms.ComboBox CboAnioLanzamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox TxtModeloVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.Label label5;
    }
}