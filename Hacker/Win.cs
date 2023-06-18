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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        //при загрузке меняется текстбокс. в нём меняются переменные игрока взависимости от того, когда ты победил.
        private void Win_Load(object sender, EventArgs e)
        {
            
            txtWin.Text ="Все задания по хакерству выполнены.. Ты победил!" +
                "\r\nСпасибо за прохождение игры!!!" +
                "\r\nВот вся твоя статистика:" +
               $"\r\nДенег: {Player.money}" +
               $"\r\nСчёт: {Player.score}" +
               $"\r\nКомпьютер: Топовый" +
               $"\r\nСистема: Likus 666" +
               $"\r\nЯзык программирования: LAZARUS TURBO PASCAL" +
               $"\r\nРабота: Программист(сеньор)" +
               $"\r\nHackerCoins: {Player.coins[0]}" +
               $"\r\nKefirium: {Player.coins[1]}" +
               $"\r\nBitok: {Player.coins[2]}";
        }
        private void Win_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
