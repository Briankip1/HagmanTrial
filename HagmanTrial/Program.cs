﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// a pool words to be randomized, in form of an array
using GameClass;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Collections;

//Console.WriteLine("Enter the guess characters below...");
//Console.ReadLine();

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input a letter here ...");

        GameOne Man = new GameOne(6);

        Man.HandleGuess();
    
        Man.Randomize();

        Man.CheckingLetters();
        






    
       
            
      

              
    }
}