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
    public partial class Loan : Form
    {
        //Переменная для записи даты, когда игрок взял кредит.
        public static int datePenkovv;
        public static int dateOmega;
        public static int dateTrata;
        public static int dateZakritie;
        public static int dateRosKolhoz;

        SoundPlayer Click = new SoundPlayer();
        public Loan()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";

            //Включение кнопок взять кредит, если у игрока есть кредит.
            if (Player.loans[0] == 0) 
            {
                btnTakePenkovv.Enabled = true;
            }
            if (Player.loans[1] == 0) 
            {
                btnTakeOmega.Enabled = true;
            }
            if (Player.loans[2] == 0)
            {
                btnTakeTrata.Enabled = true;
            }
            if (Player.loans[3] == 0)
            {   
                btnTakeZakritie.Enabled = true;
            }
            if (Player.loans[4] == 0)
            {
                btnTakeRosKolhoz.Enabled = true;
            }

            //Включение кнопок погасить кредит, если кнопки взять кредит выключены.
            if (!btnTakePenkovv.Enabled)
            {
                btnEndPenkovv.Enabled = true;
            }
            if (!btnTakeOmega.Enabled)
            {
                btnEndOmega.Enabled = true;
            }
            if (!btnTakeTrata.Enabled)
            {
                btnEndTrata.Enabled = true;
            }
            if (!btnTakeZakritie.Enabled)
            {
                btnEndZakritie.Enabled = true;
            }
            if (!btnTakeRosKolhoz.Enabled)
            {
                btnEndRosKolhoz.Enabled = true;
            }
        }

        //Взять какой-либо кредит.(Используется 1 обработчик для всех кнопок(Игор Н.))
        private void btnTakeLoan_Click(object sender, EventArgs e)
        {
            Click.Play();
            if ((sender as Button).Name == "btnTakePenkovv")
            {
                datePenkovv = Player.date[0];
                Player.loans[0] = 100;
                Player.money += 100;
                btnTakePenkovv.Enabled = false;
                MessageBox.Show("Вам выдан кредит на сумму 100$! Погасите его как можно скорее, иначе...");
            }
            else if((sender as Button).Name == "btnTakeOmega") 
            {
                dateOmega = Player.date[0];
                Player.loans[1] = 125;
                Player.money += 125;
                btnTakeOmega.Enabled = false;
                MessageBox.Show("Вам выдан кредит на сумму 125$! Погасите его как можно скорее, иначе...");
            }
            else if ((sender as Button).Name == "btnTakeTrata")
            {
                dateTrata = Player.date[0];
                Player.loans[2] = 150;
                Player.money += 150;
                btnTakeTrata.Enabled = false;
                MessageBox.Show("Вам выдан кредит на сумму 150$! Погасите его как можно скорее, иначе...");
            }
            else if ((sender as Button).Name == "btnTakeZakritie")
            {
                dateZakritie = Player.date[0];
                Player.loans[3] = 175;
                Player.money += 175;
                btnTakeZakritie.Enabled = false;
                MessageBox.Show("Вам выдан кредит на сумму 175$! Погасите его как можно скорее, иначе...");
            }
            else if ((sender as Button).Name == "btnTakeRosKolhoz")
            {
                dateRosKolhoz = Player.date[0];
                Player.loans[4] = 200;
                Player.money += 200;
                btnTakeRosKolhoz.Enabled = false;
                MessageBox.Show("Вам выдан кредит на сумму 200$! Погасите его как можно скорее, иначе...");
            }
        }

        //Погасить какой-либо кредит.(Используется 1 обработчик для всех кнопок(Игор Н.))
        private void btnEndLoan_Click(object sender, EventArgs e)
        {
            Click.Play();
            if ((sender as Button).Name == "btnEndPenkovv")
            {
                if (Player.money >= 100)
                {
                    datePenkovv = 0;
                    Player.loans[0] = 0;
                    Player.money -= 100;
                    btnEndPenkovv.Enabled = false;
                    MessageBox.Show("Поздравляем! Вы погасили кредит и коллекторы к Вам не придут");
                }
                else
                {
                    MessageBox.Show("У Вас не хватает денег для погашения долга!");
                }
            }
            else if ((sender as Button).Name == "btnEndOmega")
            { 
                 if (Player.money >= 125)
                 {
                    dateOmega = 0;
                    Player.loans[1] = 0;
                    Player.money -= 125;
                    btnEndOmega.Enabled = false;
                    MessageBox.Show("Поздравляем! Вы погасили кредит и коллекторы к Вам не придут");
                 }
                 else
                 {
                    MessageBox.Show("У Вас не хватает денег для погашения долга!");
                 }
            }
            else if ((sender as Button).Name == "btnEndTrata")
            {
                 if (Player.money >= 150)
                 {
                    dateTrata = 0;
                    Player.loans[2] = 0;
                    Player.money -= 150;
                    btnEndTrata.Enabled = false;
                    MessageBox.Show("Поздравляем! Вы погасили кредит и коллекторы к Вам не придут");
                 }
                 else
                 {
                    MessageBox.Show("У Вас не хватает денег для погашения долга!");
                 }
            }
            else if ((sender as Button).Name == "btnEndZakritie")
            {
                 if (Player.money >= 175)
                 {
                    dateZakritie = 0;
                    Player.loans[3] = 0;
                    Player.money -= 175;
                    btnEndZakritie.Enabled = false;
                    MessageBox.Show("Поздравляем! Вы погасили кредит и коллекторы к Вам не придут");
                 }
                 else
                 {
                    MessageBox.Show("У Вас не хватает денег для погашения долга!");
                 }
            }
            else if ((sender as Button).Name == "btnEndRosKolhoz")
            {
                 if (Player.money >= 200)
                 {
                    dateRosKolhoz = 0;
                    Player.loans[4] = 0;
                    Player.money -= 200;
                    btnEndRosKolhoz.Enabled = false;
                    MessageBox.Show("Поздравляем! Вы погасили кредит и коллекторы к Вам не придут");
                 }
                 else
                 {
                    MessageBox.Show("У Вас не хватает денег для погашения долга!");
                 }
            }
        }
    }
}
