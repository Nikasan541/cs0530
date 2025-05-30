namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"{label1.Right}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;


            if(label1.Left < 0)
            {
                vx = -vx;
            }
            else if (label1.Right > 800)
            {
                vx = -vx;
            } 

            if (label1.Top < 0)
            {
                vy = -vy;
            }
            else if (label1.Bottom > 450)
            {
                vy = -vy;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
