using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HIghTouch_CodeChallenge.Models;
using HIghTouch_CodeChallenge.Helpers;

namespace HIghTouch_CodeChallenge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnUserInput_Click(object sender, EventArgs e)
        {
            //sets user input into an Instance of UserInput
            UserInput input = new UserInput();
            input.SetInput(txbxUserInput.Text);

            //setting textxtbox of total characters
            char[] myCharArray = input.GetInput().ToCharArray();
            txbxTotalCharacters.Text = myCharArray.Length.ToString();

            //create an instance and call GetLeftOverLetters method to run main logic
            //returns a list of characters 
            LeftoverLettersGetter leftoverletters = new LeftoverLettersGetter();
            List<char> AlphabetList = leftoverletters.GetLeftOverLetters(input);

            //Sets txbxResults and total letters to form
            string results = "";
            foreach(char letter in AlphabetList)
            {
                results += letter + ", ";
            }

            
            txbxResults.Text = results.TrimEnd(' ', ',');

            txbxLeftoverLetterTotal.Text = AlphabetList.Count.ToString();

        }
        //closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clears all textboxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbxResults.Clear();
            txbxLeftoverLetterTotal.Clear();
            txbxUserInput.Clear();

        }
        //keeps track of total number of characters as you type
        private void txbxUserInput_TextChanged(object sender, EventArgs e)
        {
            char[] TotalCharacterArray = txbxUserInput.Text.ToCharArray();
            txbxTotalCharacters.Text = TotalCharacterArray.Length.ToString();
        }

        //Loads With Text in Text Box and Keeps Track Of Number of Characters
        private void frmMain_Load(object sender, EventArgs e)
        {
            char[] TotalCharacterArray = txbxUserInput.Text.ToCharArray();
            txbxTotalCharacters.Text = TotalCharacterArray.Length.ToString();
        }
    }
}