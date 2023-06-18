using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hacker.Classes;

namespace Hacker
{
    //Код динозаврика-гугл взял у https://www.youtube.com/watch?v=gBCw3kB8bDs.
    public partial class Dino : Form
    {
        Dinosaur dinosaur;
        Timer mainTimer;
        public Dino()
        {
            InitializeComponent();

            this.Width = 700;
            this.Height = 300;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(DrawGame);
            this.KeyUp += new KeyEventHandler(OnKeyboardUp);
            this.KeyDown += new KeyEventHandler(OnKeyboardDown);
            mainTimer = new Timer();
            mainTimer.Interval = 10;
            mainTimer.Tick += new EventHandler(Update);
            Init();
        }

        private void OnKeyboardDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (!dinosaur.physics.isJumping)
                    {
                        dinosaur.physics.isCrouching = true;
                        dinosaur.physics.isJumping = false;
                        dinosaur.physics.transform.size.Height = 25;
                        dinosaur.physics.transform.position.Y = 174;
                    }
                    break;
            }
        }

        private void OnKeyboardUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (!dinosaur.physics.isCrouching)
                    {
                        dinosaur.physics.isCrouching = false;
                        dinosaur.physics.AddForce();
                    }
                    break;
                case Keys.Down:
                    dinosaur.physics.isCrouching = false;
                    dinosaur.physics.transform.size.Height = 50;
                    dinosaur.physics.transform.position.Y = 150.2f;
                    break;
            }
        }

        public void Init()
        {
            MessageBox.Show("Для управления используйте стрелочки!");
            GameController.Init();
            dinosaur = new Dinosaur(new PointF(50, 149), new Size(50, 50));
            mainTimer.Start();
            Invalidate();
        }

        public void Update(object sender, EventArgs e)
        {
            dinosaur.score++;

            if (dinosaur.physics.Collide()) 
            {
                mainTimer.Stop();
                int maxScore = Player.bestDino;
                Player.dinoScore = dinosaur.score;
                if (dinosaur.score > maxScore)
                {
                    maxScore = dinosaur.score;
                }
                double plusMood = Player.dinoScore / 100;
                Player.bestDino = maxScore;
                Player.mood += Math.Floor(plusMood);
                this.Close();
                MessageBox.Show($"Отлично сыграли, настроение повысилось :)\r\nСчёт: {dinosaur.score}");
            }
            else 
            {
                dinosaur.physics.ApplyPhysics();
                GameController.MoveMap();
                Invalidate();
            }
        }

        private void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            dinosaur.DrawSprite(g);
            GameController.DrawObjets(g);
        }
    }
}
