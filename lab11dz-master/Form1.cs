using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11dz
{
    public partial class Form1 : Form
    {
        private string[] words = { "кот", "дом", "стол", "окно", "книга", "ручка", "автомобиль", "дерево", "песня", "город" };
        private int correct = 0;
        private int incorrect = 0;
        private string currentWord = "";

        public Form1()
        {
            InitializeComponent();
            StartNewWord();
        }

        private void StartNewWord()
        {
            Random rnd = new Random();
            currentWord = words[rnd.Next(words.Length)];
            lblWord.Text = currentWord;
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 

                string userInput = txtInput.Text.Trim();

                if (userInput == currentWord)
                {
                    correct++;
                    lblCorrect.Text = $"Правильных слов: {correct}";
                }
                else
                {
                    incorrect++;
                    lblIncorrect.Text = $"Неправильных слов: {incorrect}";
                }

                StartNewWord();
            }
        }
    }
}
