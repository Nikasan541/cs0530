namespace cs0530
{
    public partial class Form1 : Form
    {
        int[] vx = new int[3];
        int[] vy = new int[3];
        int counter = 0;
        int a;
        static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            vx[0] = random.Next(-10, 101);
            vy[0] = random.Next(-10, 101);
            vx[1] = random.Next(-10, 201);
            vy[1] = random.Next(-10, 201);
            vx[2] = random.Next(-10, 301);
            vy[2] = random.Next(-10, 301);

            label1.Top = random.Next(ClientSize.Height - label1.Top);
            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label5.Top = random.Next(ClientSize.Height - label5.Top);
            label5.Left = random.Next(ClientSize.Width - label5.Width);
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

            label1.Left += vx[0];
            label1.Top += vy[0];

            label5.Left += vx[1];
            label5.Top += vy[1];

            label6.Left += vx[2];
            label6.Top += vy[2];

            //ÇªÇÍÇºÇÍÇÃïùÇ∆çÇÇ≥Ç/2ÇµÇƒÇ¢ÇÈ
            label3.Left = fpos.X - (label3.Width / 2);
            label3.Top = fpos.Y - (label3.Height / 2);


            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }

            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }


            //---------------------------------------------------------
            if (label5.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label5.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }

            if (label5.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label5.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            //----------------------------------------------------------
            if (label6.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label6.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }

            if (label6.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            else if (label6.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
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
            vx[0] = random.Next(-10, 11);
            vy[0] = random.Next(-10, 11);
            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);
            vx[2] = random.Next(-10, 11);
            vy[2] = random.Next(-10, 11);
            label1.Top = random.Next(ClientSize.Height - label1.Top);
            label1.Left = random.Next(ClientSize.Width - label1.Width);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i =0; i<10; i++)
            {
                MessageBox.Show($"{i}");
                button2.Text = $"{i}";
            }
        }
    }
}
