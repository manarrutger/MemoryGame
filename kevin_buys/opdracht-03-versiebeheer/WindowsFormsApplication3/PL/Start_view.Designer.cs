namespace WindowsFormsApplication3.PL
{
    partial class Start_view
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
      this.label1 = new System.Windows.Forms.Label();
      this.lblErr = new System.Windows.Forms.Label();
      this.txtBName = new System.Windows.Forms.TextBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(2, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Name :";
      // 
      // lblErr
      // 
      this.lblErr.Location = new System.Drawing.Point(49, 70);
      this.lblErr.Name = "lblErr";
      this.lblErr.Size = new System.Drawing.Size(248, 23);
      this.lblErr.TabIndex = 6;
      this.lblErr.Text = "Welcome to the MemoryGame";
      this.lblErr.Click += new System.EventHandler(this.lblErr_Click);
      // 
      // txtBName
      // 
      this.txtBName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBName.Location = new System.Drawing.Point(49, 32);
      this.txtBName.Name = "txtBName";
      this.txtBName.Size = new System.Drawing.Size(248, 25);
      this.txtBName.TabIndex = 0;
      this.txtBName.WordWrap = false;
      this.txtBName.TextChanged += new System.EventHandler(this.txtBName_TextChanged);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(200, 103);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(97, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtBName);
      this.groupBox1.Controls.Add(this.lblErr);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnStart);
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(303, 132);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      // 
      // Start_view
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "Start_view";
      this.Size = new System.Drawing.Size(309, 138);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox txtBName;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
