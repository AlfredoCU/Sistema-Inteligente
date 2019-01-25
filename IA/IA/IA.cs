using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA
{
    public partial class IA : Form
    {
        public IA()
        {
            InitializeComponent();
        }

        private void IA_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbObstaculos_Scroll(object sender, EventArgs e)
        {
            this.lblObstaculos.Text = "Obstáculos: " + tbObstaculos.Value.ToString() + " %";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string mensaje = "Este sistema esta creado por ArdComputer.\n\nProgramador: Alfredo CU\n\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbMapa_Click(object sender, EventArgs e)
        {
            Mapas pantallaMapas = new Mapas();
            pantallaMapas.ShowDialog();
            this.Show();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            Avatar pantallaAvatar = new Avatar();
            pantallaAvatar.ShowDialog();
            this.Show();
        }

        private void chkModoNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModoNocturno.Checked)
            {
                this.BackColor = Color.DimGray;
                this.gbMapa.ForeColor = Color.White;
                this.gbControles.ForeColor = Color.White;
                this.gbOpcSistema.ForeColor = Color.White;
                this.gbOpcGenerales.ForeColor = Color.White;
                this.btnIniciar.ForeColor = Color.Black;
                this.btnPausar.ForeColor = Color.Black;
                this.btnRegresar.ForeColor = Color.Black;
                this.btnInfo.ForeColor = Color.Black;
                this.btnSalir.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
                this.gbMapa.ForeColor = Color.Black;
                this.gbControles.ForeColor = Color.Black;
                this.gbOpcSistema.ForeColor = Color.Black;
                this.gbOpcGenerales.ForeColor = Color.Black;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult responder;
            responder = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(responder == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
