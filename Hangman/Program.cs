using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Random;
using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        // creating metod to output a conditional response if te user needs to tryagain after a wrong response
        private static void DisplayHangman(int wrongChoice)
        {
            //will display the hangman with each incorrect 'wrong choice' guess
            if (wrongChoice == 0)
            {
                Console.WriteLine("\n|---+");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine("\n");
            }
            else if (wrongChoice == 1)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine("\n");
            }

            else if (wrongChoice == 2)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            else if (wrongChoice == 3)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            else if (wrongChoice == 4)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            else if (wrongChoice == 5)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   /");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
            }

            else if (wrongChoice == 6)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");

            }
        }
        //method to display character guess and display generated random word from list
        private static int DisplayGuess(List<char> guessedLetters, String surpriseWord)
        {
            int incrementor = 0;
            int correctGuess = 0;
            Console.Write("\r\n");

            //create a loop method that iterates through each character of the surpriseWord string
            foreach (char c in surpriseWord)
            {
                //the first conditional statement iterates past a character space or character hyphen within the string
                if (c == '_' || c == '-')
                {
                    correctGuess++;

                }

                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");

                    correctGuess++;

                }
                else
                {
                    Console.Write("  ");
                }
                incrementor++;
            }
            return correctGuess;
        }
        //display lines underneath words to show words that are left to be guessed

        private static void DisplayLines(String surpriseWord)
        {
            Console.Write("\r");
            foreach (char c in surpriseWord)
            {
                //easier to use unicode to display lines on the next returned line at the top below the above words displayed from the loop method than just using an underscore character
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("     |/|/ /\n" +
                    "     |/| /\n" +
                    "    (¯¯¯)\n" +
                    "    (¯¯¯)\n" +
                    "    (¯¯¯)\n" +
                    "    (¯¯¯)\n" +
                    "    (¯¯¯)\n" +
                    "    /¯¯/\\ \n" +
                    "   / ,^./\\ \n" +
                    "  / /   \\/\\ \n" +
                    " / /     \\/\\ \n" +
                    "( (       )/)\n" +
                    "| |       |/|\n" +
                    "| |       |/|\n" +
                    "| |       |/|\n" +
                    "( (       )/)\n" +
                    " \\ \\     / /\n" +
                    "  \\ `---' /\n" +
                    "   `-----'\n" +
                    "888\n" +
                    "888\n" +
                    "888\n" +
                    "88888b.   8888b.  88888b.  .d88b.  88888b.d88b.    8888b.  88888b.\n" +
                    "888  88b      88b 888  88b d88P 88 b888  888  88b      88b 888  88b \n" +
                    "888  888 .d888888 888  888 888  88 8888  888  888 .d888888 888  888 \n" +
                    "888  888 888   88 888  888 Y88b 88 8888  888  888  888  88 888  888     \n" +
                    "888  888 Yd8888Y  888  888     888 8888  888  888  Yd8888Y 888  888       \n " +
                     "                          8b_d88P            \n" +
                    "                           bY88Pd             \n" +
                    "                                                                     \n" +
                    "                                                                     \n" +
                    "                                                                     \n" +
                    "                                                                     \n" +
                    "                            d88O88b    \n" +
                    "                            b8P  P8b  \n" +
                    "                            88    88   \n" +
                    "                            8888bd8Y d88       888 \n" +
                    "                            888b8b.   d8P     88b \n" +
                    "                            888  88b   888   888 \n" +
                    "                            888  d888   Y8b 88  \n" +
                    "                            888bd888Y    YY88   \n" +
                    "                                        888  \n" +
                    "                                       888  \n" +
                    "                                      88b\n" + "                                                                     \n" +
                    "                                                                     \n" +
                    "                                                                     \n" +
                    "                                                                     \n" +

                     "                      source code: https://github.com/B-ANTONY-J/Hangman.git\n" +
                    "         88888b.d88b.    8888b.  88888b. .d88b.      888  .d8888888888b. 8888b.    \n" +
                    "         b888  888  88b      88b 888  88b  d88P     88b8  b88    8888b.  8888b      \n" +
                    "         8888  888  888 .d888888 888  888   8888   8888   88888.d8888    8888b  8888 \n" +
                    "         8888  888  888 888  888 888         Y88b 8888    888        b   8888b  8888\n" +
                    "         8888  888  888  Y888888 888          Y88888      8888888888b    8888b888888\n" +
                    "                                                                                       \n" +
                    "                                  By The Avengers: End Game\n");

            Console.WriteLine("Let's Play Hangman: The Marvel Edition!!!\n\n");
            Random random = new Random();
            //create wordlist for "surpriseWord" string
            List<string> wordBank = new List<string> { "Captain America", "Iron Man", "Stan Lee", "The Incredible Hulk", "Thor", "Black Widow", "Hawkeye", "Guardians of the Galaxy",
                "Ant-Man", "Doctor Strange", "Black Panther", "Spider-Man", "Captain Marvel", "Scarlet Witch", "The Vision", "Falcon", "War Machine", "Winter Soldier", "Bucky Barnes", "Star-Lord",
                "Gamora", "Peter Quill", "Peter Parker", "Nick Fury", "Drax", "Rocket Raccoon", "Groot", "Wasp", "Sharon Carter", "Mantis", "Odin", "Heimdall", "Howard Stark", "Maria Hill", "Nebula", "Pepper Potts",
                "Phil Coulson", "Peggy Carter", "Yondu", "Happy", "JARVIS", "The Ancient One", "Mbaku", "FRIDAY", "Valkyrie", "Korg", "Mordo", "Okoye", "May Parker", "Talos", "Wong", "Surtur", "Hank Pym", "Janet van Dyne",
                "Quicksilver", "Morgan Stark", "Shuri", "Jane Foster", "Luis", "The Collector", "The Grandmaster", "Goose", "Flerken", "Thanos", "Red Skull", "Zemo", "Hela", "Vulture", "Ego", "Ultron", "Erik Killmonger", "Loki",
                "Ronan", "Zola", "Chitauri", "Kaecilius", "The Mandarin", "Dormammu", "Supreme Intelligence", "Yellowjacket", "The Avengers", "SHIELD", "HYDRA", "End Game", "MCU", "WAKANDA" };

            //create random word selection from wordbank
            int wordBankIndex = random.Next(wordBank.Count);

            //created string to wordBank index selection and to ensure all entries print to lower case along with replacing char space with an underscore
            String surpriseWord = wordBank[wordBankIndex].ToUpper().Replace(' ', '_');

            foreach (char c in surpriseWord)
            {
                Console.Write("_ ");
            }

            int wordLengthToGuess = surpriseWord.Length;
            int wrongGuess = 0;
            //create a list to keep track of correct letters guessed
            List<char> correctGuess = new List<char>();
            int correctGuessLetters = 0;
            //var replacement = surpriseWord.Replace(' ', ' ');
            //end game


            //while loop to initiate game play until correct guess or exceeded 6 attempts
            while (wrongGuess != 6 && correctGuessLetters != wordLengthToGuess)
            {
                Console.Write("\nAll Letters Guessed: ");
                foreach (char correct in correctGuess)
                {
                    Console.Write(correct + " ");
                }

                /* if (correctGuessLetters == wordLengthToGuess)
                 {
                     Console.WriteLine("\r\nExcelent job, You WON!!!\n");
                 }*/

                Console.Write("\nGuess a letter: ");
                char letterDisplay = Console.ReadLine().ToUpper()[0];
                
                if (correctGuess.Contains(letterDisplay))
                {

                    Console.Write("\r\nUh Oh - You've seemed to have selected this letter already.  Try Again!!!");
                    DisplayHangman(wrongGuess);
                    correctGuessLetters = DisplayGuess(correctGuess, surpriseWord);
                    DisplayLines(surpriseWord);
                }

                else
                {
                    //if the wrong lettered guessed is not in the word
                    bool letterIsCorrect = false;
                    //loop through surprise word to see if it equals guessed words
                    for (int i = 0; i < surpriseWord.Length; i++)
                    {
                        if (letterDisplay == surpriseWord[i])
                        {
                            letterIsCorrect = true;
                        }
                    }
                    if (letterIsCorrect)
                    {
                        DisplayHangman(wrongGuess);
                        correctGuess.Add(letterDisplay);
                        //surpriseWord;
                        correctGuessLetters = DisplayGuess(correctGuess, surpriseWord);
                        Console.Write("\r\n");
                        DisplayLines(surpriseWord);

                        ///Congratulates the user the game has concluded when teh correct guesses equals the correct word length
                        if (correctGuessLetters == wordLengthToGuess)
                        {
                            Console.Write("\r\nExcellent job, You WON!!!\n");
                        }

                    }
                    //when the user guess is wrong
                    else
                    {
                        wrongGuess++;
                        correctGuess.Add(letterDisplay);
                        DisplayHangman(wrongGuess);
                        correctGuessLetters = DisplayGuess(correctGuess, surpriseWord);
                        Console.Write("\r\n");
                        DisplayLines(surpriseWord);

                        if (wrongGuess == 6)
                        {
                            string endingString = surpriseWord.Replace('_', ' ').ToUpper();
                            Console.Write($"\r\nGame over - Better luck next time. Your word was {endingString}!\n");
                        }
                    }

                }

            }
            Console.WriteLine("\nPlease Play again!\nPress any key to continue...\n");
            //pauses the program upon completion without directly exiting the screen
            Console.ReadKey();

        }
    }
}