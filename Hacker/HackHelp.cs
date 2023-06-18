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
    public partial class HackHelp : Form
    {
        SoundPlayer Click = new SoundPlayer();
        //Счётчик для правильного вывода текстбокса.
        int counter = -1;

        //Переменная для хранения текста текстбокса.
        string[] hint = new string[5] 
        {
            "Для того, чтобы взломать комп друга тебе понадобится:" +
            "\r\nКрякалка простых паролей.",

            "Взлом маленького банка требует:" +
            "\r\nМаскировку хакерских атак" +
            "\r\nКрякалку сложных паролей",

            "Украсть крутой антивирус тебе поможет:" +
            "\r\nКрутая маскировка хакерских атак" +
            "\r\nКрякалка сложных паролей" +
            "\r\nRAM Scraper",

            "Будем говорить кратко и по делу." +
            "\r\nКрутой банк требует:" +
            "\r\nКрутая маскировка хакерских атак" +
            "\r\nТехника \"Бэкдор\"" +
            "\r\nКрякалка сложных паролей",
            

            "Взлом федералов." +
            "\r\nВысокий статус, пристижная работа" +
            "\r\nВсе программы, которые у тебя были до этого" +
            "\r\nНо даже я этого ещё не делал..."
        };

        public HackHelp()
        {
            InitializeComponent();
            Click.SoundLocation = "Click.wav";
        }

        //Взять подсказку - меняет значение текстбокса -50$
        private void btnTakeHint_Click(object sender, EventArgs e)
        {
            Click.Play();
            counter++;
            if (Player.money >= 50) 
            {
                Player.money -= 50;
                txtHints.Text = hint[counter];
            }
            else 
            {
                MessageBox.Show("У тебя не хватает денег для подсказки!", "Нищий!");
            }
            if(counter == 4) 
            {
                counter = -1;
            }
        }
    }
}
