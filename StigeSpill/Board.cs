using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace StigeSpill
{
    class Board
    {
        private int _board;
        private int _width;
        private object board;
        private int player1X = 0;
        private int player1Y = 9;
        

        public int X { get; private set; }
        public object LadderBoard { get; internal set; }

        public String[,] generateArray2D()
        {

            string[,] array2D = new string[,]
            {
                {"  90", "  89", "  88", "  87", "  86", "  85", "  84", "  83", "  82"},
                {"  73", "  74", "  75", "  76", "  77", "  78", "  79", "  80", "  81"},
                {"  72", "  71", "  70", "  69", "  68", "  67", "  66", "  65", "  64"},
                {"  55", "  56", "  57", "  58", "  59", "  60", "  61", "  62", "  63"},
                {"  54", "  53", "  52", "  51", "  50", "  49", "  48", "  47", "  46"},
                {"  37", "  38", "  39", "  40", "  41", "  42", "  43", "  44", "  45"},
                {"  36", "  35", "  34", "  33", "  32", "  31", "  30", "  29", "  28"},
                {"  19", "  20", "  21", "  22", "  23", "  24", "  25", "  26", "  27"},
                {"  18", "  17", "  16", "  15", "  14", "  13", "  12", "  11", "  10"},
                {"   1", "   2", "   3", "   4", "   5", "   6", "   7", "   8", "   9"}
            };
            char[] cellChars = array2D[player1Y, player1X].ToCharArray();
            cellChars[0] = 'T';

            array2D[player1Y, player1X] = new String(cellChars);


            char[] cellChars1 = array2D[player1Y, player1X].ToCharArray();
            cellChars[1] = 'C';

            array2D[player1Y, player1X] = new String(cellChars);


            return array2D;
        }
        public void show()
        {



            //Antall array som vi har. [,] den gjør array 2Dimensjonal, som vi trenger for å ha array inni en array. 
            
            //Hvilke tall i array som får farge. 
            string[] greenSpaces = new string[] {"   1", "   8", "  36", "  43", "  49", "  65", "  68"};
            string[] lightRedSpaces = new string[] {"   3", "   5", "  12", "  27", "  37", "  70"};
            string[] lightBlueSpaces = new string[] {"  10", "  40", "  52", "  62", "  79", "  82", "  85"};
            string[] redSpaces = new string[] {"  24", "  33", "  42", "  56", "  64", "  74", "  87"};
            string[] orangeSpaces = new string[] {"  90"};
            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 0; i < generateArray2D().GetLength(0); i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if
                        (greenSpaces.Any(generateArray2D()[i, j].Contains))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");
                    }
                    else if (lightRedSpaces.Any(generateArray2D()[i, j].Contains))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");
                    }
                    else if (lightBlueSpaces.Any(generateArray2D()[i, j].Contains))
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");
                    }
                    else if (redSpaces.Any(generateArray2D()[i, j].Contains))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");
                    }
                    else if (orangeSpaces.Any(generateArray2D()[i, j].Contains))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.Write(generateArray2D()[i, j]);

                        Console.Write("|");

                    }
                }

                Console.Write("\n");
                Console.BackgroundColor = ConsoleColor.White;
            }

            


        }

        public void Draw()
        {
            for(var y = 0; y < _board; y++)
                for(var x = 0; x < _width; x++)
            Console.SetCursorPosition(X * 4, y);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("X, Y");
        }

       


    }
}
