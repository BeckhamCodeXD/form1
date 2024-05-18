namespace TrabajoNew
{
    partial class ArquitectoForm
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
            this.cbCondicionContrato = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbTipoActividad = new System.Windows.Forms.ComboBox();
            this.cbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCondicionContrato
            // 
            this.cbCondicionContrato.FormattingEnabled = true;
            this.cbCondicionContrato.Items.AddRange(new object[] {
            "Estable",
            "Contratado"});
            this.cbCondicionContrato.Location = new System.Drawing.Point(127, 143);
            this.cbCondicionContrato.Name = "cbCondicionContrato";
            this.cbCondicionContrato.Size = new System.Drawing.Size(121, 21);
            this.cbCondicionContrato.TabIndex = 0;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Estructuras",
            "Recursos",
            "Hidricos"});
            this.cbEspecialidad.Location = new System.Drawing.Point(127, 183);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidad.TabIndex = 1;
            // 
            // cbTipoActividad
            // 
            this.cbTipoActividad.FormattingEnabled = true;
            this.cbTipoActividad.Items.AddRange(new object[] {
            "Supervisión de Obras",
            "Supervisión de Vías"});
            this.cbTipoActividad.Location = new System.Drawing.Point(127, 217);
            this.cbTipoActividad.Name = "cbTipoActividad";
            this.cbTipoActividad.Size = new System.Drawing.Size(121, 21);
            this.cbTipoActividad.TabIndex = 2;
            // 
            // cbTipoAfiliacion
            // 
            this.cbTipoAfiliacion.FormattingEnabled = true;
            this.cbTipoAfiliacion.Items.AddRange(new object[] {
            "AFP",
            "SNP"});
            this.cbTipoAfiliacion.Location = new System.Drawing.Point(127, 257);
            this.cbTipoAfiliacion.Name = "cbTipoAfiliacion";
            this.cbTipoAfiliacion.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAfiliacion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Afiliación";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(126, 307);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(122, 23);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(30, 98);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(226, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CODIGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMBRES";
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(302, 42);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(27, 13);
            this.lblSueldoBase.TabIndex = 13;
            this.lblSueldoBase.Text = "N/A";
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(302, 71);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(27, 13);
            this.lblBonificacion.TabIndex = 14;
            this.lblBonificacion.Text = "N/A";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(302, 107);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(27, 13);
            this.lblDescuento.TabIndex = 15;
            this.lblDescuento.Text = "N/A";
            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(302, 143);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(27, 13);
            this.lblSueldoBruto.TabIndex = 16;
            this.lblSueldoBruto.Text = "N/A";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(302, 183);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(27, 13);
            this.lblSueldoNeto.TabIndex = 17;
            this.lblSueldoNeto.Text = "N/A";
            // 
            // ArquitectoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 353);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblSueldoBruto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.lblSueldoBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoAfiliacion);
            this.Controls.Add(this.cbTipoActividad);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.cbCondicionContrato);
            this.Name = "ArquitectoForm";
            this.Text = "ArquitectoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCondicionContrato;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbTipoActividad;
        private System.Windows.Forms.ComboBox cbTipoAfiliacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.Label lblSueldoNeto;
    }
}