namespace TrabajoNew
{
    partial class JefeForm
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnosAntiguedad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.lblMovilidad = new System.Windows.Forms.Label();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblSueldoFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(96, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 32);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(28, 36);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(258, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(135, 65);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(151, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Gerente",
            "Subgerente"});
            this.cbCargo.Location = new System.Drawing.Point(135, 128);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(151, 21);
            this.cbCargo.TabIndex = 3;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Contabilidad",
            "Planificación"});
            this.cbArea.Location = new System.Drawing.Point(135, 164);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(151, 21);
            this.cbArea.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // txtAnosAntiguedad
            // 
            this.txtAnosAntiguedad.Location = new System.Drawing.Point(135, 95);
            this.txtAnosAntiguedad.Name = "txtAnosAntiguedad";
            this.txtAnosAntiguedad.Size = new System.Drawing.Size(151, 20);
            this.txtAnosAntiguedad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Años de Antigüedad";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(30, 264);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(27, 13);
            this.lblSueldoBase.TabIndex = 11;
            this.lblSueldoBase.Text = "N/A";
            // 
            // lblMovilidad
            // 
            this.lblMovilidad.AutoSize = true;
            this.lblMovilidad.Location = new System.Drawing.Point(30, 294);
            this.lblMovilidad.Name = "lblMovilidad";
            this.lblMovilidad.Size = new System.Drawing.Size(27, 13);
            this.lblMovilidad.TabIndex = 12;
            this.lblMovilidad.Text = "N/A";
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(28, 325);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(27, 13);
            this.lblBonificacion.TabIndex = 13;
            this.lblBonificacion.Text = "N/A";
            // 
            // lblSueldoFinal
            // 
            this.lblSueldoFinal.AutoSize = true;
            this.lblSueldoFinal.Location = new System.Drawing.Point(28, 353);
            this.lblSueldoFinal.Name = "lblSueldoFinal";
            this.lblSueldoFinal.Size = new System.Drawing.Size(27, 13);
            this.lblSueldoFinal.TabIndex = 14;
            this.lblSueldoFinal.Text = "N/A";
            // 
            // JefeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 392);
            this.Controls.Add(this.lblSueldoFinal);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.lblMovilidad);
            this.Controls.Add(this.lblSueldoBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnosAntiguedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnCalcular);
            this.Name = "JefeForm";
            this.Text = "JefeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnosAntiguedad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.Label lblMovilidad;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblSueldoFinal;
    }
}