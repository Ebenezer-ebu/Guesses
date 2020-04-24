using System.Runtime.Serialization.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Data;
using System.Collections.Generic;
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> level = new List<string> ();
            level.Add("Easy");
            level.Add("Meduim");
            level.Add("Hard");
            int input = 0;
            int select = 0;

            Console.WriteLine("This is a guessing game input 0 for " + level[0] + ", 1 for " + level[1] + " and 2 for "+ level[2] + "?; ");
            input = int.Parse(Console.ReadLine());

            if(input == 0) 
            { 
                int guess = 6;
                for(int i = 0; i < 6; i++) 
                {
                Console.WriteLine("This is " + level[0] + " level choose six numbers between 1-10?; ");
                select = int.Parse(Console.ReadLine());
                
                if(select <= 10 && select >= 1)  
                { 
                    if(select %2 == 0) 
                    {
                      Console.Write("You got it right");
                      Console.WriteLine();
                    } 
                    else
                    {
                      Console.Write("That was wrong");
                      Console.WriteLine();
                    }    
                }
                guess = guess - 1;
                Console.WriteLine("You have " + guess + " guesses left");

                }
                Console.WriteLine();
                Console.WriteLine("Game Over");
            } 
            else if(input == 1)
            {
                int guess = 4;
                for(int i = 0; i < 4; i++)
                {
                Console.WriteLine("This is " + level[1] + " level choose four numbers between 1- 20?; ");
                select = int.Parse(Console.ReadLine());

                if(select <= 20 && select >= 1) 
                {
                    if(select %3 == 0) 
                    {
                       Console.Write("You got it right");
                       Console.WriteLine();
                    }
                    else
                    {
                       Console.Write("That was wrong");
                       Console.WriteLine();  
                    }
                }
                guess = guess - 1;
                Console.WriteLine("You have " + guess + " guesses left");
                }
                Console.WriteLine();
                Console.WriteLine("Game Over");
            } 
            else if(input == 2) 
            {
                int guess = 3;
                for(int i = 0; i < 3; i++) 
                {
                Console.WriteLine("This is " + level[2] + " level choose three numbers between 1- 50?; ");
                select = int.Parse(Console.ReadLine());
                
                if(select <= 50 && select >= 1) 
                {
                    if(select % 11 == 0) 
                    {
                      Console.Write("You got it right");
                      Console.WriteLine();
                    }
                    else
                    {
                      Console.Write("That was wrong");
                      Console.WriteLine();
                    }
                }
                guess = guess - 1;
                Console.WriteLine("You have " + guess + " guesses left");
                } 
                Console.WriteLine();
                Console.WriteLine("Game Over");
            } 
            else
            {
               Console.WriteLine("Put in a Number between 0 - 2");
            }
            {
                
            }
        }
    }
}
