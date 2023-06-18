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
    public partial class Mining : Form
    {
        //Переменные для выбора коина.
        int HC = 0;
        int KF = 0;
        int BK = 0;
        public Mining()
        {
            InitializeComponent();

            //Включение кнопок взависимости от статуса и дня.
            if (Player.status == 3 && (Player.date[0] % 7) ==  0)
            {
                btnHackerCoin.Enabled = true;
            }
            else if (Player.status == 4 && (Player.date[0] % 7) == 0)
            {
                btnKefirium.Enabled = true;
            }
            else if (Player.status == 5 && (Player.date[0] % 7) == 0)
            {
                btnBitok.Enabled = true;
            }
        }

        //Выбор крипты. Включение кнопки майнинга и изменение её названия, и выключение кнопки крипты.
        private void btnHackerCoin_Click(object sender, EventArgs e)
        {
            btnMining.Enabled = true;
            btnHackerCoin.Enabled = false;
            btnMining.Text = "МАЙНИТЬ HackerCoin";
            progressBar.Maximum = 30;
            HC = 1;
            KF = 0;
            BK = 0;
            
        }

        //Выбор крипты. Включение кнопки майнинга и изменение её названия, и выключение кнопки крипты.
        private void btnKefirium_Click(object sender, EventArgs e)
        {
            btnMining.Enabled = true;
            btnKefirium.Enabled = false;
            btnMining.Text = "МАЙНИТЬ Kefirium";
            progressBar.Maximum = 40;
            HC = 0;
            KF = 1;
            BK = 0;

        }

        //Выбор крипты. Включение кнопки майнинга и изменение её названия, и выключение кнопки крипты.
        private void btnBitok_Click(object sender, EventArgs e)
        {
            btnMining.Enabled = true;
            btnBitok.Enabled = false;
            btnMining.Text = "МАЙНИТЬ Bitok";
            progressBar.Maximum = 50;
            HC = 0;
            KF = 0;
            BK = 1;
        }

        //Майнинг крипты. Для 1 коина 30 нажатий, для 2 - 40, для 3 - 50
        private void btnMining_Click(object sender, EventArgs e)
        {
            if (HC == 1) 
            {
                progressBar.Value += 1;
                txtMining.Text += "Майни-майни-майни этот злополучный койн!\n";
                if (progressBar.Value == 30) 
                {
                    Player.score += 5;
                    Player.coins[0] += 1;
                    btnMining.Enabled = false;
                    txtMining.Text = "+1 HackerCoin в вашем крипто-кошельке";
                    MessageBox.Show("Вы намайнили 1 HackerCoin");
                }
            }
            else if (KF == 1)
            {
                txtMining.Text += "Майни-майни-майни этот злополучный койн!\n";
                progressBar.Value += 1;
                if (progressBar.Value == 40)
                {
                    Player.score += 10;
                    Player.coins[1] += 1;
                    btnMining.Enabled = false;
                    txtMining.Text = "+1 Kefirium в вашем крипто-кошельке";
                    MessageBox.Show("Вы намайнили 1 Kefirium");
                }
            }
            else if (BK == 1)
            {
                txtMining.Text += "Майни-майни-майни этот злополучный койн!\n";
                progressBar.Value += 1;
                if (progressBar.Value == 50)
                {
                    Player.score += 15;
                    Player.coins[2] += 1;
                    btnMining.Enabled = false;
                    txtMining.Text = "+1 Kefirium в вашем крипто-кошельке";
                    MessageBox.Show("Вы намайнили 1 Bitok");
                }
            }
        }
    }
}
