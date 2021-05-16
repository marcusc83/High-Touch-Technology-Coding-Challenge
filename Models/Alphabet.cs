using System.Collections.Generic;

namespace HIghTouch_CodeChallenge.Models
{
    //creates the Alphabet that will let me test user input against
    class Alphabet
    {
        static char[] alphabet  = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

         public List<char> SetAlphabetList()
        {
            List<char> alphabetList = new List<char>(alphabet);
            return alphabetList;
        }
    }
}
