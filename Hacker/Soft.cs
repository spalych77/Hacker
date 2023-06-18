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
    public partial class Soft : Form
    {
        SoundPlayer Click = new SoundPlayer();
        public Soft()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";

            this.progressBar.Maximum = 100;

            //Вкл кнопок при перезаходе в форму.
            if (Player.antivirus == 0) 
            {
                btnAntivirus.Enabled = true;
            }

            if (Player.os == 0)
            {
                btnFirstOS.Enabled = true;
            }
            else if (Player.os == PL.os[0])
            {
                btnSecondOS.Enabled = true;
            }
            else if (Player.os == PL.os[1])
            {
                btnThirdOS.Enabled = true;
            }
            else if (Player.os == PL.os[2])
            {
                btnFourthOS.Enabled = true;
            }
            else if (Player.os == PL.os[3])
            {
                btnFifthOS.Enabled = true;
            }

            if (Player.programming == 0)
            {
                btnFirstPL.Enabled = true;
            }
            else if (Player.programming == PL.programming[0])
            {
                btnSecondPL.Enabled = true;
            }
            else if (Player.programming == PL.programming[1])
            {
                btnThirdPL.Enabled = true;
            }
            else if (Player.programming == PL.programming[2])
            {
                btnFourthPL.Enabled = true;
            }
            else if (Player.programming == PL.programming[3])
            {
                btnFifthPL.Enabled = true;
            }
        }

        //Установка первой ОС.
        private async void btnFirstOS_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (!PC.Equals(Player.pc, PC.NullPC))
            {
                btnFirstOS.Enabled = false;
                btnAntivirus.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++) 
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value >= 100) 
                {
                    Player.os = PL.os[0];
                    Player.mood += 1;
                    Player.score += 10;
                    MessageBox.Show( $"Ты установил Doors 7!");
                    btnSecondOS.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show( "У тебя нет компа!");
            }
        }

        //Установка второй ОС.
        private async void btnSecondOS_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (!PC.Equals(Player.pc, PC.NullPC) && !PC.Equals(Player.pc, PC.FirstPC) && Player.programming == 1)
            {
                btnAntivirus.Enabled = false;
                btnSecondOS.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.os = PL.os[1];
                    Player.mood += 2;
                    Player.score += 15;
                    MessageBox.Show( $"Ты установил Doors 8!");
                    btnThirdOS.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else 
            {
                MessageBox.Show("Комп не потянет / не изучен предыдущий язык программирования!");
            }

        }

        //Установка третьей ОС.
        private async void btnThirdOS_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (!PC.Equals(Player.pc, PC.NullPC)  && !PC.Equals(Player.pc, PC.SecondPC) && Player.programming == 2)
            {
                btnAntivirus.Enabled = false;
                btnThirdOS.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.os = PL.os[2];
                    Player.mood += 3;
                    Player.score += 25;
                    MessageBox.Show( $"Ты установил Doors 10!");
                    btnFourthOS.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Комп не потянет / не изучен предыдущий язык программирования!!");
            }
        }

        //Установка четвёртой ОС.
        private async void btnFourthOS_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (!PC.Equals(Player.pc, PC.NullPC) && !PC.Equals(Player.pc, PC.ThirdPC) && Player.programming == 3)
            {
                btnAntivirus.Enabled = false;
                btnFourthOS.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.os = PL.os[3];
                    Player.mood += 4;
                    Player.score += 30;
                    MessageBox.Show( $"Ты установил Doors 11!");
                    btnFifthOS.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Комп не потянет / не изучен предыдущий язык программирования!!");
            }
        }

        //Установка пятой ОС.
        private async void btnFifthOS_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (!PC.Equals(Player.pc, PC.NullPC) && !PC.Equals(Player.pc, PC.FourthPC) && Player.programming == 4)
            {
                btnAntivirus.Enabled = false;
                btnFifthOS.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.os = PL.os[4];
                    MessageBox.Show( $"Ты установил Likus 666!");
                    Player.mood += 5;
                    Player.score += 35;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Комп не потянет / не изучен предыдущий язык программирования!!");
            }
        }

        //Установка первого языка программирования.
        private async void btnFirstPL_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.os > 0)
            {
                btnAntivirus.Enabled = false;
                btnFirstPL.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.programming = PL.programming[0];
                    Player.mood += 5;
                    Player.score += 20;
                    MessageBox.Show( $"Ты изучил Viper!");
                    btnSecondPL.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show( "У тебя не установлена операционка!");
            }
        }

        //Установка второго языка программирования.
        private async void btnSecondPL_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.os > 1)
            {
                btnAntivirus.Enabled = false;
                btnSecondPL.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.programming = PL.programming[1];
                    Player.mood += 10;
                    Player.score += 30;
                    MessageBox.Show( $"Ты изучил C--!");
                    btnThirdPL.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show( "Установи новую операционку!");
            }
        }

        //Установка третьего языка программирования.
        private async void btnThirdPL_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.os > 2)
            {
                btnAntivirus.Enabled = false;
                btnThirdPL.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.programming = PL.programming[2];
                    Player.mood += 15;
                    Player.score += 40;
                    MessageBox.Show( $"Ты изучил Sequel!");
                    btnFourthPL.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                 MessageBox.Show("Установи новую операционку!");
            }
        }

        //Установка четвёртого языка программирования.
        private async void btnFourthPL_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.os > 3)
            {
                btnAntivirus.Enabled = false;
                btnFourthPL.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.programming = PL.programming[3];
                    Player.mood += 20;
                    Player.score += 50;
                    MessageBox.Show( $"Ты изучил C Silly!");
                    btnFifthPL.Enabled = true;
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show( "Установи новую операционку!");
            }
        }

        //Установка пятого языка программирования.
        private async void btnFifthPL_Click(object sender, EventArgs e)
        {
            Click.Play();
            if (Player.os > 4)
            {
                btnAntivirus.Enabled = false;
                btnFifthPL.Enabled = false;
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (progressBar.Value == 100)
                {
                    Player.programming = PL.programming[4];
                    Player.mood += 30;
                    Player.score += 60;
                    MessageBox.Show( $"Ты изучил LAZARUS TURBO PASCAL!");
                    progressBar.Value = 0;
                    btnAntivirus.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show( "Установи новую операционку!");
            }
        }

        //Покупка антивируса -100$.
        private async void btnAntivirus_Click(object sender, EventArgs e)
        {
            if(Player.os > 0) 
            {
                btnAntivirus.Enabled = false;

                btnFirstOS.Enabled = false;
                btnSecondOS.Enabled = false;
                btnThirdOS.Enabled = false;
                btnFourthOS.Enabled = false;
                btnFifthOS.Enabled = false;

                btnFirstPL.Enabled = false;
                btnSecondPL.Enabled = false;
                btnThirdPL.Enabled = false;
                btnFourthPL.Enabled = false;
                btnFifthPL.Enabled = false;

                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    progressBar.Value += 1;
                    await Task.Delay(100);
                }
                if (Player.money >= 100)
                {
                    Player.antivirus = 1;
                    btnAntivirus.Enabled = false;
                    MessageBox.Show( $"Ты установил хреновенький антивирус");
                    progressBar.Value = 0;
                }
                else
                {
                    MessageBox.Show("Тебе не хватает!", "Нищий!");
                }
            }
            else 
            {
                MessageBox.Show("Сначала установи операционку!");
            }
        }
    }
}
