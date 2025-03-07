﻿using System;

namespace MathGame.kirielss
{
    internal class Game
    {
        static public int MAX = 1000;

        public Random A = new Random();

        public Random B = new Random();

        public int X { get; private set; }
        public int Y { get; private set; }

        public int Selector { get; private set; }
        public string Question { get; private set; }
        public int Result { get; private set; }

        public Game(int selector) {
            Selector = selector;
        }

        public void Operation()
        {

            switch (Selector)
            {
                case 1:
                    X = A.Next(MAX);
                    Y = B.Next(MAX);
                    Result = X + Y;
                    Question = ($"{X} + {Y} = ");
                    Console.Write(Question);
                    break;

                case 2:
                    X = A.Next(MAX);
                    Y = B.Next(MAX);
                    Result = X - Y;
                    Question = ($"{X} - {Y} = ");
                    Console.Write(Question);
                    break;

                case 3:
                    X = A.Next(MAX);
                    Y = B.Next(100);
                    Result = X * Y;
                    Question = ($"{X} x {Y} = ");
                    Console.Write(Question);
                    break;

                case 4:
                    X = A.Next(100);
                    Y = B.Next(1,9);
                    Result = X / Y;
                    Question = ($"{X} / {Y} = ");
                    Console.Write(Question);
                    break;
                    
            }

        }




    }
}
