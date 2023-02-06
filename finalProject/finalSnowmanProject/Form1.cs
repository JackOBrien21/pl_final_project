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

        private List<String> words;
        private string randomWordChoice;
        private string wordToDisplay;
        private int numWrongGuesses;
        private SortedSet<char> prevGuesses = new SortedSet<char>();
        public Form1()
        {
            InitializeComponent();

            words = File.ReadAllLines("dictionary.txt").ToList();
            Random random = new Random();
            randomWordChoice = words[random.Next(0, words.Count)];
            wordToDisplay = new string('_', randomWordChoice.Length);
            numWrongGuesses = 0;
            richTextBox1.Text = wordToDisplay;
            richTextBox1.ReadOnly = true;
            label1.Text = "Incorrect Guesses: " + numWrongGuesses;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            char guess = textBox1.Text[0];
            if (prevGuesses.Contains(guess)) {
                MessageBox.Show("You alreaded gussed the letter " + guess + " , please try another.");
                return;
            }
            else
            {
                MessageBox.Show("Adding " + guess + " to the set.");
                prevGuesses.Add(guess);
                listBox1.Items.Clear(); // Item's aren't in sorted order so clear and then add each item back in sorted order
                foreach (char c in prevGuesses) 
                {
                    listBox1.Items.Add(c);
                }
            }
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
            if (!correctGuess)
            {
                numWrongGuesses++;
                label1.Text = "Incorrect Guesses: " + numWrongGuesses;
            }
            wordToDisplay = new string(word);
            richTextBox1.Text = wordToDisplay;
            if (numWrongGuesses == 6)
            {
                pictureBox6.BringToFront();
                pictureBox6.Visible = true;
                MessageBox.Show("You lost! The word was " + randomWordChoice);
                Close();
            }
            else if (!wordToDisplay.Contains('_'))
            {
                MessageBox.Show("You won!");
                Close();
            }
            if (numWrongGuesses >= 1)
            {
                pictureBox1.Visible = true;
            }
            if (numWrongGuesses >= 2)
            {
                pictureBox2.Visible = true;
            }
            if (numWrongGuesses >= 3)
            {
                pictureBox3.Visible = true;
            }
            if (numWrongGuesses >= 4)
            {
                pictureBox4.Visible = true;
            }
            if (numWrongGuesses >= 5)
            {
                pictureBox5.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
