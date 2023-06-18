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
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        //Переход по ссылке.
        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://disk.yandex.ru/a/z7xPJBSUxCBGfw");
        }
    }
}
