// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

String[] fruits = { "apples", "kiwi", "avocado", "bananas" };

Console.WriteLine("Enter the guess characters below...");
Console.ReadLine();

Random random = new Random();

string chosenWord = fruits[random.Next(fruits.Length)];
var lives = 6;

List<string> letters = new List<string>();

while(lives > 0)
{
    int charactersLeft = 0;

    foreach (string word in fruits)
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
   Console.WriteLine(string.Empty);


    if (charactersLeft == 0)
    {
        break;
    }

    Console.Write("Type in a letter: ");


    var key = Console.ReadKey().Key.ToString().ToLower();
    Console.WriteLine(string.Empty);


    if (letters.Contains(key))
    {
    
        Console.WriteLine("You already entered this letter!");
        continue;
    }


    letters.Add(key);


    if (!chosenWord.Contains(key))
    {
        lives--;

   
        if (lives > 0)
        {
        
            Console.WriteLine($"The letter {key} is not in the word. You have {lives} {(lives == 1 ? "try" : "tries")} left.");
        }
    }
    }

}
    if (lives > 0)
    {
   
        Console.WriteLine($"You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
    }
    else
    {
        Console.WriteLine($"You lost! The word was {chosenWord}.");
    }
        }
    }

/*
public string Playerguess()
{
    Console.WriteLine("Enter the guess character below: ");

    string guessChar = Console.ReadLine();
     if(chosenWordChar != guessChar)
    {
        Console.WriteLine("That is the correct character for the chosen word");
    }
    
}
*/