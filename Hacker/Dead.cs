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
using Hacker;

namespace Hacker
{
    public partial class Dead : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public Dead()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }

        private void Dead_Load(object sender, EventArgs e)
        {
            lblDeath.Text = $"У Вас не осталось денег и Ваше настроение опустилось ниже нуля.\nВы дожили до: {Player.time}:00 {Player.date[0]}.{Player.date[1]}.{Player.date[2]}\nХотите попробовать ещё раз?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Click.Play();
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Click.Play();
            Application.Exit();
        }
        private void Dead_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
