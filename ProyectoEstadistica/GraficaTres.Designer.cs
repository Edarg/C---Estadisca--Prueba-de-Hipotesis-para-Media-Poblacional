namespace ProyectoEstadistica
{
    partial class GraficaTres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficaTres));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rechazo = new System.Windows.Forms.PictureBox();
            this.ValorTAceptacionD = new System.Windows.Forms.Label();
            this.FlechaAfueraD = new System.Windows.Forms.PictureBox();
            this.ValorTRechazo = new System.Windows.Forms.Label();
            this.IntervaloIz = new System.Windows.Forms.Label();
            this.RechazoIz = new System.Windows.Forms.Label();
            this.ZonaAceptada = new System.Windows.Forms.Label();
            this.dato_proporcionado = new System.Windows.Forms.Label();
            this.asignar = new System.Windows.Forms.Label();
            this.conclusion = new MaterialSkin.Controls.MaterialLabel();
            this.Regresar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaAfueraD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoEstadistica.Properties.Resources.RegionUniIzquierdo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(101, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 260);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Rechazo
            // 
            this.Rechazo.BackColor = System.Drawing.Color.Transparent;
            this.Rechazo.BackgroundImage = global::ProyectoEstadistica.Properties.Resources.flechazo_arriba;
            this.Rechazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rechazo.Location = new System.Drawing.Point(171, 246);
            this.Rechazo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rechazo.Name = "Rechazo";
            this.Rechazo.Size = new System.Drawing.Size(17, 28);
            this.Rechazo.TabIndex = 23;
            this.Rechazo.TabStop = false;
            // 
            // ValorTAceptacionD
            // 
            this.ValorTAceptacionD.AutoSize = true;
            this.ValorTAceptacionD.BackColor = System.Drawing.Color.Transparent;
            this.ValorTAceptacionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTAceptacionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValorTAceptacionD.Location = new System.Drawing.Point(431, 278);
            this.ValorTAceptacionD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValorTAceptacionD.Name = "ValorTAceptacionD";
            this.ValorTAceptacionD.Size = new System.Drawing.Size(59, 20);
            this.ValorTAceptacionD.TabIndex = 22;
            this.ValorTAceptacionD.Text = "label2";
            // 
            // FlechaAfueraD
            // 
            this.FlechaAfueraD.BackColor = System.Drawing.Color.Transparent;
            this.FlechaAfueraD.BackgroundImage = global::ProyectoEstadistica.Properties.Resources.flechazo_arriba;
            this.FlechaAfueraD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlechaAfueraD.Location = new System.Drawing.Point(435, 246);
            this.FlechaAfueraD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlechaAfueraD.Name = "FlechaAfueraD";
            this.FlechaAfueraD.Size = new System.Drawing.Size(17, 28);
            this.FlechaAfueraD.TabIndex = 21;
            this.FlechaAfueraD.TabStop = false;
            this.FlechaAfueraD.Click += new System.EventHandler(this.FlechaAfueraD_Click);
            // 
            // ValorTRechazo
            // 
            this.ValorTRechazo.AutoSize = true;
            this.ValorTRechazo.BackColor = System.Drawing.Color.Transparent;
            this.ValorTRechazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTRechazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ValorTRechazo.Location = new System.Drawing.Point(105, 278);
            this.ValorTRechazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValorTRechazo.Name = "ValorTRechazo";
            this.ValorTRechazo.Size = new System.Drawing.Size(59, 20);
            this.ValorTRechazo.TabIndex = 20;
            this.ValorTRechazo.Text = "label2";
            // 
            // IntervaloIz
            // 
            this.IntervaloIz.BackColor = System.Drawing.Color.Transparent;
            this.IntervaloIz.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.IntervaloIz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IntervaloIz.Location = new System.Drawing.Point(228, 249);
            this.IntervaloIz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntervaloIz.Name = "IntervaloIz";
            this.IntervaloIz.Size = new System.Drawing.Size(65, 25);
            this.IntervaloIz.TabIndex = 25;
            this.IntervaloIz.Text = "label1";
            // 
            // RechazoIz
            // 
            this.RechazoIz.BackColor = System.Drawing.Color.Transparent;
            this.RechazoIz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechazoIz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RechazoIz.Location = new System.Drawing.Point(113, 212);
            this.RechazoIz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RechazoIz.Name = "RechazoIz";
            this.RechazoIz.Size = new System.Drawing.Size(63, 27);
            this.RechazoIz.TabIndex = 24;
            this.RechazoIz.Text = "label1";
            // 
            // ZonaAceptada
            // 
            this.ZonaAceptada.BackColor = System.Drawing.Color.Transparent;
            this.ZonaAceptada.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.ZonaAceptada.ForeColor = System.Drawing.Color.Black;
            this.ZonaAceptada.Location = new System.Drawing.Point(317, 185);
            this.ZonaAceptada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZonaAceptada.Name = "ZonaAceptada";
            this.ZonaAceptada.Size = new System.Drawing.Size(67, 25);
            this.ZonaAceptada.TabIndex = 26;
            this.ZonaAceptada.Text = "label1";
            // 
            // dato_proporcionado
            // 
            this.dato_proporcionado.AutoSize = true;
            this.dato_proporcionado.Location = new System.Drawing.Point(11, 90);
            this.dato_proporcionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dato_proporcionado.Name = "dato_proporcionado";
            this.dato_proporcionado.Size = new System.Drawing.Size(44, 16);
            this.dato_proporcionado.TabIndex = 27;
            this.dato_proporcionado.Text = "label1";
            // 
            // asignar
            // 
            this.asignar.AutoSize = true;
            this.asignar.Location = new System.Drawing.Point(11, 123);
            this.asignar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(44, 16);
            this.asignar.TabIndex = 28;
            this.asignar.Text = "label1";
            // 
            // conclusion
            // 
            this.conclusion.AutoSize = true;
            this.conclusion.Depth = 0;
            this.conclusion.Font = new System.Drawing.Font("Roboto", 11F);
            this.conclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.conclusion.Location = new System.Drawing.Point(21, 411);
            this.conclusion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conclusion.MouseState = MaterialSkin.MouseState.HOVER;
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(136, 24);
            this.conclusion.TabIndex = 29;
            this.conclusion.Text = "materialLabel1";
            // 
            // Regresar
            // 
            this.Regresar.Depth = 0;
            this.Regresar.Location = new System.Drawing.Point(555, 38);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Regresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Regresar.Name = "Regresar";
            this.Regresar.Primary = true;
            this.Regresar.Size = new System.Drawing.Size(100, 28);
            this.Regresar.TabIndex = 33;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // GraficaTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 474);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.dato_proporcionado);
            this.Controls.Add(this.ZonaAceptada);
            this.Controls.Add(this.IntervaloIz);
            this.Controls.Add(this.RechazoIz);
            this.Controls.Add(this.Rechazo);
            this.Controls.Add(this.ValorTAceptacionD);
            this.Controls.Add(this.FlechaAfueraD);
            this.Controls.Add(this.ValorTRechazo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "GraficaTres";
            this.Text = "Contraste Unilateral Izquierdo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraficaTres_FormClosed);
            this.Load += new System.EventHandler(this.GraficaTres_Load);
            this.FontChanged += new System.EventHandler(this.GraficaTres_FontChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaAfueraD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Rechazo;
        public System.Windows.Forms.Label ValorTAceptacionD;
        private System.Windows.Forms.PictureBox FlechaAfueraD;
        public System.Windows.Forms.Label ValorTRechazo;
        public System.Windows.Forms.Label IntervaloIz;
        public System.Windows.Forms.Label RechazoIz;
        public System.Windows.Forms.Label ZonaAceptada;
        public System.Windows.Forms.Label dato_proporcionado;
        public System.Windows.Forms.Label asignar;
        private MaterialSkin.Controls.MaterialLabel conclusion;
        private MaterialSkin.Controls.MaterialRaisedButton Regresar;
    }
}