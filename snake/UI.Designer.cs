namespace snake
{
    partial class UI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamefield = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamefield
            // 
            this.gamefield.BackColor = System.Drawing.Color.Teal;
            this.gamefield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamefield.Location = new System.Drawing.Point(197, 62);
            this.gamefield.Name = "gamefield";
            this.gamefield.Size = new System.Drawing.Size(1090, 605);
            this.gamefield.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Location = new System.Drawing.Point(1251, 13);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(53, 13);
            this.labelscore.TabIndex = 1;
            this.labelscore.Text = "scorelabe";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 726);
            this.Controls.Add(this.labelscore);
            this.Controls.Add(this.gamefield);
            this.Name = "UI";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UI_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamefield;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelscore;
    }
}

