namespace LigaUno
{
    partial class FrmPartido
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
            this.cboFecha = new System.Windows.Forms.ComboBox();
            this.cboTorneo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodPartido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboElocal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGolesLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTarjetasAmarillasLocal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTarjetasRojasLocal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPendiente = new System.Windows.Forms.RadioButton();
            this.rbnFinalizado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboEvisita = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTarjetasRojasVisita = new System.Windows.Forms.TextBox();
            this.txtGolesVisita = new System.Windows.Forms.TextBox();
            this.txtTarjetasAmarillasVisita = new System.Windows.Forms.TextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFecha
            // 
            this.cboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.Location = new System.Drawing.Point(58, 33);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(153, 21);
            this.cboFecha.TabIndex = 3;
            // 
            // cboTorneo
            // 
            this.cboTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTorneo.FormattingEnabled = true;
            this.cboTorneo.Location = new System.Drawing.Point(58, 6);
            this.cboTorneo.Name = "cboTorneo";
            this.cboTorneo.Size = new System.Drawing.Size(153, 21);
            this.cboTorneo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod.:";
            // 
            // txtCodPartido
            // 
            this.txtCodPartido.Enabled = false;
            this.txtCodPartido.Location = new System.Drawing.Point(58, 60);
            this.txtCodPartido.Name = "txtCodPartido";
            this.txtCodPartido.Size = new System.Drawing.Size(56, 20);
            this.txtCodPartido.TabIndex = 5;
            this.txtCodPartido.Text = "?";
            this.txtCodPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Equipo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboElocal
            // 
            this.cboElocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElocal.FormattingEnabled = true;
            this.cboElocal.Location = new System.Drawing.Point(75, 19);
            this.cboElocal.Name = "cboElocal";
            this.cboElocal.Size = new System.Drawing.Size(121, 21);
            this.cboElocal.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Goles:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Location = new System.Drawing.Point(75, 46);
            this.txtGolesLocal.MaxLength = 2;
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(56, 20);
            this.txtGolesLocal.TabIndex = 3;
            this.txtGolesLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "T. Amarillas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTarjetasAmarillasLocal
            // 
            this.txtTarjetasAmarillasLocal.Location = new System.Drawing.Point(75, 72);
            this.txtTarjetasAmarillasLocal.MaxLength = 2;
            this.txtTarjetasAmarillasLocal.Name = "txtTarjetasAmarillasLocal";
            this.txtTarjetasAmarillasLocal.Size = new System.Drawing.Size(56, 20);
            this.txtTarjetasAmarillasLocal.TabIndex = 5;
            this.txtTarjetasAmarillasLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "T. Rojas:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTarjetasRojasLocal
            // 
            this.txtTarjetasRojasLocal.Location = new System.Drawing.Point(75, 98);
            this.txtTarjetasRojasLocal.MaxLength = 2;
            this.txtTarjetasRojasLocal.Name = "txtTarjetasRojasLocal";
            this.txtTarjetasRojasLocal.Size = new System.Drawing.Size(56, 20);
            this.txtTarjetasRojasLocal.TabIndex = 7;
            this.txtTarjetasRojasLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPendiente);
            this.groupBox1.Controls.Add(this.rbnFinalizado);
            this.groupBox1.Location = new System.Drawing.Point(298, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rbnPendiente
            // 
            this.rbnPendiente.AutoSize = true;
            this.rbnPendiente.Checked = true;
            this.rbnPendiente.Location = new System.Drawing.Point(29, 19);
            this.rbnPendiente.Name = "rbnPendiente";
            this.rbnPendiente.Size = new System.Drawing.Size(73, 17);
            this.rbnPendiente.TabIndex = 0;
            this.rbnPendiente.TabStop = true;
            this.rbnPendiente.Text = "Pendiente";
            this.rbnPendiente.UseVisualStyleBackColor = true;
            // 
            // rbnFinalizado
            // 
            this.rbnFinalizado.AutoSize = true;
            this.rbnFinalizado.Location = new System.Drawing.Point(29, 47);
            this.rbnFinalizado.Name = "rbnFinalizado";
            this.rbnFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rbnFinalizado.TabIndex = 1;
            this.rbnFinalizado.Text = "Finalizado";
            this.rbnFinalizado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboElocal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTarjetasRojasLocal);
            this.groupBox2.Controls.Add(this.txtGolesLocal);
            this.groupBox2.Controls.Add(this.txtTarjetasAmarillasLocal);
            this.groupBox2.Location = new System.Drawing.Point(15, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboEvisita);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTarjetasRojasVisita);
            this.groupBox3.Controls.Add(this.txtGolesVisita);
            this.groupBox3.Controls.Add(this.txtTarjetasAmarillasVisita);
            this.groupBox3.Location = new System.Drawing.Point(228, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 128);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visita";
            // 
            // cboEvisita
            // 
            this.cboEvisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvisita.FormattingEnabled = true;
            this.cboEvisita.Location = new System.Drawing.Point(75, 20);
            this.cboEvisita.Name = "cboEvisita";
            this.cboEvisita.Size = new System.Drawing.Size(121, 21);
            this.cboEvisita.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Equipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Goles:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "T. Amarillas:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "T. Rojas:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTarjetasRojasVisita
            // 
            this.txtTarjetasRojasVisita.Location = new System.Drawing.Point(75, 98);
            this.txtTarjetasRojasVisita.MaxLength = 2;
            this.txtTarjetasRojasVisita.Name = "txtTarjetasRojasVisita";
            this.txtTarjetasRojasVisita.Size = new System.Drawing.Size(56, 20);
            this.txtTarjetasRojasVisita.TabIndex = 7;
            this.txtTarjetasRojasVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGolesVisita
            // 
            this.txtGolesVisita.Location = new System.Drawing.Point(75, 46);
            this.txtGolesVisita.MaxLength = 2;
            this.txtGolesVisita.Name = "txtGolesVisita";
            this.txtGolesVisita.Size = new System.Drawing.Size(56, 20);
            this.txtGolesVisita.TabIndex = 3;
            this.txtGolesVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarjetasAmarillasVisita
            // 
            this.txtTarjetasAmarillasVisita.Location = new System.Drawing.Point(75, 72);
            this.txtTarjetasAmarillasVisita.MaxLength = 2;
            this.txtTarjetasAmarillasVisita.Name = "txtTarjetasAmarillasVisita";
            this.txtTarjetasAmarillasVisita.Size = new System.Drawing.Size(56, 20);
            this.txtTarjetasAmarillasVisita.TabIndex = 5;
            this.txtTarjetasAmarillasVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Image = global::LigaUno.Properties.Resources.exit;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSalir.Location = new System.Drawing.Point(228, 220);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 40);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Image = global::LigaUno.Properties.Resources.save;
            this.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGrabar.Location = new System.Drawing.Point(147, 220);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 40);
            this.cmdGrabar.TabIndex = 9;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // FrmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 267);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodPartido);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.cboTorneo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFecha;
        private System.Windows.Forms.ComboBox cboTorneo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodPartido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboElocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGolesLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTarjetasAmarillasLocal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTarjetasRojasLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnPendiente;
        private System.Windows.Forms.RadioButton rbnFinalizado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboEvisita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTarjetasRojasVisita;
        private System.Windows.Forms.TextBox txtGolesVisita;
        private System.Windows.Forms.TextBox txtTarjetasAmarillasVisita;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdSalir;
    }
}