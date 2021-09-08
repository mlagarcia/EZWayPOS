
namespace EZWayPOS.Vistas.TipoMotor
{
    partial class FrmTipoMotor
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtTipoMotor = new System.Windows.Forms.TextBox();
      this.TxtDetalleAdicional = new System.Windows.Forms.TextBox();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(10, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "TipoMotor";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(10, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Detalle Adicional";
      // 
      // TxtTipoMotor
      // 
      this.TxtTipoMotor.Location = new System.Drawing.Point(141, 36);
      this.TxtTipoMotor.Name = "TxtTipoMotor";
      this.TxtTipoMotor.Size = new System.Drawing.Size(144, 20);
      this.TxtTipoMotor.TabIndex = 2;
      // 
      // TxtDetalleAdicional
      // 
      this.TxtDetalleAdicional.Location = new System.Drawing.Point(141, 83);
      this.TxtDetalleAdicional.Name = "TxtDetalleAdicional";
      this.TxtDetalleAdicional.Size = new System.Drawing.Size(144, 20);
      this.TxtDetalleAdicional.TabIndex = 3;
      // 
      // btnAgregar
      // 
      this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgregar.Location = new System.Drawing.Point(98, 127);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(77, 39);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalir.Location = new System.Drawing.Point(192, 126);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(95, 38);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // FrmTipoMotor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 198);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.TxtDetalleAdicional);
      this.Controls.Add(this.TxtTipoMotor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FrmTipoMotor";
      this.Text = "FrmTipoMotor";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTipoMotor;
        private System.Windows.Forms.TextBox TxtDetalleAdicional;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}