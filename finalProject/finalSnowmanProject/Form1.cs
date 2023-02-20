using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalSnowmanProject
{
    public partial class Form1 : Form
    {
        // list of words from dictionary.txt file
        private List<String> words;

        // word that user needs to guess
        private string randomWordChoice;

        // string that represents current state of user's guessing so far
        private string wordToDisplay;

        // number of wrong guesses so far (will lose at 6)
        private int numWrongGuesses;

        // sorted set used to track and display previous guesses made by user
        private SortedSet<char> prevGuesses = new SortedSet<char>();
        public Form1()
        {
            InitializeComponent();

            // .txt file should be line separated with one word on each line
            // .ReadAllLines().toList() stores each line from the .txt
            // into the class member List<String> words
            words = File.ReadAllLines("dictionary.txt").ToList();

            // Picks a random word from words and sets that as the
            // word the user needs to guess
            Random random = new Random();
            randomWordChoice = words[random.Next(0, words.Count)];
            wordToDisplay = new string('_', randomWordChoice.Length);

           // various things to display on interface
            numWrongGuesses = 0;
            richTextBox1.Text = wordToDisplay;
            richTextBox1.ReadOnly = true;
            label1.Text = "Incorrect Guesses: " + numWrongGuesses;

            // dont want to see snowman on start
            bottomCircle.Visible = false;
            middleCircle.Visible = false;
            topCircle.Visible = false;
            leftArm.Visible = false;
            rightArm.Visible = false;
            hat.Visible = false;
        }

        // calls game logic function when "enter" button is clicked
        private void button1_Click_1(object sender, EventArgs e)
        {
            gameLogic();
        }

        private void gameLogic()
        {
            // gives the user an error message if they try to submit an empty text box
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a char.");
                return;
            }

            // reads in single char input from user and will
            // either prompt the user that they have already chosen that char
            // and not do anything or will store the guess and display
            // it on the screen
            char guess = char.Parse(textBox1.Text);
            
            if (prevGuesses.Contains(guess))
            {
                MessageBox.Show("You alreaded gussed the letter " + guess + " , please try another.");
                textBox1.Text = "";
                return;
            }
            else
            {
                prevGuesses.Add(guess);
                listBox1.Items.Clear(); // Item's aren't in sorted order so clear and then add each item back in sorted order
                foreach (char c in prevGuesses)
                {
                    listBox1.Items.Add(c);
                }
                textBox1.Text = "";
            }

            // scans through the random word and if any chars in the random
            // string match that, will record that the guess was correct
            // and prepare the word to be changed on the display
            bool correctGuess = false;
            char[] word = wordToDisplay.ToCharArray();
            for (int i = 0; i < randomWordChoice.Length; i++)
            {
                if (randomWordChoice[i] == guess)
                {
                    word[i] = guess;
                    correctGuess = true;
                }
            }

            // increment numWrongGuesses on the screen if the user entered in
            // an incorrect guess
            if (!correctGuess)
            {
                numWrongGuesses++;
                label1.Text = "Incorrect Guesses: " + numWrongGuesses;
            }

            // displays the current state of the user's game so far
            wordToDisplay = new string(word);
            richTextBox1.Text = wordToDisplay;

            // win conditions:
            // if the user has guessed incorreclty 6 times will display hat and a loss message and close program
            // if the word doesn't contain any more underlines (that is the user has guessed every char)
            // will display a win message and close program
            if (numWrongGuesses == 6)
            {
                hat.BringToFront();
                hat.Visible = true;
                MessageBox.Show("You lost! The word was " + randomWordChoice);
                Close();
            }
            else if (!wordToDisplay.Contains('_'))
            {
                MessageBox.Show("You won!");
                Close();
            }

            // for each wrong guess a different part of the snowman will be displayed
            if (numWrongGuesses >= 1)
            {
                bottomCircle.Visible = true;
            }
            if (numWrongGuesses >= 2)
            {
                middleCircle.Visible = true;
            }
            if (numWrongGuesses >= 3)
            {
                topCircle.Visible = true;
            }
            if (numWrongGuesses >= 4)
            {
                leftArm.Visible = true;
            }
            if (numWrongGuesses >= 5)
            {
                rightArm.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                gameLogic();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // equal to press letter a on keyboard and then press enter
            textBox1.Text = "a";
            gameLogic();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "b";
            gameLogic();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "c";
            gameLogic();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "d";
            gameLogic();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "e";
            gameLogic();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "f";
            gameLogic();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "g";
            gameLogic();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "h";
            gameLogic();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "i";
            gameLogic();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "j";
            gameLogic();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "k";
            gameLogic();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "l";
            gameLogic();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "m";
            gameLogic();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "n";
            gameLogic();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "o";
            gameLogic();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "p";
            gameLogic();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "q";
            gameLogic();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "r";
            gameLogic();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "s";
            gameLogic();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "t";
            gameLogic();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "u";
            gameLogic();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "v";
            gameLogic();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "w";
            gameLogic();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "x";
            gameLogic();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "y";
            gameLogic();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "z";
            gameLogic();
        }
    }
}
