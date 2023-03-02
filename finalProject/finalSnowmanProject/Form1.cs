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
        
        // word that needs to be shown as answer
        private string answerWord;

        // string that represents current state of user's guessing so far
        private string wordToDisplay;

        // number of wrong guesses so far (will lose at 6)
        private int numWrongGuesses;


        private string guessFromUser;

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
            answerWord = randomWordChoice;
            // add spaces between each char and a space after the last char in randomWordChoice
            randomWordChoice = string.Join(" ", randomWordChoice.ToCharArray()) + " ";
            wordToDisplay = new string('_', randomWordChoice.Length/2);
            // (spaces between each char and a space after the last char)
            wordToDisplay = string.Join(" ", wordToDisplay.ToCharArray()) + " ";

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

            // hint word should be hidden at first
            label6.Visible = false;
            label6.Text = answerWord;
        }

        private void gameLogic()
        {
            // gives the user an error message if they try to submit an empty text box or a single space
            if (guessFromUser == "" || guessFromUser == " ")
            {
                MessageBox.Show("You need to enter a char.");
                return;
            }

            // reads in single char input from user and will
            // either prompt the user that they have already chosen that char
            // and not do anything or will store the guess and display
            // it on the screen
            char guess = char.Parse(guessFromUser);
            
            if (prevGuesses.Contains(guess))
            {
                MessageBox.Show("You already guessed the letter " + guess + " , please try another.");
                guessFromUser = "";
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
                guessFromUser = "";
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
            
            wordToDisplay = new string(word); // convert char array back to string
            richTextBox1.Text = wordToDisplay;
            
            // win conditions:
            // if the user has guessed incorreclty 6 times will display hat and a loss message and close program
            // if the word doesn't contain any more underlines (that is the user has guessed every char)
            // will display a win message and close program
            if (numWrongGuesses == 6)
            {
                hat.BringToFront();
                hat.Visible = true;
                MessageBox.Show("You lost! The word was " + answerWord + ".");
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
        // will submit a guess if the user is focused on the input box and presses "enter" on the keyboard
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                gameLogic();
            }
        }

        // calls game logic function when "enter" button is clicked
        private void button1_Click_1(object sender, EventArgs e)
        {
            gameLogic();
        }

        // button2 - button27 make up graphical keyboard, when one is pushed it will do some thing
        // as typing in a guess and pressing enter
        private void button2_Click(object sender, EventArgs e)
        {
            // equal to press letter a on keyboard and then press enter
            guessFromUser = "a";
            // grey out button
            button2.Enabled = false;
            // do not highlight button after it is clicked
            button2.TabStop = false;
            gameLogic();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            guessFromUser = "b";
            // grey out button
            button4.Enabled = false;
            button4.TabStop = false;
            gameLogic();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guessFromUser = "c";
            // grey out button
            button3.Enabled = false;
            // disable button from being highlighted
            button3.TabStop = false;
            gameLogic();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guessFromUser = "d";
            // grey out button
            button5.Enabled = false;
            button5.TabStop = false;
            gameLogic();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            guessFromUser = "e";
            // grey out button
            button6.Enabled = false;
            button6.TabStop = false;
            gameLogic();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            guessFromUser = "f";
            // grey out button
            button7.Enabled = false;
            button7.TabStop = false;
            gameLogic();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            guessFromUser = "g";
            // grey out button
            button8.Enabled = false;
            button8.TabStop = false;
            gameLogic();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            guessFromUser = "h";
            // grey out button
            button9.Enabled = false;
            button9.TabStop = false;
            gameLogic();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            guessFromUser = "i";
            // grey out button
            button10.Enabled = false;
            button10.TabStop = false;
            gameLogic();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            guessFromUser = "j";
            // grey out button
            button11.Enabled = false;
            button11.TabStop = false;
            gameLogic();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            guessFromUser = "k";
            // grey out button
            button12.Enabled = false;
            button12.TabStop = false;
            gameLogic();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            guessFromUser = "l";
            // grey out button
            button13.Enabled = false;
            button13.TabStop = false;
            gameLogic();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            guessFromUser = "m";
            // grey out button
            button14.Enabled = false;
            button14.TabStop = false;
            gameLogic();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            guessFromUser = "n";
            // grey out button
            button15.Enabled = false;
            button15.TabStop = false;
            gameLogic();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            guessFromUser = "o";
            // grey out button
            button16.Enabled = false;
            button16.TabStop = false;
            gameLogic();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            guessFromUser = "p";
            // grey out button
            button17.Enabled = false;
            button17.TabStop = false;
            gameLogic();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            guessFromUser = "q";
            // grey out button
            button18.Enabled = false;
            button18.TabStop = false;
            gameLogic();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            guessFromUser = "r";
            // grey out button
            button19.Enabled = false;
            button19.TabStop = false;
            gameLogic();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            guessFromUser = "s";
            // grey out button
            button20.Enabled = false;
            button20.TabStop = false;
            gameLogic();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            guessFromUser = "t";
            // grey out button
            button21.Enabled = false;
            button21.TabStop = false;
            gameLogic();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            guessFromUser = "u";
            // grey out button
            button22.Enabled = false;
            button22.TabStop = false;
            gameLogic();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            guessFromUser = "v";
            // grey out button
            button23.Enabled = false;
            button23.TabStop = false;
            gameLogic();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            guessFromUser = "w";
            // grey out button
            button24.Enabled = false;
            button24.TabStop = false;
            gameLogic();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            guessFromUser = "x";
            // grey out button
            button25.Enabled = false;
            button25.TabStop = false;
            gameLogic();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            guessFromUser = "y";
            // grey out button
            button26.Enabled = false;
            button26.TabStop = false;
            gameLogic();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            guessFromUser = "z";
            // grey out button
            button27.Enabled = false;
            button27.TabStop = false;
            gameLogic();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            guessFromUser = "-";
            // grey out button
            button29.Enabled = false;
            button29.TabStop = false;
            gameLogic();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            guessFromUser = "\'";
            // grey out button
            button30.Enabled = false;
            button30.TabStop = false;
            gameLogic();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!label6.Visible)
            {
                label6.Visible = true;
                button28.Text = "Hide Word";
            }
            else
            {
                label6.Visible = false;
                button28.Text = "Show Word (for debugging)";
            }
        }
    }
}
