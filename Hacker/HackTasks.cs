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
    public partial class HackTasks : Form
    {
        SoundPlayer Click = new SoundPlayer();
        //Переменная для хранения текста задания.
        string[] tasks = new string[5]
        {
            "Взломай комп другана.\r\nУзнай как это сделать и что нужно иметь при себе у \"Заядлого хакера\"",
            "Хакни маленький банк.\r\nУзнай как это сделать и что нужно иметь при себе у \"Заядлого хакера\"",
            "Укради крутой антивирус.\r\nУзнай как это сделать и что нужно иметь при себе у \"Заядлого хакера\"",
            "Хакни крутой банк.\r\nУзнай как это сделать и что нужно иметь при себе у \"Заядлого хакера\"",
            "Взломай федералов.\r\nУзнай как это сделать и что нужно иметь при себе у \"Заядлого хакера\"",
        };
        public HackTasks()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }

        //При загрузке выводить текст задания учитывая опыт-хакерства игрока.
        private void HackTasks_Load(object sender, EventArgs e)
        {
            if (Player.experiencehack == 0)
            {
                txtTask.Text = tasks[0];
            }
            else if (Player.experiencehack == 5)
            {
                txtTask.Text = tasks[1];
            }
            else if (Player.experiencehack == 15)
            {
                txtTask.Text = tasks[2];
            }
            else if (Player.experiencehack == 30) 
            {
                txtTask.Text = tasks[3];
            }
            else if(Player.experiencehack == 50) 
            {
                txtTask.Text = tasks[4];
            }
        }

        //Запуск задания
        private void btnStartTask_Click(object sender, EventArgs e)
        {
            Click.Play();
            btnStartTask.Enabled = false;
            Missions mission = new Missions();
            this.Hide();
            mission.Show();
        }
    }
}
