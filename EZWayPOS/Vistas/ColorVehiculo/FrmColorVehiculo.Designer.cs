
namespace EZWayPOS.Vistas.ColorVehiculo
{
    partial class Color_Vehiculo
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
      this.SelectedColor = new System.Windows.Forms.Panel();
      this.btnSeleccionar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.TxtNombreColor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.SelectedColor);
      this.panel1.Controls.Add(this.btnSeleccionar);
      this.panel1.Controls.Add(this.btnSalir);
      this.panel1.Controls.Add(this.btnAgregar);
      this.panel1.Controls.Add(this.TxtNombreColor);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(24, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(349, 216);
      this.panel1.TabIndex = 0;
      // 
      // SelectedColor
      // 
      this.SelectedColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.SelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SelectedColor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.SelectedColor.Location = new System.Drawing.Point(267, 79);
      this.SelectedColor.Name = "SelectedColor";
      this.SelectedColor.Size = new System.Drawing.Size(39, 36);
      this.SelectedColor.TabIndex = 7;
      // 
      // btnSeleccionar
      // 
      this.btnSeleccionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSeleccionar.Location = new System.Drawing.Point(127, 79);
      this.btnSeleccionar.Name = "btnSeleccionar";
      this.btnSeleccionar.Size = new System.Drawing.Size(134, 36);
      this.btnSeleccionar.TabIndex = 6;
      this.btnSeleccionar.Text = "Seleccionar";
      this.btnSeleccionar.UseVisualStyleBackColor = true;
      this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalir.Location = new System.Drawing.Point(231, 139);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 51);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnsalir_Click);
      // 
      // btnAgregar
      // 
      this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAgregar.Location = new System.Drawing.Point(127, 140);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(73, 49);
      this.btnAgregar.TabIndex = 4;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // TxtNombreColor
      // 
      this.TxtNombreColor.Location = new System.Drawing.Point(127, 31);
      this.TxtNombreColor.Multiline = true;
      this.TxtNombreColor.Name = "TxtNombreColor";
      this.TxtNombreColor.Size = new System.Drawing.Size(179, 26);
      this.TxtNombreColor.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(33, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Color";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(15, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre Color";
      // 
      // Color_Vehiculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(383, 240);
      this.Controls.Add(this.panel1);
      this.Name = "Color_Vehiculo";
      this.Text = "Color_Vehiculo";
      this.Load += new System.EventHandler(this.Color_Vehiculo_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TxtNombreColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel SelectedColor;
    }
}