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
    public partial class Errors : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public Errors()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }

        //Закрытие формы.
        private void btnError_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.Close();
        }
    }
}
