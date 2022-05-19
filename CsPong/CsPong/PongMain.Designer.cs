namespace CsPong
{
    partial class PongMain
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 29);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1024, 739);
            this.containerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CsPong.Properties.Resources.pqbkg;
            this.panel1.Controls.Add(this.tittleLabel);
            this.panel1.Controls.Add(this.minimizeLabel);
            this.panel1.Controls.Add(this.closeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.BackColor = System.Drawing.Color.Transparent;
            this.tittleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tittleLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(0, 0);
            this.tittleLabel.MinimumSize = new System.Drawing.Size(975, 0);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(975, 23);
            this.tittleLabel.TabIndex = 2;
            this.tittleLabel.Text = "New game";
            this.tittleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tittleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.tittleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.tittleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeLabel.Location = new System.Drawing.Point(976, 0);
            this.minimizeLabel.MinimumSize = new System.Drawing.Size(24, 25);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(24, 25);
            this.minimizeLabel.TabIndex = 1;
            this.minimizeLabel.Text = "-";
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeLabel.Location = new System.Drawing.Point(1000, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(24, 25);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // PongMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "PongMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label tittleLabel;
    }
}