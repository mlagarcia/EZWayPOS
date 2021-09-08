
namespace EZWayPOS.Vistas.TipoVehiculo
{
    partial class FrmTipoVehiculo
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
      this.TxtDescripcion = new System.Windows.Forms.TextBox();
      this.TxtTipoVehiculo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.TxtDescripcion);
      this.panel1.Controls.Add(this.TxtTipoVehiculo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(315, 226);
      this.panel1.TabIndex = 6;
      // 
      // TxtDescripcion
      // 
      this.TxtDescripcion.Location = new System.Drawing.Point(132, 81);
      this.TxtDescripcion.Multiline = true;
      this.TxtDescripcion.Name = "TxtDescripcion";
      this.TxtDescripcion.Size = new System.Drawing.Size(170, 45);
      this.TxtDescripcion.TabIndex = 11;
      // 
      // TxtTipoVehiculo
      // 
      this.TxtTipoVehiculo.Location = new System.Drawing.Point(132, 45);
      this.TxtTipoVehiculo.Name = "TxtTipoVehiculo";
      this.TxtTipoVehiculo.Size = new System.Drawing.Size(170, 20);
      this.TxtTipoVehiculo.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 18);
      this.label2.TabIndex = 9;
      this.label2.Text = "Descripcion";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(123, 18);
      this.label1.TabIndex = 8;
      this.label1.Text = "Tipo de Vehiculo";
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(227, 151);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 42);
      this.button2.TabIndex = 7;
      this.button2.Text = "Salir";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(132, 151);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 42);
      this.button1.TabIndex = 6;
      this.button1.Text = "Guardar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // FrmTipoVehiculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(339, 250);
      this.Controls.Add(this.panel1);
      this.Name = "FrmTipoVehiculo";
      this.Text = "FrmTipoVehiculo";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtTipoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}