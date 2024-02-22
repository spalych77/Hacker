using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hacker;

namespace Hacker
{
    public partial class Game : Form
    {
        //Клик.вав
        SoundPlayer Click = new SoundPlayer();

        //Музыка.вав
        SoundPlayer Music = new SoundPlayer();

        //Подсказки при наведении.
        ToolTip hint = new ToolTip();

        //Рандом и переменная для вируса.
        Random rand = new Random();
        int num = 0;
        public Game()
        {
            InitializeComponent();

            //Изменение названия формы в зависимости от имени игрока.
            this.Text = $"Хакер - {Player.Name}";
            Click.SoundLocation = "Click.wav";
            Music.SoundLocation = "Game.wav";
        }
        
        private async void Game_Load(object sender, EventArgs e)
        {
            //Вкл музыки.
            //Music.PlayLooping();

            //Начало игры. Приветствие с игроком.
            MessageBox.Show(Player.hello, "Приветствуем!");

            //Цикл завершения игры.
            while (Player.isAlive != 0)
            {
                //Нападение вируса.
                if (!PC.Equals(Player.pc, PC.NullPC)) 
                {
                    num = rand.Next(1, 10);
                    if (num == 5)
                    {
                        MessageBox.Show("На компе появился слабенький вирус! Убить гада?",
                            "Вирус!", MessageBoxButtons.YesNo);
                        if (MessageBox.Show("На компе появился слабенький вирус! Убить гада?",
                            "Вирус!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (Player.antivirus >= 1)
                            {
                                MessageBox.Show("Вирус повержен!", "Не стоит беспокоиться");
                            }
                            else
                            {
                                Player.money -= (Player.money * (2 / 10));
                                MessageBox.Show("Дык у тебя нет антивируса!", "Вирус пробрался в твой интернет-банк и украл немного денег!");
                            }
                        }
                        else
                        {
                            Player.money -= (Player.money * (2 / 10));
                        }
                    }
                    else if (num == 10)
                    {
                        MessageBox.Show("На компе появился серьёзный вирус! Убить гада?",
                            "Вирус!", MessageBoxButtons.YesNo);
                        if (MessageBox.Show("На компе появился серьёзный вирус! Убить гада?",
                            "Вирус!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (Player.antivirus == 2)
                            {
                                MessageBox.Show("Вирус повержен!", "Не стоит беспокоиться");
                            }
                            else
                            {
                                Player.money -= (Player.money * (1 / 2));
                                MessageBox.Show("Дык у тебя нет крутого антивируса!", "Вирус пробрался в твой интернет-банк и украл половину денег!");
                            }
                        }
                        else
                        {
                            Player.money -= (Player.money * (1 / 2));
                        }
                    }
                }

                //Победа игрока если все задания были выполнены..
                if (Player.successHacks == 5 && Player.status >= 3)
                {
                    break;
                }

                //Цикл времени.
                for (Player.time = 0; Player.time <= 23; Player.time++)
                {
                    //Смена лейбла времени и даты.
                    lblTime.Text = $"Время {Player.time}:00 Дата {Player.date[0]}.{Player.date[1]}.{Player.date[2]}";

                    //Смена дня +ЗП.
                    if (Player.time == 0)
                    {
                        Player.date[0]++;
                        if (Player.work == 1)
                        {
                            Player.money += 50;
                        }
                        else if (Player.work == 2)
                        {
                            Player.money += 75;
                        }
                        else if (Player.work == 3)
                        {
                            Player.money += 100;
                        }
                        else if (Player.work == 4)
                        {
                            Player.money += 125;
                        }
                        else if (Player.work == 5)
                        {
                            Player.money += 150;
                        }
                        else if (Player.work == 6)
                        {
                            Player.money += 175;
                        }
                    }

                    //Если настроение меньше нуля и деньги равны 0, то игрок умирает.
                    if (Player.mood < 0 && Player.money == 0)
                    {
                        Player.isAlive = 0;
                        break;
                    }

                    //Смена месяца/года(учитывая, что не в каждом месяца 31 день и не каждый год високосный)
                    if (Player.date[0] >= 32 && (Player.date[1] == 1 || Player.date[1] == 3 || Player.date[1] == 5 || Player.date[1] == 7 || Player.date[1] == 8 || Player.date[1] == 10))
                    {
                        Player.date[0] = 1;
                        Player.date[1] = Player.date[1] + 1;
                    }
                    else if (Player.date[0] >= 29 && Player.date[1] == 2 && Player.date[2] % 4 == 0)
                    {
                        Player.date[0] = 1;
                        Player.date[1] = 3;
                    }
                    else if (Player.date[0] >= 30 && Player.date[1] == 2 && Player.date[2] % 4 != 0)
                    {
                        Player.date[0] = 1;
                        Player.date[1] = 3;
                    }
                    else if (Player.date[0] >= 31 && (Player.date[1] == 4 || Player.date[1] == 6 || Player.date[1] == 9 || Player.date[1] == 11))
                    {
                        Player.date[0] = 1;
                        Player.date[1] = Player.date[1] + 1;
                    }
                    else if (Player.date[0] >= 32 && Player.date[1] >= 12)
                    {
                        Player.date[0] = 1;
                        Player.date[1] = 1;
                        Player.date[2] += 1;
                    }


                    //Далее.. Стастистика игрока:
                    //Каждый "час" уменьшать настроение на 0.
                    Player.mood -= 0.5;

                    //Смена лейбла настроения игрока и его "аватарка".
                    if (Player.mood < 0)
                    {
                        lblMood.Text = $"При смерти";
                        picBoxFace.Image = Hacker.Properties.Resources.DeadFace;
                    }
                    else if ((Player.mood > 0) && (Player.mood < 100))
                    {
                        lblMood.Text = $"Ужасное";
                        picBoxFace.Image = Hacker.Properties.Resources.SadlyFace;
                    }
                    else if ((Player.mood > 100) && (Player.mood < 200))
                    {
                        lblMood.Text = $"Нормальное";
                        picBoxFace.Image = Hacker.Properties.Resources.NormalFace;
                    }
                    else if (Player.mood > 200)
                    {
                        lblMood.Text = $"Отличное";
                        picBoxFace.Image = Hacker.Properties.Resources.HappyFace;
                    }

                    //Смена лейбла статуса и сам статус.
                    if (Player.score >= 36 && Player.score < 93)
                    {
                        Player.status = 1;
                        lblStatus.Text = "Обыватель";
                    }
                    else if (Player.score >= 93 && Player.score < 176)
                    {
                        Player.status = 2;
                        lblStatus.Text = "Новичок";
                    }
                    else if (Player.score >= 176 && Player.score < 280)
                    {
                        Player.status = 3;
                        lblStatus.Text = "Юзер";
                    }
                    else if (Player.score >= 280 && Player.score < 405)
                    {
                        Player.status = 4;
                        lblStatus.Text = "Прошаренный";
                    }
                    else if (Player.score >= 405 && Player.score < 1000)
                    {
                        Player.status = 5;
                        lblStatus.Text = "Программист";
                    }

                    //Смена лейбла денег игрока.
                    lblMoney.Text = $"{Player.money}$";

                    //Смена лейбла счёта игрока.
                    lblScore.Text = $"{Player.score}";

                    ////Смена лейблов кредитов игрока.
                    if (Player.loans[0] == 100)
                    {
                        lblPenkovv.Text = "100$";
                    }
                    if (Player.loans[1] == 125)
                    {
                        lblOmega.Text = "125$";
                    }
                    if (Player.loans[2] == 150)
                    {
                        lblTrata.Text = "150$";
                    }
                    if (Player.loans[3] == 175)
                    {
                        lblZakritie.Text = "125$";
                    }
                    if (Player.loans[4] == 200)
                    {
                        lblRosKolhoz.Text = "200$";
                    }

                    //Смена лейбла работы.
                    if(Player.work == 0) 
                    {
                        lblWork.Text = "Безработный. 0$/час";
                    }
                    else if (Player.work == 1)
                    {
                        lblWork.Text = "Дворник. 50$/час";
                    }
                    else if (Player.work == 2)
                    {
                        lblWork.Text = "Грузчик. 75$/час";
                    }
                    else if (Player.work == 3)
                    {
                        lblWork.Text = "Кассир. 100$/час";
                    }
                    else if (Player.work == 4)
                    {
                        lblWork.Text = "Джун. 125$/час";
                    }
                    else if (Player.work == 5)
                    {
                        lblWork.Text = "Мидл. 150$/час";
                    }
                    else if (Player.work == 6)
                    {
                        lblWork.Text = "Сеньор. 175$/час";
                    }

                    //Смена лейбла крипты.
                    lblCrypto.Text = $"HackerCoin: {Player.coins[0]} Kefirium: {Player.coins[1]} Bitok: {Player.coins[2]}";

                    //Смена картинки компа.
                    if(PC.Equals(Player.pc, PC.NullPC)) 
                    {
                        lblBody.Text = "Отсутствует";
                        lblMother.Text = "Отсутствует";
                        lblCPU.Text = "Отсутствует";
                        lblRAM.Text = "Отсутствует";
                        lblGPU.Text = "Отсутствует";
                        lblDisk.Text = "Отсутствует";
                        pictureBoxPC.Image = Hacker.Properties.Resources.NullPC;
                    }
                    else if (PC.Equals(Player.pc, PC.FirstPC))
                    {
                        lblBody.Text = "Бабкина коробка";
                        lblMother.Text = "Бабкина мать";
                        lblCPU.Text = "Бабкино сердце";
                        lblRAM.Text = "Бабкина память";
                        lblGPU.Text = "Бабкин вентилятор";
                        lblDisk.Text = "Бабкин диск";
                        pictureBoxPC.Image = Hacker.Properties.Resources.FirstPC;
                    }
                    else if (PC.Equals(Player.pc, PC.SecondPC))
                    {
                        lblBody.Text = "Офисный корпус";
                        lblMother.Text = "Офисная материнка";
                        lblCPU.Text = "Офисный проц";
                        lblRAM.Text = "Офисная оператива";
                        lblGPU.Text = "Офисная видюха";
                        lblDisk.Text = "Офисный хдд";
                        pictureBoxPC.Image = Hacker.Properties.Resources.SecondPC;
                    }
                    else if (PC.Equals(Player.pc, PC.ThirdPC))
                    {
                        lblBody.Text = "Корпус юзера";
                        lblMother.Text = "Материнка юзера";
                        lblCPU.Text = "Проц юзера";
                        lblRAM.Text = "Оператива юзера";
                        lblGPU.Text = "Видюха юзера";
                        lblDisk.Text = "Хдд юзера";
                        pictureBoxPC.Image = Hacker.Properties.Resources.ThirdPC;
                    }
                    else if (PC.Equals(Player.pc, PC.FourthPC))
                    {
                        lblBody.Text = "Игровой корпус";
                        lblMother.Text = "Игровая материнка";
                        lblCPU.Text = "Игровой проц";
                        lblRAM.Text = "Игровая оператива";
                        lblGPU.Text = "Игровая видюха";
                        lblDisk.Text = "Игровой ссд";
                        pictureBoxPC.Image = Hacker.Properties.Resources.FourthPC;
                    }
                    else if (PC.Equals(Player.pc, PC.FifthPC))
                    {
                        lblBody.Text = "Топовый корпус";
                        lblMother.Text = "Топовая материнка";
                        lblCPU.Text = "Топовый проц";
                        lblRAM.Text = "Топовая оператива";
                        lblGPU.Text = "Топовая видюха";
                        lblDisk.Text = "Топовый ссд и хдд";
                        pictureBoxPC.Image = Hacker.Properties.Resources.FifthPC;
                    }

                    //Смена ОС игрока.
                    if (Player.os == 0) 
                    {
                        lblOS.Text = "Отсутствует";
                    }
                    else if (Player.os == 1) 
                    {
                        lblOS.Text = "Doors 7";
                    }
                    else if (Player.os == 2)
                    {
                        lblOS.Text = "Doors 8";
                    }
                    else if (Player.os == 3)
                    {
                        lblOS.Text = "Doors 10";
                    }
                    else if (Player.os == 4)
                    {
                        lblOS.Text = "Doors 11";
                    }
                    else if (Player.os == 5)
                    {
                        lblOS.Text = "Likus 666";
                    }

                    //Смена лейбла языка программирования игрока.
                    if (Player.programming == 0) 
                    {
                        lblPL.Text = "Отсутствует";
                    }
                    else if (Player.programming == 1)
                    {
                        lblPL.Text = "Viper";
                    }
                    else if (Player.programming == 2)
                    {
                        lblPL.Text = "C--";
                    }
                    else if (Player.programming == 3)
                    {
                        lblPL.Text = "Sequel";
                    }
                    else if (Player.programming == 4)
                    {
                        lblPL.Text = "C Silly";
                    }
                    else if (Player.programming == 5)
                    {
                        lblPL.Text = "LAZARUS TURBO PASCAL";
                    }

                    //Смена лейбла антивируса.
                    if (Player.antivirus == 0)
                    {
                        lblAntivirus.Text = "Отсутствует";
                    }
                    else if (Player.antivirus == 1) 
                    {
                        lblAntivirus.Text = "Хреновенький";
                    }
                    else if (Player.antivirus == 2) 
                    {
                        lblAntivirus.Text = "Хакерский";
                    }

                    //Если игрок задолжал кредит какому-нибудь банку на срок более 7 дней, то игра заканчивается.
                    if (Loan.datePenkovv + 6 == Player.date[0] && Loan.datePenkovv != 0) 
                    {
                        Player.notRepay();
                        break;                       
                    }
                    if (Loan.dateOmega + 6 == Player.date[0] && Loan.dateOmega != 0)
                    {
                        Player.notRepay();
                        break;
                    }
                    if (Loan.dateTrata + 6 == Player.date[0] && Loan.dateTrata != 0)
                    {
                        Player.notRepay();
                        break;
                    }
                    if (Loan.dateZakritie + 6 == Player.date[0] && Loan.dateZakritie != 0)
                    {
                        Player.notRepay();
                        break;
                    }
                    if (Loan.dateRosKolhoz + 6 == Player.date[0] && Loan.dateRosKolhoz != 0)
                    {
                        Player.notRepay();
                        break;
                    }
                    
                    //Включение кнопок хакерства и майнинга при должном статусе.
                    if (Player.status >= 3)
                    {
                        btnOpenMining.Enabled = true;
                        btnOpenHack.Enabled = true;
                    }

                    //Смена лейбла лучшего счёта в "Дино".
                    lblBestDino.Text = $"{Player.bestDino}";

                    //Задержка времени.
                    await Task.Delay(1000);
                }
            }

            //Если игрок умер.
            if(Player.isAlive == 0) 
            {
                Dead dead = new Dead();
                dead.ShowDialog();
            }

            //Если игрок победил.
            this.Enabled = false;
            Win win = new Win();
            win.Show();
            
        }

        //Открыть форму с работой.
        private void btnOpenWork_Click(object sender, EventArgs e)
        {
            //.Play();
            Work work = new Work();
            work.Show();
            work.FormClosed += (s, a) => btnOpenWork.Enabled = true;
            btnOpenWork.Enabled = false;
        }

        //Конвертация крипты в деньги
        private void btnConvertCoins_Click(object sender, EventArgs e)
        {
            //Play();
            Player.money += (Player.coins[0] * 100);
            Player.money += (Player.coins[1] * 125);
            Player.money += (Player.coins[2] * 150);
        }

        //Открыть форму с хакерством.
        private void btnOpenHack_Click(object sender, EventArgs e)
        {
            //Play();
            Hack hack = new Hack();
            hack.Show();
            hack.FormClosed += (s, a) => btnOpenHack.Enabled = true;
            btnOpenHack.Enabled = false;
        }

        //Открыть форму с развлеченями.
        private void btnOpenFun_Click(object sender, EventArgs e)
        {
            //Play();
            Fun fun = new Fun();
            fun.Show();
            fun.FormClosed += (s, a) => btnOpenFun.Enabled = true;
            btnOpenFun.Enabled = false;
        }

        //Открыть форму магазина компьютеров.
        private void btnOpenShop_Click(object sender, EventArgs e)
        {
            //Play();
            DNS dns = new DNS();
            dns.Show();
            dns.FormClosed += (s, a) => btnOpenShop.Enabled = true;
            btnOpenShop.Enabled = false;
        }

        //Открыть форму с майнингом
        private void btnOpenMining_Click(object sender, EventArgs e)
        {
            //Play();
            Mining mining = new Mining();
            mining.Show();
            mining.FormClosed += (s, a) => btnOpenMining.Enabled = true;
            btnOpenMining.Enabled = false;
        }

        //Открыть форму с софтом.
        private void btnOpenSoft_Click(object sender, EventArgs e)
        {
            //Play();
            Soft soft = new Soft();
            soft.Show();
            soft.FormClosed += (s, a) => btnOpenSoft.Enabled = true;
            btnOpenSoft.Enabled = false;
        }

        //Открыть форму с кредитами
        private void btnOpenLoan_Click(object sender, EventArgs e)
        {
            //Play();
            Loan loan = new Loan();
            loan.Show();
            loan.FormClosed += (s, a) => btnOpenLoan.Enabled = true;
            btnOpenLoan.Enabled = false;
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
        private void picBoxFace_MouseMove(object sender, MouseEventArgs e)
        {
            hint.SetToolTip(picBoxFace, "Это твоё лицо.");
        }
        private void picBoxFace_MouseLeave(object sender, EventArgs e)
        {
            hint.SetToolTip(picBoxFace, "");
        }

        //Подсказка при наведении.
        private void pictureBoxPC_MouseMove(object sender, MouseEventArgs e)
        {
            hint.SetToolTip(pictureBoxPC, "Это твой комп.");
        }
        private void pictureBoxPC_MouseLeave(object sender, EventArgs e)
        {
            hint.SetToolTip(pictureBoxPC, "");
        }

        //Подсказка при наведении.
        private void btnOpenMining_MouseMove(object sender, MouseEventArgs e)
        {
            if (Player.status > 3)
            {
                hint.SetToolTip(btnOpenMining, "Майнинг откроется со статуса \"Юзер\"");
            }
        }
        private void btnOpenMining_MouseLeave(object sender, EventArgs e)
        {
            hint.SetToolTip(btnOpenMining, "");
        }

        //Подсказка при наведении.
        private void btnOpenHack_MouseMove(object sender, MouseEventArgs e)
        {
            if (Player.status > 3)
            {
                hint.SetToolTip(btnOpenHack, "Хакерство откроется со статуса \"Юзер\"");
            }
        }
        private void btnOpenHack_MouseLeave(object sender, EventArgs e)
        {
            hint.SetToolTip(btnOpenHack, "");
        }

        //Если форма закрывается, то всё приложение тоже.
        private void Game_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMusic_Click(object sender, EventArgs e)
        {
            if (toolStripMusic.Checked == true)
            {
                toolStripMusic.Image = Hacker.Properties.Resources.sound;
                //Music.Play();
            }
            else if (toolStripMusic.Checked == false)
            {
                toolStripMusic.Image = Hacker.Properties.Resources.muted;
                Music.Stop();
            }
        }
    }
}
