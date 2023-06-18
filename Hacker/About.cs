using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacker
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Переход по ссылке на мою страницу.
        private void linkLblKeith_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/keithadams");
        }

        //Переход по ссылке на страницу Игоря.
        private void linkLblTolyan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/tolyan_memes");
        }

        //Ссылка на страницу Маши отсутствует
        private void linkLblWife_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ссылка отсутствует...","Ошибка!");
        }

        private void linkLblYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=gBCw3kB8bDs");
        }
    }
}
