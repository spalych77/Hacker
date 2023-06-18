using System;
using System.Media;
using System.Windows.Forms;

namespace Hacker
{
    public partial class Greeting : Form
    {
        SoundPlayer Music = new SoundPlayer();
        SoundPlayer Click = new SoundPlayer();
        public Greeting()
        {
            InitializeComponent();
            Music.SoundLocation = "MatrixMainTheme.wav";
            Click.SoundLocation = "Click.wav";
            Music.PlayLooping();
        }

        //При загрузки формы включать музыку
        private void FrmHello_Load(object sender, EventArgs e)
        {
            Music.Play();
        }

        //Передаёт Player.Name значения с текстбокса.
        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            Player.Name = txtNickName.Text;
        }

        //Запускает игру.
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Click.Play();
            if ((Player.Name != "") && (Player.Name.Length < 16))
            {
                Game game = new Game();
                this.Hide();
                game.Show();

            }
            else if (Player.Name == "")
            {
                Errors error = new Errors();
                error.txtError.Text = "Вы ввели пустое значение";
                error.ShowDialog();
            }
            else
            {
                Errors error = new Errors();
                error.txtError.Text = "Ник должен быть короче 16 символов!";
                error.ShowDialog();
            }
        }

        //Открывает описание.
        private void toolStripDescription_Click(object sender, EventArgs e)
        {
            Description description = new Description();
            description.Show();
        }

        //Открывает о программе.
        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        //Подсказка при наведении.
        private void toolStripMusic_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusMenu.Text = "Музыка вкл/выкл";
        }
        private void toolStripMusic_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusMenu.Text = "";
        }

        //Подсказка при наведении.
        private void toolStripHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusMenu.Text = "Описание/О программе";
        }
        private void toolStripHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusMenu.Text = "";
        }

        // Вкл/выкл музыку
        private void toolStripMusic_Click(object sender, EventArgs e)
        {
            if (toolStripMusic.Checked == true)
            {
                toolStripMusic.Image = Hacker.Properties.Resources.sound;
                Music.Play();
            }
            else if (toolStripMusic.Checked == false)
            {
                toolStripMusic.Image = Hacker.Properties.Resources.muted;
                Music.Stop();
            }
        }
    }
}
