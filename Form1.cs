using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2
{    
    public partial class Form1 : Form
    {
        class Duck : Button//Klasa kaczki dziedzicząca z buttona.
        {
            private bool is_shooted;

            public Duck()//Konstruktor.
            {
                is_shooted = false;
                //Text = "DUCK"; Jak jest załadowany obrazek to niepotrzebnie.
            }

            public bool IsShooted//Getter is_shooted.
            {
                get 
                {
                    return is_shooted; 
                }
            }

            public void Shoot()//Zestrzelenie kaczki.
            {
                is_shooted = true;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        //Zmienne globalne gry.
        public int score = 0;
        public int total_score = 0;
        public string nickname = "";
        public int duck_number = 1;       
       
        readonly Random generator = new Random();
        readonly Random time = new Random();
        readonly List<Duck> ducks = new List<Duck>();


     




        private void RemoveDucks()//Metoda usuwająca kaczki z planszy.
        {
            if (ducks.Count != 0)
            {
                foreach (Duck dead_duck in ducks)
                {
                    Controls.Remove(dead_duck);
                    dead_duck.Dispose();
                }
            }
        }

        private void CreateDuck()//Tworzenie jednej kaczki , ustawianie jej parametrów.
        {
            Duck duck = new Duck();

            duck.Click += (sender, e) => AddPoint(sender, e, duck);//Inny event_holder pozwalający przekazać parametry.


            Point location = new Point(generator.Next(10, 500), generator.Next(1, 340));
            duck.Location = location;
            duck.Size = new Size(77, 60);

            
            duck.Image = Image.FromFile("Duck.jpg");

            Controls.Add(duck);
            ducks.Add(duck);                       
        }
      
        private void SpawnDucks()//Metoda tworząca i zliczająca kaczki.
        {
            for (int i = 0; i < duck_number; i++)
            {
                CreateDuck();
                total_score++;
            }
        }
        
        private void AddPoint(object sender, EventArgs e, Duck duck)//Metoda dodająca punkt za zestrzeloną kaczkę.
        {
            if (!duck.IsShooted)
            {
                score++;
                SetScore();
                duck.Shoot();
                duck.Visible = false;
            }
        }














        private void SetScore()//Metoda ustawiająca wynik.
        {
            ScoreBox.Text = "";
            ScoreBox.Text =   score.ToString() + "/" + total_score.ToString();
        }

        private void LevelControl()//Metoda sprawdzająca poziom gry.
        {           
            if (LevelOfDifficulty.Value == 0)
            {
                GameTimer.Interval = time.Next(3000, 3601);
                duck_number = 1;
            }
            else if (LevelOfDifficulty.Value == 1)
            {
                GameTimer.Interval = time.Next(1500, 1800);
                duck_number = generator.Next(1, 3);
            }
            else if (LevelOfDifficulty.Value == 2)
            {
                GameTimer.Interval = time.Next(1000, 1201);
                duck_number = generator.Next(2, 4);
            }
            else if (LevelOfDifficulty.Value == 3)
            {
                GameTimer.Interval = time.Next(1000, 1101);
                duck_number = generator.Next(2, 5);
            }
        }
        
        private void SaveToFile()//Metoda zapisująca wynik,date oraz nazwę użytnownika do pliku txt.
        {
            using (StreamWriter score_after_game = new StreamWriter("Wyniki.txt", true))
            {
                string final_score_form = "";
                foreach (char letter in ScoreBox.Text)
                {
                    if (letter != ' ')
                    {
                        final_score_form += letter;
                    }
                }
                string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
                score_after_game.WriteLine(date.ToString() + " |" + nickname + "| " + final_score_form);
            }
        }











        private void Start_Click(object sender, EventArgs e)//Metoda wywołana po kliknęciu w Start.
        {
            nickname = PlayerNicknameBox.Text;

            if (String.IsNullOrEmpty(PlayerNicknameBox.Text))//Sprawdzamy czy użytkownik podał nazwę.
            {
                MessageBox.Show("Podaj nazwę gracza.", "Error");
            }
            else
            {
                PlayerNicknameBox.Text = "";//Zmieniamy "okienko" na okno gry.
                Start.Visible = false;
                PlayerNicknameBox.Visible = false;
                NameLabel.Visible = false;
                GameName.Visible = false;

                LevelOfDifficulty.Visible = true;
                Stop.Visible = true;
                ScoreBox.Visible = true;
                GameTimer.Enabled = true;
                 
                ScoreLabel.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }

        private void Stop_Click(object sender, EventArgs e)//Metoda wywołana po kliknięciu w STOP.
        {
            SaveToFile();
            RemoveDucks();
            
            score = 0;//Zmieniamy "okienko" na okno startu oraz czyścimy wszystkie zmienne.
            total_score = 0;
            LevelOfDifficulty.Value = 0;
            duck_number = 1;
            GameTimer.Interval = 3000;

            nickname = "";
            ScoreBox.Text = "";
                                
            
            Start.Visible = true;
            PlayerNicknameBox.Visible = true;
            NameLabel.Visible = true;
            GameName.Visible = true;



            LevelOfDifficulty.Visible = false;
            Stop.Visible = false;
            ScoreBox.Visible = false;
            GameTimer.Enabled = false;

            ScoreLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e)//Metoda wywołana po ticku GameTimera(3000ms startowo).
        {            
            RemoveDucks();
            ducks.Clear();
            SpawnDucks();
            SetScore();
            LevelControl();
        }

        private void LevelOfDifficulty_Scroll(object sender, EventArgs e)//Metoda wywołana po zmianie poziomu.
        {
            LevelControl();
        }








        private void ScoreBox_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }             
    }
}
