﻿namespace AbstractFactoryAutomovil
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRenault = new System.Windows.Forms.RadioButton();
            this.radMazda = new System.Windows.Forms.RadioButton();
            this.radKia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPartes = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.lstPartes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 226);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMazda);
            this.groupBox1.Controls.Add(this.radRenault);
            this.groupBox1.Controls.Add(this.radKia);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // radRenault
            // 
            this.radRenault.AutoSize = true;
            this.radRenault.Checked = true;
            this.radRenault.Location = new System.Drawing.Point(40, 28);
            this.radRenault.Name = "radRenault";
            this.radRenault.Size = new System.Drawing.Size(40, 17);
            this.radRenault.TabIndex = 0;
            this.radRenault.TabStop = true;
            this.radRenault.Text = "Renault";
            this.radRenault.UseVisualStyleBackColor = true;
            // 
            // radMazda
            // 
            this.radMazda.AutoSize = true;
            this.radMazda.Location = new System.Drawing.Point(120, 28);
            this.radMazda.Name = "radMazda";
            this.radMazda.Size = new System.Drawing.Size(50, 17);
            this.radMazda.TabIndex = 1;
            this.radMazda.Text = "Mazda";
            this.radMazda.UseVisualStyleBackColor = true;
            // 
            // radKia
            // 
            this.radKia.AutoSize = true;
            this.radKia.Location = new System.Drawing.Point(200, 28);
            this.radKia.Name = "radKia";
            this.radKia.Size = new System.Drawing.Size(1, 17);
            this.radKia.TabIndex = 1;
            this.radKia.Text = "Kia";
            this.radKia.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // lstPartes
            // 
            this.lstPartes.FormattingEnabled = true;
            this.lstPartes.Items.AddRange(new object[] {
            "Auto",
            "Motor",
            "Carroceria"});
            this.lstPartes.Location = new System.Drawing.Point(112, 103);
            this.lstPartes.Name = "lstPartes";
            this.lstPartes.Size = new System.Drawing.Size(121, 21);
            this.lstPartes.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(97, 159);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox lstPartes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMazda;
        private System.Windows.Forms.RadioButton radRenault;
        private System.Windows.Forms.RadioButton radKia;
    }
}

