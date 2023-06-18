using Hacker;
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
    public partial class DNS : Form
    {
        SoundPlayer Click = new SoundPlayer();

        //Переменные для провреки кнокпи на вкл/выкл.
        public static int buyCase = 0;
        public static int buyMother = 0;
        public static int buyCPU = 0;
        public static int buyRAM = 0;
        public static int buyGPU = 0;
        public static int buyDisk = 0;
        public DNS()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }
        private void DNS_Load(object sender, EventArgs e)
        {
            //Если все комплектующие какого-либо компа куплены, то включить все кнокпи при перезаходе на форму.
            if (PC.Equals(Player.pc, PC.FirstPC))
            {
                buyCase = 0;
                buyMother = 0;
                buyCPU = 0;
                buyRAM = 0;
                buyGPU = 0;
                buyDisk = 0;
            }
            if (PC.Equals(Player.pc, PC.SecondPC))
            {
                buyCase = 0;
                buyMother = 0;
                buyCPU = 0;
                buyRAM = 0;
                buyGPU = 0;
                buyDisk = 0;
            }
            if (PC.Equals(Player.pc, PC.ThirdPC))
            {
                buyCase = 0;
                buyMother = 0;
                buyCPU = 0;
                buyRAM = 0;
                buyGPU = 0;
                buyDisk = 0;
            }
            if (PC.Equals(Player.pc, PC.FourthPC))
            {
                buyCase = 0;
                buyMother = 0;
                buyCPU = 0;
                buyRAM = 0;
                buyGPU = 0;
                buyDisk = 0;
            }
            if (PC.Equals(Player.pc, PC.FifthPC))
            {
                MessageBox.Show("Ты уже купил топовый комп! Вали отселя.");
            }

            //Если какая-то из комплектующих определённого компа недокуплена, то кнопки выключить.
            if (buyCase == 1)
            {
                btnBuyCase.Enabled = false;
            }
            if (buyMother == 1)
            {
                btnBuyMother.Enabled = false;
            }
            if (buyCPU == 1)
            {
                btnBuyCPU.Enabled = false;
            }
            if (buyRAM == 1)
            {
                btnBuyRAM.Enabled = false;
            }
            if (buyGPU == 1)
            {
                btnBuyGPU.Enabled = false;
            }
            if (buyDisk == 1)
            {
                btnBuyDisk.Enabled = false;
            }
        }

        //Покупка корпуса компа.
        private void btnBuyCase_Click(object sender, EventArgs e)
        {
            Click.Play();
            
            if (Player.pc[0] == PC.NullPC[0])
            {
                if (Player.money >= 50)
                {
                    Player.pc[0] = PC.FirstPC[0];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкину коробку за 50$!");
                    btnBuyCase.Enabled = false;
                    buyCase++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[0] == PC.FirstPC[0])
            {
                if (Player.money >= 75)
                {
                    Player.pc[0] = PC.SecondPC[0];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисный корпус за 75$!");
                    btnBuyCase.Enabled = false;
                    buyCase++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[0] == PC.SecondPC[0])
            {
                if (Player.money >= 100)
                {
                    Player.pc[0] = PC.ThirdPC[0];
                    Player.buyuser();
                    MessageBox.Show("Вы купили корпус юзера за 100$!");
                    btnBuyCase.Enabled = false;
                    buyCase++;
                }
                else if (Player.money > 100)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[0] == PC.ThirdPC[0])
            {
                if (Player.money >= 125)
                {
                    Player.pc[0] = PC.FourthPC[0];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровой корпус за 125$!");
                    btnBuyCase.Enabled = false;
                    buyCase++;
                }
                else if (Player.money > 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[0] == PC.FourthPC[0])
            {
                if (Player.money >= 150)
                {
                    Player.pc[0] = PC.FifthPC[0];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовый корпус за 150$!");
                    btnBuyCase.Enabled = false;
                    buyCase++;
                }
                else if (Player.money > 150)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
        }

        //Покупка материнки компа.
        private void btnBuyMother_Click(object sender, EventArgs e)
        {
            Click.Play();

            if (Player.pc[1] == PC.NullPC[1])
            {
                if (Player.money >= 50)
                {
                    Player.pc[1] = PC.FirstPC[1];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкину мать за 50$!");
                    btnBuyMother.Enabled = false;
                    buyMother++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[1] == PC.FirstPC[1])
            {
                if (Player.money >= 75)
                {
                    Player.pc[1] = PC.SecondPC[1];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисную материнку за 75$!");
                    btnBuyMother.Enabled = false;
                    buyMother++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[1] == PC.SecondPC[1])
            {
                if (Player.money >= 100)
                {
                    Player.pc[1] = PC.ThirdPC[1];
                    Player.buyuser();
                    MessageBox.Show("Вы купили материнку юзера за 100$!");
                    btnBuyMother.Enabled = false;
                    buyMother++;
                }
                else if (Player.money < 100)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[1] == PC.ThirdPC[1])
            {
                if (Player.money >= 125)
                {
                    Player.pc[1] = PC.FourthPC[1];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровую материнку за 125$!");
                    btnBuyMother.Enabled = false;
                    buyMother++;
                }
                else if (Player.money < 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[1] == PC.FourthPC[1])
            {
                if (Player.money >= 150)
                {
                    Player.pc[1] = PC.FifthPC[1];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовую материнку за 150$!");
                    btnBuyMother.Enabled = false;
                    buyMother++;
                }
                else if (Player.money < 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else
            {
                MessageBox.Show("Сначала купите предыдущий комп!");
            }
        }

        //Покупка проца компа.
        private void btnBuyCPU_Click(object sender, EventArgs e)
        {
            Click.Play();

            if (Player.pc[2] == PC.NullPC[2])
            {
                if (Player.money >= 50)
                {
                    Player.pc[2] = PC.FirstPC[2];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкино сердце за 50$!");
                    btnBuyCPU.Enabled = false;
                    buyCPU++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[2] == PC.FirstPC[2])
            {
                if (Player.money >= 75)
                {
                    Player.pc[2] = PC.SecondPC[2];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисный проц за 75$!");
                    btnBuyCPU.Enabled = false;
                    buyCPU++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[2] == PC.SecondPC[2])
            {
                if (Player.money >= 100)
                {
                    Player.pc[2] = PC.ThirdPC[2];
                    Player.buyuser();
                    MessageBox.Show("Вы купили проц юзера за 100$!");
                    btnBuyCPU.Enabled = false;
                    buyCPU++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[2] == PC.ThirdPC[2])
            {
                if (Player.money >= 125)
                {
                    Player.pc[2] = PC.FourthPC[2];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровой проц за 125$!");
                    btnBuyCPU.Enabled = false;
                    buyCPU++;
                }
                else if (Player.money < 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[2] == PC.FourthPC[2])
            {
                if (Player.money >= 150)
                {
                    Player.pc[2] = PC.FifthPC[2];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовый проц за 150$!");
                    btnBuyCPU.Enabled = false;
                    buyCPU++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else
            {
                MessageBox.Show("Сначала купите предыдущий комп!");
            }
        }

        //Покупка оперативы компа.
        private void btnBuyRAM_Click(object sender, EventArgs e)
        {
            Click.Play();

            if (Player.pc[3] == PC.NullPC[3])
            {
                if (Player.money >= 50)
                {
                    Player.pc[3] = PC.FirstPC[3];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкину память за 50$!");
                    btnBuyRAM.Enabled = false;
                    buyRAM++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else if (Player.pc[3] == PC.FirstPC[3])
            {
                if (Player.money >= 75)
                {
                    Player.pc[3] = PC.SecondPC[3];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисную оперативу за 75$!");
                    btnBuyRAM.Enabled= false;
                    buyRAM++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[3] == PC.SecondPC[3])
            {
                if (Player.money >= 100)
                {
                    Player.pc[3] = PC.ThirdPC[3];
                    Player.buyuser();
                    MessageBox.Show("Вы купили оперативу юзера за 100$!");
                    btnBuyRAM.Enabled = false;
                    buyRAM++;
                }
                else if (Player.money < 100)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[3] == PC.ThirdPC[3])
            {
                if (Player.money >= 125)
                {
                    Player.pc[3] = PC.FourthPC[3];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровую оперативу за 125$!");
                    btnBuyRAM.Enabled = false;
                    buyRAM++;
                }
                else if (Player.money < 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[3] == PC.FourthPC[3])
            {
                if (Player.money >= 150)
                {
                    Player.pc[3] = PC.FifthPC[3];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовую оперативу за 150$!");
                    btnBuyRAM.Enabled = false;
                    buyRAM++;
                }
                else if (Player.money > 150)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else
            {
                MessageBox.Show("Сначала купите предыдущий комп!");
            }
        }

        //Покупка видюхи компа.
        private void btnBuyGPU_Click(object sender, EventArgs e)
        {
            Click.Play();

            if(Player.pc[4] == PC.NullPC[4])
            {
                if (Player.money >= 50)
                {
                    Player.pc[4] = PC.FirstPC[4];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкин вентилятор за 50$!");
                    btnBuyGPU.Enabled = false;
                    buyGPU++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[4] == PC.FirstPC[4])
            {
                if (Player.money >= 75)
                {
                    Player.pc[4] = PC.SecondPC[4];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисную видюху за 75$!");
                    btnBuyGPU.Enabled = false;
                    buyGPU++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[4] == PC.SecondPC[4])
            {
                if (Player.money >= 100)
                {
                    Player.pc[4] = PC.ThirdPC[4];
                    Player.buyuser();
                    MessageBox.Show("Вы купили видюху юзера за 100$!");
                    btnBuyGPU.Enabled = false;
                    buyGPU++;
                }
                else if (Player.money > 100)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[4] == PC.ThirdPC[4])
            {
                if (Player.money >= 125)
                {
                    Player.pc[4] = PC.FourthPC[4];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровую видюху за 125$!");
                    btnBuyGPU.Enabled = false;
                    buyGPU++;
                }
                else if(Player.money > 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[4] == PC.FourthPC[4])
            {
                if (Player.money >= 150)
                {
                    Player.pc[4] = PC.FifthPC[4];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовую видюху за 150$!");
                    btnBuyGPU.Enabled = false;
                    buyGPU++;
                }
                else if(Player.money > 150)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else
            {
                MessageBox.Show("Сначала купите предыдущий комп!");
            }

        }

        //Покупка диска компа.
        private void btnDisk_Click(object sender, EventArgs e)
        {
            Click.Play();

            if(Player.pc[5] == PC.NullPC[5])
            {
                if (Player.money >= 50)
                {
                    Player.pc[5] = PC.FirstPC[5];
                    Player.buygrandma();
                    MessageBox.Show("Вы купили бабкин диск за 50$!");
                    btnBuyDisk.Enabled = false;
                    buyDisk++;
                }
                else
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[5] == PC.FirstPC[5])
            {
                if (Player.money >= 75)
                {
                    Player.pc[5] = PC.SecondPC[5];
                    Player.buyoffice();
                    MessageBox.Show("Вы купили офисный диск за 75$!");
                    btnBuyDisk.Enabled = false;
                    buyDisk++;
                }
                else if (Player.money < 75)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[5] == PC.SecondPC[5])
            {
                if (Player.money >= 100)
                {
                    Player.pc[5] = PC.ThirdPC[5];
                    Player.buyuser();
                    MessageBox.Show("Вы купили диск юзера за 100$!");
                    btnBuyDisk.Enabled = false;
                    buyDisk++;
                }
                else if (Player.money > 100)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[5] == PC.ThirdPC[5])
            {
                if (Player.money >= 125)
                {
                    Player.pc[5] = PC.FourthPC[5];
                    Player.buygaming();
                    MessageBox.Show("Вы купили игровой диск за 125$!");
                    btnBuyDisk.Enabled = false;
                    buyDisk++;
                }
                else if (Player.money > 125)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }

            else if (Player.pc[5] == PC.FourthPC[5])
            {
                if (Player.money >= 150)
                {
                    Player.pc[5] = PC.FifthPC[5];
                    Player.buytop();
                    MessageBox.Show("Вы купили топовый диск за 150$!");
                    btnBuyDisk.Enabled = false;
                    buyDisk++;
                }
                else if(Player.money > 150)
                {
                    MessageBox.Show("Вам не хватает!");
                }
            }
            else
            {
                MessageBox.Show("Сначала купите предыдущий комп!");
            }
        }
    }
}

