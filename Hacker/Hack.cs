using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacker
{
    public partial class Hack : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public Hack()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }
        
        //При загрузке формы менять лейблы ПО игрока для хака.
        private async void Hack_Load(object sender, EventArgs e)
        {
            while (true)
            {
                lblCrack.Text = Player.soft[0];
                lblMask.Text = Player.soft[1];
                lblCoolCrack.Text = Player.soft[2];
                lblCoolMask.Text = Player.soft[3];
                lblRAMScrapper.Text = Player.soft[4];
                lblBackdoor.Text = Player.soft[5];
                await Task.Delay(1);
            }
        }

        //Открывает помощь в хакерстве.
        private void btnHackHelp_Click(object sender, EventArgs e)
        {
            Click.Play();
            HackHelp hackhelp = new HackHelp();
            hackhelp.Show();
            hackhelp.FormClosed += (s, a) => btnHackHelp.Enabled = true;
            btnHackHelp.Enabled = false;
        }

        //Открывает магазин хакерского ПО
        private void btnShop_Click(object sender, EventArgs e)
        {
            Click.Play();
            HackShop hackshop = new HackShop();
            hackshop.Show();
            hackshop.FormClosed += (s, a) => btnShop.Enabled = true;
            btnShop.Enabled = false;
        }

        //Открывает хакерские задания.
        private void btnTakeTask_Click(object sender, EventArgs e)
        {
            Click.Play();
            HackTasks hacktasks = new HackTasks();
            hacktasks.Show();
            hacktasks.FormClosed += (s, a) => btnTakeTask.Enabled = true;
            btnTakeTask.Enabled = false;
            this.Close();
        }
    }
}
