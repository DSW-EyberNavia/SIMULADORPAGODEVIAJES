namespace SIMULADOR_PAGO_DE_VIAJES
{
    partial class INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.p = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p.BackgroundImage")));
            this.p.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p.Location = new System.Drawing.Point(139, 66);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(75, 23);
            this.p.TabIndex = 14;
            this.p.Text = "Pitalito";
            this.p.UseVisualStyleBackColor = true;
            this.p.Click += new System.EventHandler(this.p_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f.BackgroundImage")));
            this.f.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.f.Location = new System.Drawing.Point(139, 145);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(75, 23);
            this.f.TabIndex = 13;
            this.f.Text = "Florencia";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // m
            // 
            this.m.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m.BackgroundImage")));
            this.m.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m.Location = new System.Drawing.Point(12, 145);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(75, 23);
            this.m.TabIndex = 12;
            this.m.Text = "Medellín";
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // b
            // 
            this.b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b.BackgroundImage")));
            this.b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b.Location = new System.Drawing.Point(11, 66);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 11;
            this.b.Text = "Bogotá";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CALCULAR VALOR  A PAGAR VIAJES ";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(241, 251);
            this.Controls.Add(this.p);
            this.Controls.Add(this.f);
            this.Controls.Add(this.m);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label1);
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.INICIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button p;
        private Button f;
        private Button m;
        private Button b;
        private Label label1;
    }
}