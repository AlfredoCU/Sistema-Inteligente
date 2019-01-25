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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IA));
            this.gbMapa = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblObstaculos = new System.Windows.Forms.Label();
            this.tbObstaculos = new System.Windows.Forms.TrackBar();
            this.gbOpcSistema = new System.Windows.Forms.GroupBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.gbOpcGenerales = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.chkModoNocturno = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbMapa.SuspendLayout();
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObstaculos)).BeginInit();
            this.gbOpcSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.gbOpcGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMapa
            // 
            this.gbMapa.Controls.Add(this.panel1);
            this.gbMapa.Location = new System.Drawing.Point(10, 11);
            this.gbMapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMapa.Name = "gbMapa";
            this.gbMapa.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMapa.Size = new System.Drawing.Size(578, 376);
            this.gbMapa.TabIndex = 0;
            this.gbMapa.TabStop = false;
            this.gbMapa.Text = "Mapa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 356);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnIniciar);
            this.gbControles.Controls.Add(this.btnPausar);
            this.gbControles.Controls.Add(this.btnRegresar);
            this.gbControles.Controls.Add(this.lblObstaculos);
            this.gbControles.Controls.Add(this.tbObstaculos);
            this.gbControles.Location = new System.Drawing.Point(614, 11);
            this.gbControles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbControles.Name = "gbControles";
            this.gbControles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbControles.Size = new System.Drawing.Size(538, 437);
            this.gbControles.TabIndex = 1;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(357, 138);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(149, 40);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Image = ((System.Drawing.Image)(resources.GetObject("btnPausar.Image")));
            this.btnPausar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPausar.Location = new System.Drawing.Point(189, 138);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(162, 40);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.Location = new System.Drawing.Point(34, 138);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(149, 40);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblObstaculos
            // 
            this.lblObstaculos.AutoSize = true;
            this.lblObstaculos.Location = new System.Drawing.Point(16, 91);
            this.lblObstaculos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObstaculos.Name = "lblObstaculos";
            this.lblObstaculos.Size = new System.Drawing.Size(88, 17);
            this.lblObstaculos.TabIndex = 1;
            this.lblObstaculos.Text = "Obstáculos: ";
            // 
            // tbObstaculos
            // 
            this.tbObstaculos.Location = new System.Drawing.Point(18, 46);
            this.tbObstaculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbObstaculos.Maximum = 100;
            this.tbObstaculos.Name = "tbObstaculos";
            this.tbObstaculos.Size = new System.Drawing.Size(505, 45);
            this.tbObstaculos.TabIndex = 0;
            this.tbObstaculos.Scroll += new System.EventHandler(this.tbObstaculos_Scroll);
            // 
            // gbOpcSistema
            // 
            this.gbOpcSistema.Controls.Add(this.pbAvatar);
            this.gbOpcSistema.Controls.Add(this.pbMapa);
            this.gbOpcSistema.Location = new System.Drawing.Point(10, 393);
            this.gbOpcSistema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOpcSistema.Name = "gbOpcSistema";
            this.gbOpcSistema.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOpcSistema.Size = new System.Drawing.Size(578, 161);
            this.gbOpcSistema.TabIndex = 1;
            this.gbOpcSistema.TabStop = false;
            this.gbOpcSistema.Text = "Opciones del Sistema";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(319, 23);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(119, 119);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // pbMapa
            // 
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(131, 23);
            this.pbMapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(119, 119);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.Click += new System.EventHandler(this.pbMapa_Click);
            // 
            // gbOpcGenerales
            // 
            this.gbOpcGenerales.Controls.Add(this.btnInfo);
            this.gbOpcGenerales.Controls.Add(this.chkModoNocturno);
            this.gbOpcGenerales.Controls.Add(this.btnSalir);
            this.gbOpcGenerales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcGenerales.Location = new System.Drawing.Point(614, 454);
            this.gbOpcGenerales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOpcGenerales.Name = "gbOpcGenerales";
            this.gbOpcGenerales.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOpcGenerales.Size = new System.Drawing.Size(538, 100);
            this.gbOpcGenerales.TabIndex = 2;
            this.gbOpcGenerales.TabStop = false;
            this.gbOpcGenerales.Text = "Opciones Generales";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.Location = new System.Drawing.Point(179, 33);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.chkModoNocturno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 40);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1163, 566);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.gbOpcGenerales.ResumeLayout(false);
            this.gbOpcGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMapa;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.GroupBox gbOpcSistema;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.GroupBox gbOpcGenerales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox chkModoNocturno;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TrackBar tbObstaculos;
        private System.Windows.Forms.Label lblObstaculos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

