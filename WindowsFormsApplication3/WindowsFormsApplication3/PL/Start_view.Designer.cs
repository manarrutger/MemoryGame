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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            // 
            // lblErr
            // 
            this.lblErr.Location = new System.Drawing.Point(2, 102);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(305, 47);
            this.lblErr.TabIndex = 6;
            this.lblErr.Text = "...";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(90, 3);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(217, 20);
            this.txtBName.TabIndex = 4;
            this.txtBName.TextChanged += new System.EventHandler(this.txtBName_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(0, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(307, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Start_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.btnStart);
            this.Name = "Start_view";
            this.Size = new System.Drawing.Size(309, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox txtBName;
        public System.Windows.Forms.Button btnStart;
    }
}
