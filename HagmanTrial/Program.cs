// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// a pool words to be randomized, in form of an array
using GameClass;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

        //Console.WriteLine("Enter the guess characters below...");
        //Console.ReadLine();

GameOne Man = new GameOne();
Man.lives = 6;
Man.letters = new List<string>();
Man.randomWords = new string[4];
Man.checkingLetters();

string[] randomWords = { "apples", "kiwi", "avocado", "bananas" };


Random random = new Random();

string chosenWord = randomWords[random.Next(randomWords.Length)];


        Console.Write("Type in a letter: ");


        var key = Console.ReadKey().Key.ToString().ToLower();


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

if (lives > 0)
        {

            Console.WriteLine($"You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
        }
        else
        {
            Console.WriteLine($"You lost! The word was {chosenWord}.");
        }