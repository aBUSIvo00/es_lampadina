namespace lampadina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int y = 277;
        bool pos = true;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (y>0)
            {
                y = y - 10;
                pictureBox2.Location = new Point(357, y);
                pictureBox1.Location = new Point(357, y);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y<285)
            {
                y = y + 10;
                pictureBox2.Location = new Point(357, y);
                pictureBox1.Location = new Point(357, y);
            }
          
        }
    }
}