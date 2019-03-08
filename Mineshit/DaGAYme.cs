using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mineshit
{
    public partial class DaGAYme : Form
    {
        Button[,] btn = new Button[41, 41];
        int[,] btn_prop = new int[41, 41];
        int[,] saved_btn_prop = new int[41, 41];
        Point coord;

        bool firstPlay = true;
        bool gameover = false;

        int seconds = 0;
        int minutes = 0;

        //Tiq deto sa naokolo
        int[] dx8 = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy8 = { 0, 1, 0, -1, 1, -1, 1, -1 };

        //Za chertaneto na igralnoto pole
        int start_x, start_y;
        int height, width;

        int mines;
        int FlagsValue = 10;
        int flags;

        //Butonchetata
        int buttonSize = 20;
        int distance_between = 20;

        //Coeficients for difficulty
        double easyCoef = 0.1f;
        double mediumCoef = 0.2f;
        double hardCoef = 0.3f;

        //sum music
        SoundPlayer spBones = new SoundPlayer(Mineshit.Properties.Resources.Clarx___Bones__NCS_Release_);
        SoundPlayer spEndless = new SoundPlayer(Mineshit.Properties.Resources.Marin_Hoxha___Endless__NCS_Release_);

        public DaGAYme()
        {
            InitializeComponent();
        }
        
        private void DaGAYme_Load(object sender, EventArgs e)
        {
            spBones.Play();
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e) //bones(defaulth)
        {
            spBones.Play();
        }

        private void option2ToolStripMenuItem_Click(object sender, EventArgs e) //endless
        {
            spEndless.Play();
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spBones.Stop();
            spEndless.Stop();
        }

        private void muteMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spBones.Stop();
            spEndless.Stop();
        }
        
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.purple;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.black;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm Stoyanka (Sissy)  Dancheva.\nStudying Software Technologies and Design, first year.\nHave fun with the game! :)", "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The first step is the hardest. Clicking on a random place(s) and hoping you’re not blown to bits.\n2. If you click on a non - bomb area, the square will either open up to be blank, or will contain a number from 1 to 8./n3. These numbers specify the number of bombs that are adjacent to that block. 1 means there is only 1 bomb adjacent to it, while 8 would mean all blocks adjacent to it are bombs.\n4. Next, you need to do a bit of calculations.You need to find out which block will contain the bomb(s). These calculations are to be performed based on multiple blocks that are either clear or contain other numbers.\n5. Most Minesweeper games have the functionality to mark where bombs are, so you can remember easily.", "DA rulz!");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you want to visit the site, click yes.\n", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://snapguide.com/guides/play-minesweeper/");
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.blue2;
        }

        private void DaGAYme_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Gave up?", "Leaving...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void GAYmeOver()
        {
            gameover = true;
            DaMap();
            MessageBox.Show("You lose!", "Game Over :D");
        }

        void WinGAYme()
        {
            gameover = true;
            DaMap();
            progressBar.Value = 0;
            MessageBox.Show("You win! :O", "Congrats!");
        }

        void EmptySpaces(int x, int y)
        {
            if (btn_prop[x, y] == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int cx = x + dx8[i];
                    int cy = y + dy8[i];

                    if (IsPointOnMap(cx, cy) == 1)
                        if (btn[cx, cy].Enabled == true && btn_prop[cx, cy] != -1 && !gameover)
                        {
                            progressBar.Value++;
                            lblScore.Text = "Score: " + progressBar.Value.ToString();
                            btnImages(cx, cy);
                        }
                }
            }
        }

        void btnImages(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover && btn_prop[x, y] == FlagsValue)
                btn_prop[x, y] = saved_btn_prop[x, y];

            if (gameover)
                timer.Stop();

            switch (btn_prop[x,y])
            {
                case 0: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.blank; EmptySpaces(x, y); break;
                case 1: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.one; break;
                case 2: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.two; break;
                case 3: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.three; break;
                case 4: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.four; break;
                case 5: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.five; break;
                case 6: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.six; break;
                case 7: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.seven; break;
                case 8: btn[x, y].BackgroundImage = Mineshit.Properties.Resources.eight; break;
                case -1:btn[x, y].BackgroundImage = Mineshit.Properties.Resources.bomb2;
                         if (!gameover) GAYmeOver();
                             break;
            }
        }

        int IsPointOnMap(int x,int y)
        {
            if (x < 1 || x > width || y < 1 || y > height)
            {
                return 0;
            }
            return 1;
        }

        void DaMap()
        {
            for (int i = 0; i <= width; i++)
                for (int j = 0; j <= height; j++)
                    if (btn[i,j].Enabled == true)
                    {
                        btnImages(i, j);
                    }
        }

        void WinFlag()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn_prop[i, j] == -1)
                        win = false;

            if (win)
            {
                WinGAYme();
            }
        }

        void WinClick()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true && saved_btn_prop[i, j] != -1)
                        win = false;

            if (win)
            {
                WinGAYme();
            }
        }

        private void OneClick(object sender, EventArgs e)
        {
            coord = ((Button)sender).Location;
            int x = (coord.X - start_x) / buttonSize;
            int y = (coord.Y - start_y) / buttonSize;

            if (btn_prop[x,y] != FlagsValue)
            {
                ((Button)sender).Enabled = false;
                ((Button)sender).Text = "";

                ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;

                if (btn_prop[x,y] != -1 && !gameover)
                {
                    //kogato e 5 na 5 & easy problem s progressbar-a
                    progressBar.Value++;
                    lblScore.Text = "Score: " + progressBar.Value.ToString();
                    WinClick();
                }

                btnImages(x, y);
            }
        }

        int Mines(int x, int y)
        {
            int score = 0;
            for (int i = 0; i < 8; i++)
            {
                int cx = x + dx8[i];
                int cy = y + dy8[i];

                if (IsPointOnMap(cx, cy) == 1 && btn_prop[cx, cy] == -1)
                    score++;
            }
            return score;
        }

        void MapNumbering(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    if (btn_prop[i,j] != -1)
                    {
                        btn_prop[i, j] = Mines(i, j);
                        saved_btn_prop[i, j] = Mines(i, j);
                    }
        }

        private void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                coord = ((Button)sender).Location;
                int x = (coord.X - start_x) / buttonSize;
                int y = (coord.Y - start_y) / buttonSize;

                if (btn_prop[x, y] != FlagsValue && flags > 0)
                {
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = Mineshit.Properties.Resources.flag;
                    btn_prop[x, y] = FlagsValue;
                    flags--;
                    WinFlag();
                }
                else if (btn_prop[x, y] == FlagsValue)
                {
                    btn_prop[x, y] = saved_btn_prop[x, y];
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = null;
                    flags++;
                }

                lblFlags.Text = "Flags: " + flags;
            }
        }

        void CreateButtons(int x, int y)
        {
            for (int i = 0; i <= x; i++)
                for (int j = 0; j <= y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(i * buttonSize + start_x, j * buttonSize + start_y, distance_between, distance_between);
                    btn[i, j].Click += new EventHandler(OneClick);
                    btn[i, j].MouseUp += new MouseEventHandler(RightClick);
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                    btn[i, j].TabStop = false;
                    Controls.Add(btn[i, j]);
                }
        }

        void GenerateMap(int x, int y, int mines)
        {
            Random rand = new Random();
            List<int> coordx = new List<int>();
            List<int> coordy = new List<int>();

            while (mines > 0)
            {
                coordx.Clear();
                coordy.Clear();

                for (int i = 1; i <= x; i++)
                    for (int j = 1; j <= y; j++)
                        if (btn_prop[i, j] != -1)
                        {
                            coordx.Add(i);
                            coordy.Add(j);
                        }

                int randNum = rand.Next(0, coordx.Count);
                btn_prop[coordx[randNum], coordy[randNum]] = -1;
                saved_btn_prop[coordx[randNum], coordy[randNum]] = -1;
                mines--;
            }
        }

        void StartGAYme()
        {
            switch (cbDifficulty.Text)
            {
                case "Easy":
                    mines = (int)(height * width * easyCoef);
                    break;

                case "Medium":
                    mines = (int)(height * width * mediumCoef);
                    break;

                case "Hard":
                    mines = (int)(height * width * hardCoef);
                    break;
            }

            flags = mines;
            gameover = false;

            progressBar.Value = 0;
            progressBar.Maximum = height * width - mines;

            timer.Start();
            seconds = 0;
            minutes = 0;

            lblFlags.Text = "Flags: " + flags;
            lblScore.Text = "Score: " + 0;

            if (firstPlay)
                CreateButtons(width, height);

            GenerateMap(width, height, mines);
            MapNumbering(width, height);

        }

        void ResetGAYme(int x, int y)
        {
            for (int i = 0; i <= x; i++)
                for (int j = 0; j <= y; j++)
                {
                    btn[i, j].Enabled = true;
                    btn[i, j].Text = "";
                    btn[i, j].BackgroundImage = null;
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                }
        }

        void Warnings(int id)
        {
            switch (id)
            {
                case 1:
                    MessageBox.Show("Empty Fields !");
                    break;
                case 2:
                    MessageBox.Show("Wrong Input !");
                    break;

            }
        }

        bool hasLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s, i))
                {
                    return true;
                }
            }
            return false;
        }

        bool CorrectFields()
        {
            bool result = true;

            if (tbHeight.Text == "" || tbWidth.Text == "" || cbDifficulty.Text == "")
            {
                Warnings(1);
                result = false;
            }
            else if (tbHeight.Text != "" && tbWidth.Text != "" && cbDifficulty.Text != "")
            {
                if (hasLetters(tbHeight.Text) || hasLetters(tbWidth.Text))
                {
                    Warnings(2);
                    result = false;
                }
            }

            return result;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            tbSeconds.Text = seconds.ToString();
            tbMinutes.Text = minutes.ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (CorrectFields())
            {

                SettingDimensions();
                TableMargins(height, width);

                if (firstPlay)
                {
                    StartGAYme();
                    firstPlay = false;

                    tbWidth.Enabled = false;
                    tbHeight.Enabled = false;
                    cbDifficulty.Enabled = false;
                }
                else
                if (!firstPlay)
                {
                    ResetGAYme(width, height);
                    StartGAYme();
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ResetGAYme(width, height);
                StartGAYme();
                     
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Gave up?", "Leaving...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                Application.Exit();
            }
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ResetGAYme(width, height);
            

            //da ama ne, v proces na rabota, moje i da ne stane :"D
            //tbHeight.Text = "";
            //tbWidth.Text = "";
            //tbHeight.Enabled = true;
            //tbWidth.Enabled = true;
            //tbHeight.Focus();

            //if(tbHeight.Text != "" && tbWidth.Text != "")
            //{
            //    ResetGAYme(width, height);
            //}

        }

        void SettingDimensions()
        {
            height = int.Parse(tbHeight.Text);
            width = int.Parse(tbWidth.Text);

            if (height > 25)
                height = 25;
            else
                if (height < 5)
                height = 5;

            if (width > 40)
                width = 40;
            else
                if (width < 5)
                width = 5;

            tbHeight.Text = height.ToString();
            tbWidth.Text = width.ToString();

        }

        void TableMargins(int x, int y)
        {
            start_x = (this.Size.Width - (width + 2) * distance_between) / 2;
            start_y = (this.Size.Height - (height + 2) * distance_between) / 2;
        }
    }
}