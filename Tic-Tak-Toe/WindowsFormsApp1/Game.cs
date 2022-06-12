using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game : Form
    {
        int tern = 2;
        int Winer = 0;
        int Winner1 = 0;
        int Winner2 = 0;
        int ClickMusic = 0;
        bool pc = false;

        Random rand = new Random();
        System.Media.SoundPlayer Player = new System.Media.SoundPlayer();
        public Game()
        {
            InitializeComponent();
            Player.SoundLocation = "ddd.wav";

            Player.Play();
        }
        public Game(string name1,string name2, bool vs)
        {
            InitializeComponent();
            Player.SoundLocation = "ddd.wav";
            label1.Text = name1;
            label2.Text = name2;
            Player.Play();
            pc = vs;
        }
        public Game(bool vs)
        {
            InitializeComponent();
            Player.SoundLocation = "ddd.wav";
             pc = vs;
            Player.Play();
        }

        //Сама игра (крестик нолик по очереди)
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Image != null)
                return;
            if (tern == 0)
            {
                return;
            }
            if (tern == 2)
            {
                p.Image = player1.Image;
                tern--;

            }
            else
            {
                p.Image = player2.Image;
                tern++;
            }
            //ход пк
            if (pc == true && tern==1)
            {
                MoveAi();
            }

          


            ShowWin();
            GetWinner();

            ShowTurn();

        }

        //Логика игры компьютера
        private void MoveAi()
        {

            {

                if (pictureBox4.Image == null)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if(pictureBox0.Image==player2.Image && pictureBox1.Image==player2.Image && pictureBox2.Image == null)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player2.Image && pictureBox1.Image ==null  && pictureBox2.Image == player2.Image)
                {
                    pictureBox1.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == null && pictureBox1.Image == player2.Image && pictureBox2.Image == player2.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }


                else if (pictureBox3.Image == null && pictureBox4.Image == player2.Image && pictureBox5.Image == player2.Image)
                {
                    pictureBox3.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox3.Image == player2.Image && pictureBox4.Image == null && pictureBox5.Image == player2.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }

                else if (pictureBox3.Image == player2.Image && pictureBox4.Image == player2.Image && pictureBox5.Image == null)
                {
                    pictureBox5.Image = player2.Image;
                    tern++;
                }


                else if (pictureBox6.Image == null && pictureBox7.Image == player2.Image && pictureBox8.Image == player2.Image)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox6.Image == player2.Image && pictureBox7.Image == null && pictureBox8.Image == player2.Image)
                {
                    pictureBox7.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox6.Image == player2.Image && pictureBox7.Image == player2.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }

                else if (pictureBox0.Image == player2.Image && pictureBox3.Image == player2.Image && pictureBox6.Image == null)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player2.Image && pictureBox3.Image == null && pictureBox6.Image == player2.Image)
                {
                    pictureBox3.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == null && pictureBox3.Image == player2.Image && pictureBox6.Image == player2.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }

                else if (pictureBox1.Image == null && pictureBox4.Image == player2.Image && pictureBox7.Image == player2.Image)
                {
                    pictureBox1.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox1.Image == player2.Image && pictureBox4.Image == null && pictureBox7.Image == player2.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox1.Image == player2.Image && pictureBox4.Image == player2.Image && pictureBox7.Image == null)
                {
                    pictureBox7.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player2.Image && pictureBox5.Image == player2.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player2.Image && pictureBox5.Image == null && pictureBox8.Image == player2.Image)
                {
                    pictureBox5.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == null && pictureBox5.Image == player2.Image && pictureBox8.Image == player2.Image)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }

                else if (pictureBox0.Image == null && pictureBox4.Image == player2.Image && pictureBox8.Image == player2.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player2.Image && pictureBox4.Image == null && pictureBox8.Image == player2.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player2.Image && pictureBox4.Image == player2.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player2.Image && pictureBox4.Image == player2.Image && pictureBox6.Image == null)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player2.Image && pictureBox4.Image == null && pictureBox6.Image == player2.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == null && pictureBox4.Image == player2.Image && pictureBox6.Image == player2.Image)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }
                //


                else if (pictureBox0.Image == player1.Image && pictureBox1.Image == player1.Image && pictureBox2.Image == null)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player1.Image && pictureBox1.Image == null && pictureBox2.Image == player1.Image)
                {
                    pictureBox1.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == null && pictureBox1.Image == player1.Image && pictureBox2.Image == player1.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox3.Image == null && pictureBox4.Image == player1.Image && pictureBox5.Image == player1.Image)
                {
                    pictureBox3.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox3.Image == player1.Image && pictureBox4.Image == null && pictureBox5.Image == player1.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox3.Image == player1.Image && pictureBox4.Image == player1.Image && pictureBox5.Image == null)
                {
                    pictureBox5.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox6.Image == player1.Image && pictureBox7.Image == player1.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox6.Image == player1.Image && pictureBox7.Image == null && pictureBox8.Image == player1.Image)
                {
                    pictureBox7.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox6.Image == null && pictureBox7.Image == player1.Image && pictureBox8.Image == player1.Image)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == null && pictureBox4.Image == player1.Image && pictureBox8.Image == player1.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player1.Image && pictureBox4.Image == null && pictureBox8.Image == player1.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player1.Image && pictureBox4.Image == player1.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player1.Image && pictureBox4.Image == player1.Image && pictureBox6.Image == null)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player1.Image && pictureBox4.Image == null && pictureBox6.Image == player1.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == null && pictureBox4.Image == player1.Image && pictureBox6.Image == player1.Image)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == null && pictureBox3.Image == player1.Image && pictureBox6.Image == player1.Image)
                {
                    pictureBox0.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player1.Image && pictureBox3.Image == null && pictureBox6.Image == player1.Image)
                {
                    pictureBox3.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox0.Image == player1.Image && pictureBox3.Image == player1.Image && pictureBox6.Image == null)
                {
                    pictureBox6.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox1.Image == player1.Image && pictureBox4.Image == player1.Image && pictureBox7.Image == null)
                {
                    pictureBox7.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox1.Image == player1.Image && pictureBox4.Image == null && pictureBox7.Image == player1.Image)
                {
                    pictureBox4.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox1.Image == null && pictureBox4.Image == player1.Image && pictureBox7.Image == player1.Image)
                {
                    pictureBox1.Image = player2.Image;
                    tern++;
                }



                else if (pictureBox2.Image == null && pictureBox5.Image == player1.Image && pictureBox8.Image == player1.Image)
                {
                    pictureBox2.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player1.Image && pictureBox5.Image == null && pictureBox8.Image == player1.Image)
                {
                    pictureBox5.Image = player2.Image;
                    tern++;
                }
                else if (pictureBox2.Image == player1.Image && pictureBox5.Image == player1.Image && pictureBox8.Image == null)
                {
                    pictureBox8.Image = player2.Image;
                    tern++;
                }






                else
                {

                    PictureBox[] diceloc = new PictureBox[] { pictureBox0, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };

                    for (int i = 0; i < diceloc.Length; i++)
                    {
                        if (diceloc[i].Image == null)
                        {
                            diceloc[i].Image = player2.Image;
                            break;
                        }
                    }
                    tern++;

                }
            }
        }

     
        

        // Проверка на победу
        int GetWinner()
        {
            PictureBox[] WinningMove = {
                                             //Проверка строк
                                             pictureBox0, pictureBox1, pictureBox2,
                                             pictureBox3, pictureBox4, pictureBox5,
                                             pictureBox6, pictureBox7, pictureBox8,
                                             //Проверка колонок
                                             pictureBox0, pictureBox3, pictureBox6,
                                             pictureBox1, pictureBox4, pictureBox7,
                                             pictureBox2, pictureBox5, pictureBox8,
                                             //Проверка диагоналей
                                             pictureBox0, pictureBox4, pictureBox8,
                                             pictureBox2, pictureBox4, pictureBox6
                                          };

            for (int i = 0; i < WinningMove.Length; i += 3)
            {
                if (WinningMove[i].Image != null )
                {
                    if (WinningMove[i].Image == WinningMove[i + 1].Image &&
                        WinningMove[i].Image == WinningMove[i + 2].Image)
                    {
                        
                        if (WinningMove[i].Image == player1.Image)
                        {
                            tern = 0;
                            Winner1 ++;
                            return Winer = 1;
                            
                            
                        }
                        else if (WinningMove[i].Image == player2.Image)
                        {
                            tern = 0;
                            Winner2++;
                            return Winer = 2;
                            
                            
                        }
                       
                        

                    }
                }
                
            }
            // Проверяем пустые клетки
            PictureBox[] allPictures = { pictureBox0,
                                          pictureBox1,
                                          pictureBox2,
                                          pictureBox3,
                                          pictureBox4,
                                          pictureBox5,
                                          pictureBox6,
                                          pictureBox7,
                                          pictureBox8,
                                          };

            //Если есть пустые клетки то победитель не определен
            foreach (var p in allPictures)
            {
                if (p.Image == null)
                {
                    return Winer=0;
                }
            }

            //Значит ничья
            return Winer=3;








        }
        //Статус игры
        void ShowTurn()
        {
            string stat = "";
            string msg = "";

            if (Winer == 0)
            {
                if (tern == 2)
                {
                    stat = "Cейчас ходит Игрок 1";
                }
                else
                {
                    stat = "Cейчас ходит Игрок 2";
                }
            }
            if (Winer == 1)
            {
                msg=stat = $"{label1.Text} победил";
                ShowWin();
            }
            if (Winer == 2)
            {
                msg=stat = $"{label2.Text}  победил";
                ShowWin();
            }
            if (Winer==3)
            {
                msg=stat = "Ничья";
            }
            Status.Text = stat;
            if (msg != "")
            {
                MessageBox.Show(msg, "Игра завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void NewGame()
        {
            PictureBox[] allPictures = { pictureBox0,
                                          pictureBox1,
                                          pictureBox2,
                                          pictureBox3,
                                          pictureBox4,
                                          pictureBox5,
                                          pictureBox6,
                                          pictureBox7,
                                          pictureBox8,
                                          };

            //Очистить все клетки
            foreach (var p in allPictures)
            {
                p.Image = null;
            }
            
            tern = 2;
            Winer = 0;
            ShowWin();
            ShowTurn();
            
        }
        //начать заного
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Хотите начать новую игру?",
                                          "Новая игра",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NewGame();
            }
        }
        //подсчет побед
        void ShowWin()
        {
            Win1.Text = "Побед: "+ Winner1;
            Win2.Text = "Побед: " + Winner2;
        }

        //кнопка музыки

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if(ClickMusic==0)
            {
                pictureBox9.Image = Properties.Resources._12;
                Player.Stop();
                ClickMusic ++;
                
            }
            else
            {
                pictureBox9.Image = Properties.Resources._11;
                Player.Play();
                ClickMusic --;
            }
            
        }
        //кнопка выхода
        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Player.Stop();
            Close();
        }

        
            
        
    }
}


