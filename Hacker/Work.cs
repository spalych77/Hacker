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
    public partial class Work : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public Work()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";

            //Вкл кнопок при условиях.
            if (Player.work < 1) 
            {
                btnJanitor.Enabled = true;
            }
            else if(Player.work == 1) 
            {
                btnLoader.Enabled = true;
            }
            else if(Player.work == 2) 
            {
                btnSeller.Enabled = true;
            }
            else if(Player.work == 3) 
            {
                btnJunior.Enabled = true;
            }
            else if(Player.work == 4) 
            {
                btnMiddle.Enabled = true;
            }
            else if (Player.work == 5)
            {
                btnSenior.Enabled = true;
            }
        }
        //Устройство на первую работу(Дворник)
        private void btnJanitor_Click(object sender, EventArgs e)
        {
            Click.Play();
            Player.work = 1;
            btnJanitor.Enabled = false;
            txtWork.Text = "Ты можешь устроиться на любую работу..." +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - ДВОРНИК!" +
                "\r\n\r\nЗарпалата составляет: 50$/день";
            btnLoader.Enabled = true;
            MessageBox.Show("Поздравляю, теперь ты - ДВОРНИК. Твоя зарплата составляет: 50$/день");
        }

        //Устройство на вторую работу(Грузчик)
        private void btnLoader_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.status >= 1)
            {
                Player.work = 2;
                btnLoader.Enabled = false;
                txtWork.Text = "Ты можешь устроиться на любую работу" +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - ГРУЗЧИК!" +
                "\r\n\r\nЗарпалата составляет: 75$/день";
                btnSeller.Enabled = true;
                MessageBox.Show("Поздравляю, теперь ты - ГРУЗЧИК. Твоя зарплата составляет: 75$/день");
            }
            else 
            {
                MessageBox.Show("Твой статус не позволяет!","Ой-ой..");
            }
            
        }

        //Устройство на третью работу(Кассир)
        private void btnSeller_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.status >= 2)
            {
                Player.work = 3;
                btnSeller.Enabled = false;
                txtWork.Text = "Ты можешь устроиться на любую работу" +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - КАССИР!" +
                "\r\n\r\nЗарпалата составляет: 100$/день";
                btnJunior.Enabled = true;
                MessageBox.Show("Поздравляю, теперь ты - КАССИР. Твоя зарплата составляет: 100$/день");
            }
            else
            {
                MessageBox.Show("Твой статус не позволяет!", "Ой-ой..");
            }
        }

        //Устройство на четвертую работу(Джун)
        private void btnJunior_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.status >= 3)
            {
                Player.work = 4;
                btnJunior.Enabled = false;
                txtWork.Text = "Ты можешь устроиться на любую работу..." +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - ПРОГРАММИСТ(джун)!" +
                "\r\n\r\nЗарпалата составляет: 125$/день";
                btnMiddle.Enabled = true;
                MessageBox.Show("Поздравляю, теперь ты - ПРОГРАММИСТ(джун). Твоя зарплата составляет: 125$/день");
            }
            else
            {
                MessageBox.Show("Твой статус не позволяет!", "Ой-ой..");    
            }
        }

        //Устройство на пятую работу(Мидл)
        private void btnMiddle_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.status >= 4)
            {
                Player.work = 5;
                btnMiddle.Enabled = false;
                txtWork.Text = "Ты можешь устроиться на любую работу..." +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - ПРОГРАММИСТ(мидл)!" +
                "\r\n\r\nЗарпалата составляет: 150$/день";
                btnSenior.Enabled = true;
                MessageBox.Show("Поздравляю, теперь ты - ПРОГРАММИСТ(мидл). Твоя зарплата составляет: 150$/день");
            }
            else
            {
                MessageBox.Show("Твой статус не позволяет!", "Ой-ой..");
            }
        }

        //Устройство на шестую работу(Сеньор)
        private void btnSenior_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.status >= 5)
            {
                Player.work = 6;
                btnSenior.Enabled = false;
                txtWork.Text = "Ты можешь устроиться на любую работу..." +
                "\r\n\r\nЕсли конечно же твой статус это позволяет!" +
                "\r\n\r\n\r\nНа данный момент ты - ПРОГРАММИСТ(сеньор)!" +
                "\r\n\r\nЗарпалата составляет: 175$/день";
                MessageBox.Show("Поздравляю, теперь ты - ПРОГРАММИСТ(сеньор). Твоя зарплата составляет: 175$/день");
            }
            else
            {
                MessageBox.Show("Твой статус не позволяет!", "Ой-ой..");
            }
        }
    }
}
