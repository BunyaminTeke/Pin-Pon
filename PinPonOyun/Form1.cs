namespace PinPonOyun
{
    public partial class PinPon : Form
    {
        bool hile = false;
        public PinPon()
        {

            this.DoubleBuffered = true;
            InitializeComponent();
            btn_close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close.BackgroundImage = Resource1.Close;

            btn_tekrar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_tekrar.BackgroundImage = Resource1.Reboot;
            this.BackgroundImage = Resource1.background1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Cursor.Hide();
            this.KeyPreview = true;
            TopOlustur();
            TopaHizVer();


        }
        Button top = new Button();
        int topHizdx;
        int topHizdy;
        private void TopaHizVer()
        {
            topHizdx = (new Random().Next(1, 4)) * 3;
            topHizdy = (new Random().Next(1, 4)) * 3;

            if (new Random().Next(0, 2) == 0)
            {
                topHizdx = -topHizdx;
            }
            else
            {
                topHizdy = -topHizdy;
            }

            timer1.Start();
        }
        private void TopOlustur()
        {
            top.Enabled = false;
            top.Width = 25;
            top.Height = 25;
            top.Location = new Point(new Random().Next(solDuvar.Right, sagDuvar.Left - top.Width), this.Height / 2);
            top.FlatAppearance.BorderSize = 0;
            top.FlatStyle = FlatStyle.Flat;
            top.BackColor = Color.DarkBlue;

            this.Controls.Add(top);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Location.X >= solDuvar.Right + platform.Width / 2 && e.Location.X <= sagDuvar.Location.X - platform.Width / 2)
            {
                platform.Location = new Point(e.X - platform.Width / 2, platform.Location.Y);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_tekrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        int sure;
        int skor;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure % 40 == 0)
            {
                lbl_sure.Text = (sure / 40).ToString() + " sn";

            }

            if (sure >= timer1.Interval * 40 * 5)
            {
                timer1.Interval--;
            }

            top.Location = new Point(top.Location.X + topHizdx, top.Location.Y + topHizdy);

            if (top.Bounds.IntersectsWith(platform.Bounds))
            {
                topHizdx = topHizdx;
                topHizdy = -topHizdy;
                skor++;
                lbl_skor.Text = skor.ToString();

            }

            if (top.Bounds.IntersectsWith(ustDuvar.Bounds))
            {
                topHizdx = topHizdx;
                topHizdy = -topHizdy;
            }


            if (top.Bounds.IntersectsWith(sagDuvar.Bounds))
            {
                topHizdx = -topHizdx;
                topHizdy = topHizdy;
            }
            if (top.Bounds.IntersectsWith(solDuvar.Bounds))
            {
                topHizdx = -topHizdx;
                topHizdy = topHizdy;
            }

            if (top.Top >= button1.Top)
            {
                timer1.Stop();
                Cursor.Show();
                MessageBox.Show(skor + " Puan Tebrikler");
            }

            if (hile && top.Location.Y >=this.Height* 4 / 5)
            {
                platform.Location = new Point(top.Location.X, platform.Location.Y);
            }


        }

        private void PinPon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                hile = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                System.Environment.Exit(0);
                
            }

            if (e.KeyCode == Keys.R)
            {
                Application.Restart();
                
            }
        }
    }
}
