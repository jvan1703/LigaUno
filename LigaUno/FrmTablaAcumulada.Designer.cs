namespace LigaUno
{
    partial class FrmTablaAcumulada
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidos_jugados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidos_ganados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidos_empatados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidos_perdidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles_anotados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles_recibidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntos_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.nombre_equipo,
            this.partidos_jugados,
            this.partidos_ganados,
            this.partidos_empatados,
            this.partidos_perdidos,
            this.goles_anotados,
            this.goles_recibidos,
            this.goles_totales,
            this.puntos_totales});
            this.dataGridView.Location = new System.Drawing.Point(12, 38);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(697, 463);
            this.dataGridView.TabIndex = 0;
            // 
            // posicion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.posicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.posicion.HeaderText = "Pos.";
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            this.posicion.Width = 50;
            // 
            // nombre_equipo
            // 
            this.nombre_equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_equipo.HeaderText = "Equipo";
            this.nombre_equipo.Name = "nombre_equipo";
            this.nombre_equipo.ReadOnly = true;
            // 
            // partidos_jugados
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.partidos_jugados.DefaultCellStyle = dataGridViewCellStyle3;
            this.partidos_jugados.HeaderText = "PJ";
            this.partidos_jugados.Name = "partidos_jugados";
            this.partidos_jugados.ReadOnly = true;
            this.partidos_jugados.Width = 50;
            // 
            // partidos_ganados
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.partidos_ganados.DefaultCellStyle = dataGridViewCellStyle4;
            this.partidos_ganados.HeaderText = "PG";
            this.partidos_ganados.Name = "partidos_ganados";
            this.partidos_ganados.ReadOnly = true;
            this.partidos_ganados.Width = 50;
            // 
            // partidos_empatados
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.partidos_empatados.DefaultCellStyle = dataGridViewCellStyle5;
            this.partidos_empatados.HeaderText = "PE";
            this.partidos_empatados.Name = "partidos_empatados";
            this.partidos_empatados.ReadOnly = true;
            this.partidos_empatados.Width = 50;
            // 
            // partidos_perdidos
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.partidos_perdidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.partidos_perdidos.HeaderText = "PP";
            this.partidos_perdidos.Name = "partidos_perdidos";
            this.partidos_perdidos.ReadOnly = true;
            this.partidos_perdidos.Width = 50;
            // 
            // goles_anotados
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.goles_anotados.DefaultCellStyle = dataGridViewCellStyle7;
            this.goles_anotados.HeaderText = "GA";
            this.goles_anotados.Name = "goles_anotados";
            this.goles_anotados.ReadOnly = true;
            this.goles_anotados.Width = 50;
            // 
            // goles_recibidos
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.goles_recibidos.DefaultCellStyle = dataGridViewCellStyle8;
            this.goles_recibidos.HeaderText = "GR";
            this.goles_recibidos.Name = "goles_recibidos";
            this.goles_recibidos.ReadOnly = true;
            this.goles_recibidos.Width = 50;
            // 
            // goles_totales
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.goles_totales.DefaultCellStyle = dataGridViewCellStyle9;
            this.goles_totales.HeaderText = "DG";
            this.goles_totales.Name = "goles_totales";
            this.goles_totales.ReadOnly = true;
            this.goles_totales.Width = 50;
            // 
            // puntos_totales
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.puntos_totales.DefaultCellStyle = dataGridViewCellStyle10;
            this.puntos_totales.HeaderText = "Puntos";
            this.puntos_totales.Name = "puntos_totales";
            this.puntos_totales.ReadOnly = true;
            this.puntos_totales.Width = 50;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Location = new System.Drawing.Point(634, 9);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartidos.Location = new System.Drawing.Point(12, 9);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(75, 23);
            this.btnPartidos.TabIndex = 3;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // FrmTablaAcumulada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 513);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmTablaAcumulada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla Acumulada";
            this.Load += new System.EventHandler(this.FrmTablaAcumulada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidos_jugados;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidos_ganados;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidos_empatados;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidos_perdidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles_anotados;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles_recibidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntos_totales;
        private System.Windows.Forms.Button btnPartidos;
    }
}

