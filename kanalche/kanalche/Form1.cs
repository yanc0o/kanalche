using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace kanalche
{
    public partial class Kanalche : Form
    {
        SoundPlayer magapasa;
        
        public Kanalche()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
        }
        
        private void magapasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            string videoFilePath = Path.Combine(Application.StartupPath, @"Resources\MBT - Magapassa(Pashata SOLO).mp4");
            axWindowsMediaPlayer1.URL = videoFilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void minOfPainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=ylFfm1ILW7I";


            Process.Start(youtubeUrl);
        }


        private void jaMappelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=_83AOaZ3Iyg";


            Process.Start(youtubeUrl);
        }

        private void freestyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=MHryuYVyHhk";


            Process.Start(youtubeUrl);
        }

        private void loveSosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=YWyHZNBz6FE";


            Process.Start(youtubeUrl);
        }

        private void iKnowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=X7aF3nZOS98";


            Process.Start(youtubeUrl);
        }

        private void iWannaDanceWithSomebodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=eH3giaIzONA";


            Process.Start(youtubeUrl);
        }

        private void modernLoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=cHzVjGBxOJs";


            Process.Start(youtubeUrl);
        }

        private void wonderwallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=6hzrDeceEKc";


            Process.Start(youtubeUrl);
        }

        private void smakDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=bKDdT_nyP54&list=RDQMQLuQYKf5CFU&index=2";


            Process.Start(youtubeUrl);
        }

        private void smellsLikeTeenSpiritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=hTWKbfoikeg&list=RDQMYq-DMxC65B0&index=15";


            Process.Start(youtubeUrl);
        }

        private void uptownFunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=OPf0YbXqDm0&list=PLGBuKfnErZlB3AThAEKz8_3kbYTocgfbB";


            Process.Start(youtubeUrl);
        }

        private void thriftShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=QK8mJJJvaes";


            Process.Start(youtubeUrl);
        }

        private void blindingLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=4NRXx6U8ABQ&list=PLfWTbASpwTDiVOkVmOU2QA97pFtR0fXj6";


            Process.Start(youtubeUrl);
        }

        private void lifeIsGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=l0U7SxXHkPY&list=PLfWTbASpwTDiVOkVmOU2QA97pFtR0fXj6&index=7";


            Process.Start(youtubeUrl);
        }

        private void likeThatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=N9bKBAA22Go";


            Process.Start(youtubeUrl);
        }

        private void lowLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=K_9tX4eHztY";


            Process.Start(youtubeUrl);
        }

        private void dnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=NLZRYQMLDW4";


            Process.Start(youtubeUrl);
        }

        private void n95ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=zI383uEwA6Q";


            Process.Start(youtubeUrl);
        }

        private void kazahNeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=IBJtN6xz-SM";


            Process.Start(youtubeUrl);
        }

        private void tsigancheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=i_mPzU2_72E";


            Process.Start(youtubeUrl);
        }

        private void kartishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=Xy5j9KJ8Jbc";


            Process.Start(youtubeUrl);
        }

        private void chalgaPeperudkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=uzHKG86K1ps";


            Process.Start(youtubeUrl);
        }

        private void dickeTittenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=thJgU9jkdU4";


            Process.Start(youtubeUrl);
        }

        private void thunderstuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=v2AC41dglnM";


            Process.Start(youtubeUrl);
        }

        private void loosingItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=o3WdLtpWM_c";


            Process.Start(youtubeUrl);
        }

        private void voisSurTonCheminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=f4gODZFkTJg";


            Process.Start(youtubeUrl);
        }

        private void cheekyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=Dcm8B2v2uAs";


            Process.Start(youtubeUrl);
        }

        private void mwakiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=y6iMvNkAQt4";


            Process.Start(youtubeUrl);
        }

        private void greedyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=To4SWGZkEPk";


            Process.Start(youtubeUrl);
        }

        private void trainingSeasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=ZjBZ8MUnB0E";


            Process.Start(youtubeUrl);
        }

        private void какоНиколинкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=TgtPMtuUEho&list=PLbLrDi47pV_GHD-DIlldr6U_DNlQRsFJh&index=5";


            Process.Start(youtubeUrl);
        }

        private void хороводнаКиткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string youtubeUrl = "https://www.youtube.com/watch?v=xBDO9tmfwT0&list=PLbLrDi47pV_GHD-DIlldr6U_DNlQRsFJh&index=6";


            Process.Start(youtubeUrl);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
