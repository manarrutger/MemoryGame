namespace WindowsFormsApplication3
{
    partial class viewscore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 65);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 16);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Score : ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(6, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 16);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Error   : ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Naam : ";
            this.lbl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(73, 20);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(73, 27);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "default";
            this.lblNaam.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(73, 65);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(71, 100);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 20);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "3";
            this.lblError.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultat";
            // 
            // viewscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "viewscore";
            this.Size = new System.Drawing.Size(252, 143);
            this.Load += new System.EventHandler(this.viewscore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.Label lblNaam;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
