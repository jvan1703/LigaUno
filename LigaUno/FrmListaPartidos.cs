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
using LigaUno.utils;

namespace LigaUno
{
    public partial class FrmListaPartidos : Form
    {
        public FrmListaPartidos()
        {
            InitializeComponent();
            llenarCboTorneo();
            llenarCboFecha();
            llenarDataGridView();
        }

        private void llenarCboTorneo()
        {
            cboTorneo.DataSource = TorneoController.Select();
            cboTorneo.DisplayMember = "nombre";
            cboTorneo.ValueMember = "codtorneo";
        }

        private void llenarCboFecha()
        {
            cboFecha.DataSource = FechaController.Select_by_codtorneo(Convert.ToInt16(cboTorneo.SelectedValue));
            cboFecha.DisplayMember = "descripcion";
            cboFecha.ValueMember = "codfecha";
        }

        private void llenarDataGridView()
        {
            List<Partido> partidos = PartidoController.Select_by_codtorneo_codfecha(Convert.ToInt16(cboTorneo.SelectedValue), Convert.ToInt16(cboFecha.SelectedValue));

            dataGridView.Rows.Clear();

            if (partidos == null) return;

            foreach (Partido partido in partidos)
            {
                var index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[codpartido.Name].Value = partido.codpartido;
                dataGridView.Rows[index].Cells[equipo_local.Name].Value = partido.elocal.nombre;
                dataGridView.Rows[index].Cells[equipo_visita.Name].Value = partido.evisita.nombre;
                dataGridView.Rows[index].Cells[resultado.Name].Value = (partido.st_terminado == 1) ? partido.goles_local + "      |      " + partido.goles_visita : "-";
                dataGridView.Rows[index].Cells[estado.Name].Value = (partido.st_terminado == 1) ? "FINALIZADO" : "PENDIENTE";
            }

        }

        private void cboTorneo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarCboFecha();
            llenarDataGridView();
        }

        private void cboFecha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPartido frm = new FrmPartido(Convert.ToInt16(cboTorneo.SelectedValue), Convert.ToInt16(cboFecha.SelectedValue));
            frm.ShowDialog();
            llenarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 0) return;
            FrmPartido frm = new FrmPartido(Convert.ToInt16(cboTorneo.SelectedValue), Convert.ToInt16(cboFecha.SelectedValue), Convert.ToInt16(dataGridView.CurrentRow.Cells[codpartido.Index].Value));
            frm.ShowDialog();
            llenarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 0) return;
            if (MessageBox.Show("¿Seguro de eliminar el partido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            PartidoController.Delete(new Partido(Convert.ToInt16(cboTorneo.SelectedValue), Convert.ToInt16(cboFecha.SelectedValue), Convert.ToInt16(dataGridView.CurrentRow.Cells[codpartido.Index].Value)));
            llenarDataGridView();
        }
    }

}
