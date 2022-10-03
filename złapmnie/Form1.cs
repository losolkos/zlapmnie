namespace złapmnie
{
    public partial class Form1 : Form
    {
        readonly Random r;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            punkty = 0;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height -50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
            punkty++;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
            timer1.Stop();
            timer1.Start();
        }
    }
}