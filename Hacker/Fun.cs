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
    public partial class Fun : Form
    {
        public Fun()
        {
            InitializeComponent();
        }

        //Сходить к друзьям -10$, mood+=1.5, time = 7, date[0]++ 
        private void btnFriends_Click(object sender, EventArgs e)
        {
            if(Player.money >= 10) 
            {
                Player.money -= 10;
                Player.mood += 1.5;
                Player.time = 7;
                Player.date[0]++;
                MessageBox.Show("Ты хорошо провел целый день с друзьями и твоё настроение повысилось!");
            }
            else 
            {
                MessageBox.Show("У тебя не хватает денег, даже для того, чтобы сходить с друзьями погулять!","Нищий!");
            }
        }

        //Сходить в клуб -50$, mood+=2, time = 12, date[0]++ 
        private void btnInDaClub_Click(object sender, EventArgs e)
        {
            if (Player.money >= 50)
            {
                Player.money -= 50;
                Player.mood += 5;
                Player.time = 12;
                Player.date[0]++;
                MessageBox.Show("Ты хорошо потусил целый день в клубе и твоё настроение повысилось!");
            }
            else
            {
                MessageBox.Show("У тебя не хватает денег, чтобы потусить в клубешнике!", "Нищий!");
            }
        }

        //Сыграть в дино -125$, mood+=взависимости от счёта
        private void btnDino_Click(object sender, EventArgs e)
        {
            if(Player.money >= 125) 
            {
                Player.money -= 125;
                Dino dino = new Dino();
                dino.Show();
            }
            else 
            {

                MessageBox.Show("Не видать тебе Дино(\r\nЕму нужны баксы!", "Нищий!");
            }
        }
    }
}
