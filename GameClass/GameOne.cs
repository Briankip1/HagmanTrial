using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    public class GameOne
    {
        public int lives;
        public List<string> letters;
        public string[] randomWords;

        public void checkingLetters()
        {
            while (lives != 0)
            {
                int charactersLeft = lives;

                foreach (string word in randomWords)
                {
                    string letter = word.ToString();
                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }

                    else
                    {
                        Console.Write("_");

                        charactersLeft++;
                    }

                }
                if (charactersLeft == 0)
                {
                    break;
                }


            }

        }
    }



}
    
