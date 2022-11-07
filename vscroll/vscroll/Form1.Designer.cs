namespace vscroll
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl = new System.Windows.Forms.Panel();
            this.l1 = new System.Windows.Forms.Label();
            this.bar1 = new System.Windows.Forms.VScrollBar();
            this.rLbl = new System.Windows.Forms.Label();
            this.bLbl = new System.Windows.Forms.Label();
            this.gLbl = new System.Windows.Forms.Label();
            this.bar2 = new System.Windows.Forms.VScrollBar();
            this.bar3 = new System.Windows.Forms.VScrollBar();
            this.bar4 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Location = new System.Drawing.Point(378, 46);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(400, 363);
            this.lbl.TabIndex = 0;
            // 
            // l1
            // 
            this.l1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.SystemColors.Menu;
            this.l1.Location = new System.Drawing.Point(499, 22);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(174, 25);
            this.l1.TabIndex = 1;
            this.l1.Text = "RBG SCROLL COLOR";
            // 
            // bar1
            // 
            this.bar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar1.Location = new System.Drawing.Point(378, 481);
            this.bar1.Maximum = 255;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(23, 177);
            this.bar1.SmallChange = 5;
            this.bar1.TabIndex = 2;
            this.bar1.Value = 255;
            this.bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar1_Scroll);
            // 
            // rLbl
            // 
            this.rLbl.AutoSize = true;
            this.rLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.rLbl.Location = new System.Drawing.Point(343, 658);
            this.rLbl.Name = "rLbl";
            this.rLbl.Size = new System.Drawing.Size(107, 25);
            this.rLbl.TabIndex = 6;
            this.rLbl.Text = "Red Value: ";
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.bLbl.Location = new System.Drawing.Point(526, 658);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(125, 25);
            this.bLbl.TabIndex = 7;
            this.bLbl.Text = "Green Value: ";
            // 
            // gLbl
            // 
            this.gLbl.AutoSize = true;
            this.gLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.gLbl.Location = new System.Drawing.Point(715, 658);
            this.gLbl.Name = "gLbl";
            this.gLbl.Size = new System.Drawing.Size(112, 25);
            this.gLbl.TabIndex = 8;
            this.gLbl.Text = "Blue Value: ";
            // 
            // bar2
            // 
            this.bar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar2.Location = new System.Drawing.Point(567, 481);
            this.bar2.Maximum = 255;
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(23, 177);
            this.bar2.SmallChange = 5;
            this.bar2.TabIndex = 9;
            this.bar2.Value = 255;
            this.bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar2_Scroll);
            // 
            // bar3
            // 
            this.bar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar3.Location = new System.Drawing.Point(755, 481);
            this.bar3.Maximum = 255;
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(23, 177);
            this.bar3.SmallChange = 5;
            this.bar3.TabIndex = 10;
            this.bar3.Value = 255;
            this.bar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar3_Scroll);
            // 
            // bar4
            // 
            this.bar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bar4.Location = new System.Drawing.Point(425, 422);
            this.bar4.Maximum = 720;
            this.bar4.Minimum = 400;
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(319, 25);
            this.bar4.TabIndex = 11;
            this.bar4.Value = 400;
            this.bar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.bar4);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.gLbl);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.rLbl);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form1";
            this.Text = "RGB creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel lbl;
        private Label l1;
        private VScrollBar bar1;
        private Label rLbl;
        private Label bLbl;
        private Label gLbl;
        private VScrollBar bar2;
        private VScrollBar bar3;
        private HScrollBar bar4;
    }
}