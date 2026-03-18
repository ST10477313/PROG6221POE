using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;

namespace POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\ethan\\source\\repos\\POEPart1\\POEvoice.wav");
            player.PlaySync();

            WriteLine("Please enter your name:");
            string username = Console.ReadLine();

            AsciiArt.DisplayLogo();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(new string('*', 50));
            WriteLine("        CYBERSECURITY AWARENESS BOT");
            WriteLine(new string('*', 50));
            ResetColor();



            WriteLine($"Hello {username}! Welcome to the Cybersecurity Awareness Bot.");
            WriteLine("I’m here to help you stay safe online.");

            while (true)
            {
                WriteLine($"{username}: ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit") break;

                Chatbot.HandleInput(input);
            }
            WriteLine("Bot: Goodbye! Stay safe online.");

        }
    }
}
