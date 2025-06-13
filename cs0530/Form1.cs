namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int vx2 = -10;
        int vy2 = -10;
        int vx3 = -10;
        int vy3 = -10;

        int xx = -10;
        int xy = -10;
        int counter = 0;
        static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);
            label1.Top = random.Next(ClientSize.Height-label1.Top);
            label1.Left = random.Next(ClientSize.Width-label1.Width);
            vx2 = random.Next(-10, 11);
            vy2 = random.Next(-10, 11);
            label5.Top = random.Next(ClientSize.Height - label5.Top);
            label5.Left = random.Next(ClientSize.Width - label5.Width);
            vx3 = random.Next(-10, 11);
            vy3 = random.Next(-10, 11);
            label6.Top = random.Next(ClientSize.Height - label6.Top);
            label6.Left = random.Next(ClientSize.Width - label6.Width);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label4.Text = $"Counter: {counter}";
            //ç¿ïWåv
            var mpos = MousePosition;
            var fpos = PointToClient(mpos);
            Text = $"{mpos.X},{mpos.Y} / {fpos.X},{fpos.Y}";
            textBox1.Text = $"{mpos.X},{mpos.Y} / {fpos.X},{fpos.Y}";

            label1.Left += vx;
            label1.Top += vy;

            label2.Left += xx;
            label2.Top += xy;

            label5.Left += vx2;
            label5.Top += vx2;

            label6.Left += vx3;
            label6.Top += vy3;

            //ÇªÇÍÇºÇÍÇÃïùÇ∆çÇÇ≥Ç/2ÇµÇƒÇ¢ÇÈ
            label3.Left = fpos.X - (label3.Width / 2);
            label3.Top = fpos.Y - (label3.Height / 2);


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

            //-------------------------------------------------------
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

            //---------------------------------------------------------
            if (label5.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            else if (label5.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }

            if (label5.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            else if (label5.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }

            //----------------------------------------------------------
            if (label6.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            else if (label6.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }

            if (label6.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            else if (label6.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
            }

            if (label1.Left == label2.Left && label1.Top == label2.Top)
            {
                MessageBox.Show("You didit!");
            }
            if (label1.Left < fpos.X &&
                label1.Right > fpos.X &&
                label1.Top < fpos.Y &&
                label1.Bottom > fpos.Y)
            {
                timer1.Enabled = false;
                button1.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            timer1.Enabled = true;
            button1.Visible = false;
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);
            label1.Top = random.Next(ClientSize.Height - label1.Top);
            label1.Left = random.Next(ClientSize.Width - label1.Width);
        }
    }
}
