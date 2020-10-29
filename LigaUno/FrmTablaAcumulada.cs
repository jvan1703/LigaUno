using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaUno.controller;
using LigaUno.model;

namespace LigaUno
{
    public partial class FrmTablaAcumulada : Form
    {
        public FrmTablaAcumulada()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (EquipoController.Calcular_tabla_acumulada())
            {
                List<Equipo> equipos = EquipoController.select_for_tabla_acumulada();

                dataGridView.Rows.Clear();
                foreach (Equipo equipo in equipos)
                {
                    var index = dataGridView.Rows.Add();
                    dataGridView.Rows[index].Cells[posicion.Name].Value = index + 1;
                    dataGridView.Rows[index].Cells[nombre_equipo.Name].Value = equipo.nombre;
                    dataGridView.Rows[index].Cells[partidos_jugados.Name].Value = equipo.partidos_totales;
                    dataGridView.Rows[index].Cells[partidos_ganados.Name].Value = equipo.partidos_ganados;
                    dataGridView.Rows[index].Cells[partidos_empatados.Name].Value = equipo.partidos_empatados;
                    dataGridView.Rows[index].Cells[partidos_perdidos.Name].Value = equipo.partidos_perdidos;
                    dataGridView.Rows[index].Cells[goles_anotados.Name].Value = equipo.goles_anotados;
                    dataGridView.Rows[index].Cells[goles_recibidos.Name].Value = equipo.goles_recibidos;
                    dataGridView.Rows[index].Cells[goles_totales.Name].Value = equipo.goles_totales;
                    dataGridView.Rows[index].Cells[puntos_totales.Name].Value = equipo.puntos_totales;
                    if(index > 16) dataGridView.Rows[index].DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }

        }

        private void FrmTablaAcumulada_Load(object sender, EventArgs e)
        {
            btnCargar_Click(null, null);
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            FrmListaPartidos frm = new FrmListaPartidos();
            frm.ShowDialog();
        }
    }
}
