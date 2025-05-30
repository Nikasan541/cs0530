namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        int xx = -10;
        int xy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            label2.Left += xx;
            label2.Top += xy;



            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            } 

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if (label2.Left < 0)
            {
                xx = Math.Abs(xx);
            }
            else if (label2.Right > ClientSize.Width)
            {
                xx = -Math.Abs(xx);
            }

            if (label2.Top < 0)
            {
                xy = Math.Abs(xy);
            }
            else if (label2.Bottom > ClientSize.Height)
            {
                xy = -Math.Abs(xy);
            }

            if (label1.Left == label2.Left && label1.Top == label2.Top)
            {
                MessageBox.Show("You didit!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
