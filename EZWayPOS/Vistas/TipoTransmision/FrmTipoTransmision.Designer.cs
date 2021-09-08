
namespace EZWayPOS.Vistas
{
    partial class FrmTipoTransmision
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
      this.TxtTipoTransmision = new System.Windows.Forms.TextBox();
      this.TxtDetalleAdicional = new System.Windows.Forms.TextBox();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(9, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tipo Transmision";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(7, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Detalle Adicional";
      // 
      // TxtTipoTransmision
      // 
      this.TxtTipoTransmision.Location = new System.Drawing.Point(138, 24);
      this.TxtTipoTransmision.Name = "TxtTipoTransmision";
      this.TxtTipoTransmision.Size = new System.Drawing.Size(150, 20);
      this.TxtTipoTransmision.TabIndex = 2;
      // 
      // TxtDetalleAdicional
      // 
      this.TxtDetalleAdicional.Location = new System.Drawing.Point(138, 84);
      this.TxtDetalleAdicional.Name = "TxtDetalleAdicional";
      this.TxtDetalleAdicional.Size = new System.Drawing.Size(152, 20);
      this.TxtDetalleAdicional.TabIndex = 3;
      // 
      // btnAgregar
      // 
      this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgregar.Location = new System.Drawing.Point(97, 126);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(85, 55);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(188, 126);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(102, 54);
      this.button2.TabIndex = 5;
      this.button2.Text = "Salir";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // FrmTipoTransmision
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(297, 216);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.TxtDetalleAdicional);
      this.Controls.Add(this.TxtTipoTransmision);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FrmTipoTransmision";
      this.Text = "FrmTipoTransmision";
      this.Load += new System.EventHandler(this.FrmTipoTransmision_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTipoTransmision;
        private System.Windows.Forms.TextBox TxtDetalleAdicional;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
    }
}