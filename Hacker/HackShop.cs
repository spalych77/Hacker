using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacker
{
    public partial class HackShop : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public HackShop()
        {
            InitializeComponent();

            Click.SoundLocation = "Click.wav";
        }
        private void HackShop_Load(object sender, EventArgs e)
        {
            //Условия для покупки того или иного иструмента взлома(включение кнопки,менять текстбокс)
            if (Player.experiencehack == 0 && Player.soft[0] == "1.Отсутствует")
            {
                txtShop.Text = "Твой опыт в хакерстве маловат!" +
                    "\r\nТы можешь позволить себе крякалку простых паролей за 75$";
                btnBuy.Text += " 75$";
                btnBuy.Enabled = true;
            }
            else if (Player.experiencehack == 5 && Player.soft[1] == "2.Отсутствует" && Player.soft[2] == "3.Отсутствует")
            {
                txtShop.Text = "Твой опыт в хакерстве позволяет тебе купить 2 вещи!" +
                    "\r\nТы можешь купить маскировку хакерских атак и крякалку сложных паролей за 250$";
                btnBuy.Text += " 250$";
                btnBuy.Enabled = true;
            }
            else if (Player.experiencehack == 15 && Player.soft[3] == "4.Отсутствует" && Player.soft[4] == "5.Отсутствует")
            {
                txtShop.Text = "Твой опыт в хакерстве позволяет тебе купить 2 вещи!" +
                    "\r\nТы можешь купить крутую маскировку хакерских атак и RAM Scrapper за 350$";
                btnBuy.Text += " 350$";
                btnBuy.Enabled = true;
            }
            else if (Player.experiencehack == 30 && Player.soft[5] == "6.Отсутствует")
            {
                txtShop.Text = "Твой хакерский опыт равен 30! Ты можешь купить книгу про Бэкдор!" +
                    "\r\nЦена книги про Бэкдор - 300$";
                btnBuy.Text += " 500$";
                btnBuy.Enabled = true;
            }
            else
            {
                txtShop.Text = "Вы уже приобрели доступный инструмент для хакерства!";
                btnBuy.Text = "";
            }
        }
        //Покупка того или иного иструмента взлома. -money +player.soft
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Click.Play();
            if(Player.experiencehack == 0 && Player.money >= 75) 
            {
                Player.money -= 75;
                Player.soft[0] = "Крякалка простых паролей";
                MessageBox.Show("Ты приобрел Крякалку простых паролей");
                btnBuy.Enabled = false;
            }
            else if (Player.experiencehack == 5 && Player.money >= 250)
            {
                Player.money -= 250;
                Player.soft[1] = "Маскировка хакерских атак";
                Player.soft[2] = "Крякалка сложных паролей";
                MessageBox.Show("Ты приобрел Маскировку хакерских атак и Крякалку сложных паролей");
                btnBuy.Enabled = false;
            }
            else if (Player.experiencehack == 15 && Player.money >= 350)
            {
                Player.money -= 350;
                Player.soft[3] = "Крутая маскировка хакерских атак";
                Player.soft[4] = "RAM Scrapper";
                MessageBox.Show("Ты приобрел крутую маскировку хакерских атак RAM Scrapper!");
                btnBuy.Enabled = false;
            }
            else if (Player.experiencehack == 30 && Player.money >= 500)
            {
                Player.money -= 500;
                Player.soft[5] = "Бэкдор";
                MessageBox.Show("Ты приобрел книгу про Бэкдор!");
                btnBuy.Enabled = false;
            }
            else
            {
                MessageBox.Show("Тебе не хватает!", "Нищий!");
            }
        }
    }
}
