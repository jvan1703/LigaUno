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
    public partial class FrmPartido : Form
    {

        private void Initialize()
        {
            llenarCboTorneo();
            llenarCboFecha();
            llenarCboElocal();
            llenarCboEvisita();
        }

        public FrmPartido(int p_codtorneo, int p_codfecha)
        {
            InitializeComponent();
            Initialize();
            cboTorneo.SelectedValue = p_codtorneo;
            cboFecha.SelectedValue = p_codfecha;
        }

        public FrmPartido(int p_codtorneo, int p_codfecha, int p_codpartido)
        {
            InitializeComponent();
            Initialize();
            cboTorneo.SelectedValue = p_codtorneo;
            cboFecha.SelectedValue = p_codfecha;
            txtCodPartido.Text = p_codpartido.ToString();
            CargarForm();
        }

        private void CargarForm() {

            Partido partido = PartidoController.Select_by_codtorneo_codfecha_codpartido( Convert.ToInt16(cboTorneo.SelectedValue), Convert.ToInt16(cboFecha.SelectedValue), H.CInt(txtCodPartido.Text));
            cboElocal.SelectedValue = partido.codequipo_local;
            cboEvisita.SelectedValue = partido.codequipo_visita;
            txtGolesLocal.Text = partido.goles_local.ToString();
            txtGolesVisita.Text = partido.goles_visita.ToString();
            rbnFinalizado.Checked = (partido.st_terminado == 1);
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
        private void llenarCboElocal()
        {
            cboElocal.DataSource = EquipoController.select();
            cboElocal.DisplayMember = "nombre";
            cboElocal.ValueMember = "codequipo";
        }
        private void llenarCboEvisita()
        {
            cboEvisita.DataSource = EquipoController.select();
            cboEvisita.DisplayMember = "nombre";
            cboEvisita.ValueMember = "codequipo";
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            Partido partido = new Partido();
            partido.codtorneo = Convert.ToInt16(cboTorneo.SelectedValue);
            partido.codfecha = Convert.ToInt16(cboFecha.SelectedValue);
            partido.codpartido = H.CInt(txtCodPartido.Text);
            partido.codequipo_local = Convert.ToInt16(cboElocal.SelectedValue);
            partido.codequipo_visita = Convert.ToInt16(cboEvisita.SelectedValue);
            partido.goles_local = H.CInt(txtGolesLocal.Text);
            partido.goles_visita = H.CInt(txtGolesVisita.Text);
            partido.tarjetas_amarillas_local = H.CInt(txtTarjetasAmarillasLocal.Text);
            partido.tarjetas_amarillas_visita = H.CInt(txtTarjetasAmarillasVisita.Text);
            partido.tarjetas_rojas_local = H.CInt(txtTarjetasRojasLocal.Text);
            partido.tarjetas_rojas_visita = H.CInt(txtTarjetasRojasVisita.Text);
            partido.st_terminado = (rbnFinalizado.Checked) ? 1 : 0;
            if (partido.goles_local > partido.goles_visita)
            {
                partido.puntos_local = 3;
                partido.puntos_visita = 0;
            }
            else if (partido.goles_local < partido.goles_visita)
            {
                partido.puntos_local = 0;
                partido.puntos_visita = 3;
            }
            else
            {
                partido.puntos_local = 1;
                partido.puntos_visita = 1;
            }

            if (PartidoController.Insert_update(partido))
            {
                //MessageBox.Show("Se grabó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
