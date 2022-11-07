namespace vscroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbl.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            l1.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            rLbl.Text = "Red Value: " + bar1.Value.ToString();
        }

        private void bar2_Scroll(object sender, ScrollEventArgs e)
        {
            lbl.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            l1.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            bLbl.Text = "Green Value: " + bar2.Value.ToString();
        }

        private void bar3_Scroll(object sender, ScrollEventArgs e)
        {
            lbl.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            l1.BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
            gLbl.Text = "Blue Value: " + bar3.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbl.Width = bar4.Value;
            int difference = e.NewValue - e.OldValue;
            lbl.Location = new Point(lbl.Location.X - difference /2, lbl.Location.Y);
        }


    }
}