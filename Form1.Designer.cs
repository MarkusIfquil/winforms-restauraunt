namespace nmark_csaba_etterem_projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAsztalFoglalas = new System.Windows.Forms.Button();
            this.btnRendeles = new System.Windows.Forms.Button();
            this.btnFizetes = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsztalFoglalas
            // 
            this.btnAsztalFoglalas.Location = new System.Drawing.Point(478, 12);
            this.btnAsztalFoglalas.Name = "btnAsztalFoglalas";
            this.btnAsztalFoglalas.Size = new System.Drawing.Size(460, 1020);
            this.btnAsztalFoglalas.TabIndex = 0;
            this.btnAsztalFoglalas.Text = "Asztal foglalás és rendelés";
            this.btnAsztalFoglalas.UseVisualStyleBackColor = true;
            // 
            // btnRendeles
            // 
            this.btnRendeles.Location = new System.Drawing.Point(12, 12);
            this.btnRendeles.Name = "btnRendeles";
            this.btnRendeles.Size = new System.Drawing.Size(460, 1020);
            this.btnRendeles.TabIndex = 1;
            this.btnRendeles.Text = "Online rendelés";
            this.btnRendeles.UseVisualStyleBackColor = true;
            this.btnRendeles.Click += new System.EventHandler(this.btnRendeles_Click);
            // 
            // btnFizetes
            // 
            this.btnFizetes.Location = new System.Drawing.Point(944, 12);
            this.btnFizetes.Name = "btnFizetes";
            this.btnFizetes.Size = new System.Drawing.Size(460, 1020);
            this.btnFizetes.TabIndex = 2;
            this.btnFizetes.Text = "Fizetés";
            this.btnFizetes.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(1410, 12);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(460, 1020);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Statisztika";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnFizetes);
            this.Controls.Add(this.btnRendeles);
            this.Controls.Add(this.btnAsztalFoglalas);
            this.Name = "Form1";
            this.Text = "Pincér Program";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAsztalFoglalas;
        private Button btnRendeles;
        private Button btnFizetes;
        private Button btnStats;
    }
}