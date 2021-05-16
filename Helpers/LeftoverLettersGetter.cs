using System.Collections.Generic;
using HIghTouch_CodeChallenge.Models;

namespace HIghTouch_CodeChallenge.Helpers
{
    class LeftoverLettersGetter
    {
        public List<char> GetLeftOverLetters(UserInput input)
        {
            //creates an instance of the Alphabet in order to test input against
            Alphabet alphabet = new Alphabet();
            List<char> AlphabetList = alphabet.SetAlphabetList();

            //creates an array of uppercase characters
            string upperCaseInput = input.GetInput().ToUpper();
            char[] myCharArray = upperCaseInput.ToCharArray();

            //Loop that will check inout against alphabet and create 
            //new list that contain char not used in the input
            List<char> LeftoverLetters = new List<char>();

            //Logic to test each character of the inout against each character 
            //in the alphabet, in order to get a list of unused letters.
            //returns list to submit button click event handler
            for (int i = 0; i < myCharArray.Length; i++)
            {
                for (int j = 0; j < AlphabetList.Count; j++)
                {
                    if (myCharArray[i] == AlphabetList[j])
                    {
                        AlphabetList.Remove(AlphabetList[j]);
                    }
                }
            }
            return AlphabetList;
        }
    }
}