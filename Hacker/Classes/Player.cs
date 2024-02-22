using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace Hacker
{
    public partial class Player
    {
        //Поле с текстом приветствия игрока(дабы не засорять Game.cs)
        public static string hello = 
                $"Привет!" +
                $"\nИгра простенькая, но вот тебе пару советов:" +
                $"\n1. Устройся на работу." +
                $"\n2. Если не хочешь долго ждать - возьми кредит(но помни о последствиях)" +
                $"\n3. Как только денег хватит - купи себе уже комп! Обновляй свою ОС-ку и изучай языки программирования" +
                $"\n4. Не забывай повышать настроение в \"Развлекухе\"" +
                $"\n5. Когда твой статус будет \"Юзер\", то можешь начать майнить крипту и заниматься хакерством" +
                $"\n6. Игра имеет конец..." +
                $"\nУдачи тебе!";

        //Поле жив ли игрок.
        public static int isAlive = 1;

        //Имя пользователя.
        public static string name = "Anonymus";
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Настроение игрока.
        public static double mood = 150;
        public static double Mood
        {
            get { return mood; }
            set { mood = value; }
        }

        //Деньги игрока.
        public static int money = 50_000;
        public static int Money
        {
            get { return money; }
            set { money = value; }
        }

        //Счёт игрока.
        public static int score = 0;
        public static int Score
        {
            get { return score; }
            set { score = value; }
        }

        //Стату игрока.
        public static int status = 3;
        public static int Status 
        {
            get { return status; }
            set { status = value; }
        }

        //Работа игрока.
        public static int work = 0;
        public static int Work
        {
            get { return work; }
            set { work = value; }
        }

        //Крипта игрока.
        public static int[] coins = new int[3] { 0, 0, 0 };
        public static int[] Coins
        {
            get { return coins; }
            set {  coins = value; }
        }

        //Игровое время.
        public static int time = 0;
        public static int Time
        {
            get { return time; }
            set { time = value; }
        }

        //Игровая дата.
        public static int[] date = new int[3] { 31, 12, 2022 };
        public static int[] Date
        {
            get { return date; }
            set { date = value; }
        }

        //Комьютер игрока.
        public static int[] pc = new int[6] { 0, 0, 0, 0, 0, 0 };
        public static int[] PC
        {
            get { return pc; }
            set { pc = value; }
        }


        //ОС игрока.
        public static int os = 0;
        public static int OS 
        {
            get { return os; }
            set { os = value; }
        }

        //Язык программирования игрока.
        public static int programming = 0;
        public static int Programming
        {
            get { return programming; }
            set { programming = value; }
        }

        //Антивирус игрока.
        public static int antivirus = 0;
        public static int Antivirus 
        {
            get { return antivirus; }
            set { antivirus = value; }
        }

        //Кредиты игрока.
        public static int[] loans = new int[5] {0, 0, 0, 0, 0};
        public static int[] Loans 
        {
            get { return loans; }
            set { loans = value; }
        }

        //Хакерский опыт игрока.
        public static int experiencehack = 0;
        public static int ExperienceHack 
        {
            get { return experiencehack; }
            set { experiencehack = value; }
        }

        //Хакерский софт игрока.
        public static string[] soft = new string[6] {"1.Отсутствует", "2.Отсутствует", "3.Отсутствует", "4.Отсутствует", "5.Отсутствует", "6.Отсутствует"};
        public static string[] Soft 
        {
            get { return soft; }
            set { soft = value; }
        }

        //Счёт игрока в динозаврике.
        public static int dinoScore = 0;
        public static int DinoScore 
        {
            get { return dinoScore; }
            set { dinoScore = value; }
        }

        //Лучший счёт в динозаврике.
        public static int bestDino = 0;
        public static int BestDino 
        {
            get { return bestDino; }
            set { bestDino = value; }
        }

        //Кол-во выполненных заданий игрока
        public static int successHacks = 0;
        public static int SuccessHacks
        {
            get { return successHacks; }
            set { successHacks = value; }
        }

        //Метод покупки любой комплектующей от "бабки".
        public static void buygrandma()
        {
            money -= 50;
            mood += 1;
            score += 1;
        }

        //Метод покупки любой "офисной" комплектующей.
        public static void buyoffice()
        {
            money -= 75;
            mood += 2;
            score += 2;
        }

        //Метод покупки любой комплектующей "юзера".
        public static void buyuser()
        {
            money -= 100;
            mood += 3;
            score += 3;
        }

        //Метод покупки любой "игровой" комплектующей.
        public static void buygaming()
        {
            money -= 125;
            mood += 4;
            score += 4;
        }

        //Метод покупки любой "топовой" комплектующей.
        public static void buytop()
        {
            money -= 150;
            mood += 5;
            score += 5;
        }

        //Метод: "Если игрок не выплатил кредит".
        public static void notRepay() 
        {
            isAlive = 0;
            mood = 0;
            money = 0;
            MessageBox.Show("Вы не успели погасить кредит.. За Вами пришли коллекторы отобрали все деньги и \"убили вас\".");
        }
    }
}
