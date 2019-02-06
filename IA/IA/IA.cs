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

        // Parte de "Ajustes del Mapa".

        private void IA_Load(object sender, EventArgs e)
        {
            this.cboTam.Items.Clear();
            for (int i = 5; i <= 21; i++)
            {
                this.cboTam.Items.Add(i);
            }
        }

        private void btnCargarMapa_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics grafico = panelMapa.CreateGraphics();
                Pen lapiz = new Pen(Color.Black, 2);
                int tam = Convert.ToInt32(this.cboTam.Text);
                float x = 0f;
                float y = 0f;
                float xLado = ((panelMapa.Width - lapiz.Width) * 1.0f / tam);
                float yLado = ((panelMapa.Height - lapiz.Width) * 1.0f / tam);
                // Vertical
                for (int i = 0; i < tam + 1; i++)
                {
                    grafico.DrawLine(lapiz, x, y, x, yLado * tam); // panelMapa.Height
                    x += xLado;
                }
                // Horizontal
                x = 0f;
                for (int i = 0; i < tam + 1; i++)
                {
                    grafico.DrawLine(lapiz, x, y, xLado * tam, y);
                    y += yLado;
                }
                this.lblX.Text = tam + " x " + tam;
                
            }
            catch // (Exception ex)
            {
                MessageBox.Show("Error al no ingresar el tamaño del mapa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panelMapa.Invalidate();
        }

        // Parte de "Controles".

        private void tbObstaculos_Scroll(object sender, EventArgs e)
        {
            this.lblObstaculos.Text = "Obstáculos: " + tbObstaculos.Value.ToString() + " %";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }

        // Parte de "Opciones del Sistema".

        private void pbMapa_Click(object sender, EventArgs e)
        {
            Casas pantallaMapas = new Casas();
            pantallaMapas.ShowDialog();
            this.Show();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            Avatar pantallaAvatar = new Avatar();
            pantallaAvatar.ShowDialog();
            this.Show();
        }

        // Parte de "Opciones Generales".

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
                this.btnReiniciar.ForeColor = Color.Black;
                this.btnCargarMapa.ForeColor = Color.Black;
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string mensaje = "Este sistema esta creado por ArdComputer.\n\nProgramador: Alfredo CU\n\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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