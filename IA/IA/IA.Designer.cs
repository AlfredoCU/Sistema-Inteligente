namespace IA
{
    partial class IA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IA));
            this.gbMapa = new System.Windows.Forms.GroupBox();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblObstaculos = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.tbObstaculos = new System.Windows.Forms.TrackBar();
            this.lblX = new System.Windows.Forms.Label();
            this.lblTam = new System.Windows.Forms.Label();
            this.cboTam = new System.Windows.Forms.ComboBox();
            this.btnCargarMapa = new System.Windows.Forms.Button();
            this.gbOpcSistema = new System.Windows.Forms.GroupBox();
            this.pbAvatars = new System.Windows.Forms.PictureBox();
            this.pbCasas = new System.Windows.Forms.PictureBox();
            this.gbOpcGenerales = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.chkModoNocturno = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbAjustesMapa = new System.Windows.Forms.GroupBox();
            this.gbMapa.SuspendLayout();
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObstaculos)).BeginInit();
            this.gbOpcSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasas)).BeginInit();
            this.gbOpcGenerales.SuspendLayout();
            this.gbAjustesMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMapa
            // 
            this.gbMapa.Controls.Add(this.panelMapa);
            this.gbMapa.Location = new System.Drawing.Point(10, 11);
            this.gbMapa.Margin = new System.Windows.Forms.Padding(2);
            this.gbMapa.Name = "gbMapa";
            this.gbMapa.Padding = new System.Windows.Forms.Padding(2);
            this.gbMapa.Size = new System.Drawing.Size(578, 544);
            this.gbMapa.TabIndex = 0;
            this.gbMapa.TabStop = false;
            this.gbMapa.Text = "Mapa";
            // 
            // panelMapa
            // 
            this.panelMapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMapa.BackgroundImage")));
            this.panelMapa.Location = new System.Drawing.Point(5, 21);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(568, 518);
            this.panelMapa.TabIndex = 0;
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnIniciar);
            this.gbControles.Controls.Add(this.lblObstaculos);
            this.gbControles.Controls.Add(this.btnReiniciar);
            this.gbControles.Controls.Add(this.tbObstaculos);
            this.gbControles.Location = new System.Drawing.Point(614, 95);
            this.gbControles.Margin = new System.Windows.Forms.Padding(2);
            this.gbControles.Name = "gbControles";
            this.gbControles.Padding = new System.Windows.Forms.Padding(2);
            this.gbControles.Size = new System.Drawing.Size(538, 190);
            this.gbControles.TabIndex = 1;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(293, 120);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(162, 40);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblObstaculos
            // 
            this.lblObstaculos.AutoSize = true;
            this.lblObstaculos.Location = new System.Drawing.Point(16, 90);
            this.lblObstaculos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObstaculos.Name = "lblObstaculos";
            this.lblObstaculos.Size = new System.Drawing.Size(88, 17);
            this.lblObstaculos.TabIndex = 1;
            this.lblObstaculos.Text = "Obstáculos: ";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Image")));
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReiniciar.Location = new System.Drawing.Point(88, 120);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(162, 40);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // tbObstaculos
            // 
            this.tbObstaculos.Location = new System.Drawing.Point(19, 43);
            this.tbObstaculos.Margin = new System.Windows.Forms.Padding(2);
            this.tbObstaculos.Maximum = 80;
            this.tbObstaculos.Name = "tbObstaculos";
            this.tbObstaculos.Size = new System.Drawing.Size(502, 45);
            this.tbObstaculos.TabIndex = 0;
            this.tbObstaculos.Scroll += new System.EventHandler(this.tbObstaculos_Scroll);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(454, 42);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(38, 17);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "? x ?";
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.Location = new System.Drawing.Point(243, 42);
            this.lblTam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(133, 17);
            this.lblTam.TabIndex = 7;
            this.lblTam.Text = "Tamaño del mapa:";
            // 
            // cboTam
            // 
            this.cboTam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTam.FormattingEnabled = true;
            this.cboTam.Location = new System.Drawing.Point(381, 39);
            this.cboTam.Name = "cboTam";
            this.cboTam.Size = new System.Drawing.Size(68, 25);
            this.cboTam.TabIndex = 6;
            this.cboTam.SelectedIndexChanged += new System.EventHandler(this.cboTam_SelectedIndexChanged);
            // 
            // btnCargarMapa
            // 
            this.btnCargarMapa.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarMapa.Image")));
            this.btnCargarMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarMapa.Location = new System.Drawing.Point(19, 31);
            this.btnCargarMapa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMapa.Name = "btnCargarMapa";
            this.btnCargarMapa.Size = new System.Drawing.Size(214, 38);
            this.btnCargarMapa.TabIndex = 5;
            this.btnCargarMapa.Text = "Cargar Mapa";
            this.btnCargarMapa.UseVisualStyleBackColor = true;
            this.btnCargarMapa.Click += new System.EventHandler(this.btnCargarMapa_Click);
            // 
            // gbOpcSistema
            // 
            this.gbOpcSistema.Controls.Add(this.pbAvatars);
            this.gbOpcSistema.Controls.Add(this.pbCasas);
            this.gbOpcSistema.Location = new System.Drawing.Point(614, 289);
            this.gbOpcSistema.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpcSistema.Name = "gbOpcSistema";
            this.gbOpcSistema.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpcSistema.Size = new System.Drawing.Size(538, 161);
            this.gbOpcSistema.TabIndex = 1;
            this.gbOpcSistema.TabStop = false;
            this.gbOpcSistema.Text = "Opciones del Sistema";
            // 
            // pbAvatars
            // 
            this.pbAvatars.AccessibleDescription = "Elegir Avatar";
            this.pbAvatars.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatars.Image")));
            this.pbAvatars.Location = new System.Drawing.Point(293, 23);
            this.pbAvatars.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvatars.Name = "pbAvatars";
            this.pbAvatars.Size = new System.Drawing.Size(119, 119);
            this.pbAvatars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatars.TabIndex = 1;
            this.pbAvatars.TabStop = false;
            this.pbAvatars.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // pbCasas
            // 
            this.pbCasas.AccessibleDescription = "Elegir Casas";
            this.pbCasas.Image = ((System.Drawing.Image)(resources.GetObject("pbCasas.Image")));
            this.pbCasas.Location = new System.Drawing.Point(131, 23);
            this.pbCasas.Margin = new System.Windows.Forms.Padding(2);
            this.pbCasas.Name = "pbCasas";
            this.pbCasas.Size = new System.Drawing.Size(119, 119);
            this.pbCasas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCasas.TabIndex = 0;
            this.pbCasas.TabStop = false;
            this.pbCasas.Click += new System.EventHandler(this.pbMapa_Click);
            // 
            // gbOpcGenerales
            // 
            this.gbOpcGenerales.Controls.Add(this.btnInfo);
            this.gbOpcGenerales.Controls.Add(this.chkModoNocturno);
            this.gbOpcGenerales.Controls.Add(this.btnSalir);
            this.gbOpcGenerales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcGenerales.Location = new System.Drawing.Point(614, 454);
            this.gbOpcGenerales.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpcGenerales.Name = "gbOpcGenerales";
            this.gbOpcGenerales.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpcGenerales.Size = new System.Drawing.Size(538, 101);
            this.gbOpcGenerales.TabIndex = 2;
            this.gbOpcGenerales.TabStop = false;
            this.gbOpcGenerales.Text = "Opciones Generales";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.Location = new System.Drawing.Point(179, 33);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(159, 40);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // chkModoNocturno
            // 
            this.chkModoNocturno.AutoSize = true;
            this.chkModoNocturno.Location = new System.Drawing.Point(34, 44);
            this.chkModoNocturno.Margin = new System.Windows.Forms.Padding(2);
            this.chkModoNocturno.Name = "chkModoNocturno";
            this.chkModoNocturno.Size = new System.Drawing.Size(130, 21);
            this.chkModoNocturno.TabIndex = 1;
            this.chkModoNocturno.Text = "Modo Nocturno";
            this.chkModoNocturno.UseVisualStyleBackColor = true;
            this.chkModoNocturno.CheckedChanged += new System.EventHandler(this.chkModoNocturno_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(357, 33);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 40);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbAjustesMapa
            // 
            this.gbAjustesMapa.Controls.Add(this.lblX);
            this.gbAjustesMapa.Controls.Add(this.btnCargarMapa);
            this.gbAjustesMapa.Controls.Add(this.lblTam);
            this.gbAjustesMapa.Controls.Add(this.cboTam);
            this.gbAjustesMapa.Location = new System.Drawing.Point(614, 11);
            this.gbAjustesMapa.Margin = new System.Windows.Forms.Padding(2);
            this.gbAjustesMapa.Name = "gbAjustesMapa";
            this.gbAjustesMapa.Padding = new System.Windows.Forms.Padding(2);
            this.gbAjustesMapa.Size = new System.Drawing.Size(538, 80);
            this.gbAjustesMapa.TabIndex = 9;
            this.gbAjustesMapa.TabStop = false;
            this.gbAjustesMapa.Text = "Ajustes del Mapa";
            // 
            // IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1163, 566);
            this.Controls.Add(this.gbAjustesMapa);
            this.Controls.Add(this.gbOpcGenerales);
            this.Controls.Add(this.gbOpcSistema);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.gbMapa);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "IA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IA";
            this.Load += new System.EventHandler(this.IA_Load);
            this.gbMapa.ResumeLayout(false);
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObstaculos)).EndInit();
            this.gbOpcSistema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasas)).EndInit();
            this.gbOpcGenerales.ResumeLayout(false);
            this.gbOpcGenerales.PerformLayout();
            this.gbAjustesMapa.ResumeLayout(false);
            this.gbAjustesMapa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMapa;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.GroupBox gbOpcSistema;
        private System.Windows.Forms.PictureBox pbAvatars;
        private System.Windows.Forms.PictureBox pbCasas;
        private System.Windows.Forms.GroupBox gbOpcGenerales;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox chkModoNocturno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TrackBar tbObstaculos;
        private System.Windows.Forms.Label lblObstaculos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCargarMapa;
        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.ComboBox cboTam;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblTam;
        private System.Windows.Forms.GroupBox gbAjustesMapa;
        private System.Windows.Forms.PictureBox img;
    }
}

