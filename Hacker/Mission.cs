using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacker
{
    public partial class Missions : Form
    {
        //Счётчики. 1 - порядок действий. 2 - выбор инструмента.
        int counter = 0;
        int nextCounter = 0;

        //Переменная текста заданий.
        string[] missionText = new string[5]
        {
            "Подключаемся к компу друга...\r\nДля взлома требуется использовать крякалку простых паролей!",
            "Подключаемся к маленькому банку..\r\nБыстрее используй маскировку хакерских атак!",
            "Пытаемся украсть крутой антивирус у создателей вирусов...\r\nСкорей используй крутую маскировку хакерских атак!",
            "Хакаем крутой банк!..\r\nИспользуй крутую маскировку хакерских атак!",
            "Ты нашёл айпишник бдшки федералов. \r\nДумай головой что следует сделать сначала.."
        };
        public Missions()
        {
            InitializeComponent();
            btnToolHack.Text = "Выбери инструмент для взлома!";
        }

        //При загрузке - меняется название формы и текст задания.
        private void Mission_Load(object sender, EventArgs e)
        {
            if (Player.experiencehack == 0)
            {
                this.Text = "Хакерское задание №1";
                txtMission.Text = missionText[0];
            }
            else if (Player.experiencehack == 5)
            {
                this.Text = "Хакерское задание №2";
                txtMission.Text = missionText[1];
            }
            else if (Player.experiencehack == 15)
            {
                this.Text = "Хакерское задание №3";
                txtMission.Text = missionText[2];
            }
            else if (Player.experiencehack == 30)
            {
                this.Text = "Хакерское задание №4";
                txtMission.Text = missionText[3];
            }
            else if (Player.experiencehack == 50)
            {
                this.Text = "Хакерское задание №5";
                txtMission.Text = missionText[4];
            }
        }

        //Выбор инструмента взлома
        private void btnNextTool_Click(object sender, EventArgs e)
        {
            if(nextCounter == 0) 
            {
                btnToolHack.Text = Player.soft[0];
                nextCounter = 1;
            }
            else if(nextCounter == 1) 
            {
                btnToolHack.Text = Player.soft[1];
                nextCounter = 2;
            }
            else if (nextCounter == 2)
            {
                btnToolHack.Text = Player.soft[2];
                nextCounter = 3;
            }
            else if (nextCounter == 3)
            {
                btnToolHack.Text = Player.soft[3];
                nextCounter = 4;
            }
            else if (nextCounter == 4)
            {   
                btnToolHack.Text = Player.soft[4];
                nextCounter = 5;
            }
            else if (nextCounter == 5)
            {
                btnToolHack.Text = Player.soft[5];
                nextCounter = 6;
            }
            else if(nextCounter == 6) 
            {
                btnToolHack.Text = "Выбери инструмент для взлома!";
                nextCounter = 0;    
            }
        }

        //Выполнение задания взависимости от правильно выбранного инструмента.
        private void btnToolHack_Click(object sender, EventArgs e)
        {
            if (this.Text == "Хакерское задание №1")
            {
                if (btnToolHack.Text == Player.soft[0] && Player.soft[0] != "Отсутсвует")
                {
                    txtMission.Text += "\r\nИспользована крякалка простых паролей!" +
                        "\r\nТы взломал комп друга и твой хакерский опыт вырос." +
                        "\r\nМожешь перейти к следующему заданию";
                    Player.experiencehack = 5;
                    Player.mood += 10;
                    Player.successHacks += 1;
                    btnToolHack.Enabled = false;
                }
                else
                {
                    btnToolHack.Enabled = false;
                    this.Close();
                    Player.mood -= 10;
                    MessageBox.Show("Ты изпользовал неправильный инструмент взлома!", "Ты попался");
                }
            }
            else if (this.Text == "Хакерское задание №2")
            {
                if (btnToolHack.Text == Player.soft[1] && Player.soft[1] != "Отсутсвует")
                {
                    txtMission.Text += "\r\nИспользована маскировка хакерских атак!" +
                        "\r\nТеперь используй крякалку сложных паролей!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[2] && Player.soft[2] != "Отсутсвует" && counter == 1)
                {
                    txtMission.Text += "\r\nИспользована крякалка сложных паролей!" +
                        "\r\nТы взломал маленький банк и получил на свой счёт 100$" +
                        "\r\nМожешь перейти к следующему заданию";
                    Player.experiencehack = 15;
                    Player.mood += 15;
                    Player.successHacks += 1;
                    counter = 0;
                    btnToolHack.Enabled = false;
                }
                else
                {
                    btnToolHack.Enabled = false;
                    this.Close();
                    Player.mood -= 10;
                    MessageBox.Show("Ты изпользовал неправильный инструмент взлома!", "Ты попался");
                }
            }
            else if (this.Text == "Хакерское задание №3")
            {
                if (btnToolHack.Text == Player.soft[3] && Player.soft[3] != "Отсутсвует")
                {
                    txtMission.Text += "\r\nИспользована крутая маскировка хакерских атак!" +
                        "\r\nТеперь используй крякалку сложных паролей!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[2] && Player.soft[2] != "Отсутсвует" && counter == 1)
                {
                    txtMission.Text += "\r\nИспользована крякалка сложных паролей!" +
                        "\r\nТеперь используй RAM Scrapper!";
                    counter++;
                }
                else if(btnToolHack.Text == Player.soft[4] && Player.soft[4] != "Отсутсвует" && counter == 2) 
                {
                    txtMission.Text += "\r\nИспользован RAM Scrapper!" +
                        "\r\nТы украл крутой антивирус!" +
                        "\r\nМожешь перейти к следующему заданию";
                    Player.experiencehack = 30;
                    Player.antivirus = 2;
                    Player.mood += 30;
                    Player.successHacks += 1;
                    counter = 0;
                    btnToolHack.Enabled = false;
                }
                else
                {
                    btnToolHack.Enabled = false;
                    this.Close();
                    Player.mood -= 10;
                    MessageBox.Show("Ты изпользовал неправильный инструмент взлома!", "Ты попался");
                }
            }
            else if (this.Text == "Хакерское задание №4")
            {
                if (btnToolHack.Text == Player.soft[3] && Player.soft[3] != "Отсутсвует")
                {
                    txtMission.Text += "\r\nИспользована крутая маскировка хакерских атак!" +
                        "\r\nТеперь используй технику Бэкдор!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[5] && Player.soft[5] != "Отсутсвует" && counter == 1)
                {
                    txtMission.Text += "\r\nИспользована техника Бэкдор!" +
                        "\r\nТеперь используй крякалку сложных паролей!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[2] && Player.soft[2] != "Отсутсвует" && counter == 2)
                {
                    txtMission.Text += "\r\nИспользована крякалка сложных паролей!" +
                        "\r\nТы взломал крутой банк и получил 250$" +
                        "\r\nМожешь перейти к следующему заданию";
                    Player.experiencehack = 50;
                    Player.money += 250;
                    Player.mood += 50;
                    Player.successHacks += 1;
                    counter = 0;
                    btnToolHack.Enabled = false;
                }
                else
                {
                    btnToolHack.Enabled = false;
                    this.Close();
                    Player.mood -= 10;
                    MessageBox.Show("Ты изпользовал неправильный инструмент взлома!", "Ты попался");
                }
            }
            else if (this.Text == "Хакерское задание №5")
            {
                if (btnToolHack.Text == Player.soft[3] && Player.soft[3] != "Отсутсвует")
                {
                    txtMission.Text += "\r\nИспользована крутая маскировка хакерских атак!" +
                        "\r\nТеперь используй технику Бэкдор!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[5] && Player.soft[5] != "Отсутсвует" && counter == 1)
                {
                    txtMission.Text += "\r\nИспользована техника Бэкдор!" +
                        "\r\nТеперь используй крякалку сложных паролей!";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[2] && Player.soft[2] != "Отсутсвует" && counter == 2)
                {
                    txtMission.Text += "\r\nИспользована крякалка сложных паролей!" +
                        "\r\nТеперь используй RAM Scrapper";
                    counter++;
                }
                else if (btnToolHack.Text == Player.soft[4] && Player.soft[4] != "Отсутсвует" && counter == 3)
                {
                    txtMission.Text += "\r\nИспользован RAM Scrapper!" +
                        "\r\nТы взломал федералов и украл много разных данных... Ни один крутой хакер не мог этого сделать...";
                    Player.experiencehack = 100;
                    Player.mood += 100;
                    Player.successHacks += 1;
                    btnToolHack.Enabled = false;
                }
                else
                {
                    btnToolHack.Enabled = false;
                    this.Close();
                    Player.mood -= 50;
                    MessageBox.Show("Ты изпользовал неправильный инструмент взлома!", "Ты попался");
                }
            }
        }
    }
}
