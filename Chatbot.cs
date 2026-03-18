using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal static class Chatbot
    {
        public static void HandleInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                return;

            }
            switch (input.ToLower())
            {
                case "how are you?":
                    Console.WriteLine("Bot: I'm functioning perfectly, thanks for asking!");
                    break;

                case "what's your purpose?":
                    Console.WriteLine("Bot: My purpose is to help you learn about cybersecurity and stay safe online.");
                    break;

                case "what can i ask you about?":
                    Console.WriteLine("Bot: You can ask me about password safety, phishing, and safe browsing practices.");
                    break;

                case "password safety.":
                    Console.WriteLine("Bot: Always use long, unique passwords and enable two-factor authentication where possible.");
                    break;

                case "phishing.":
                    Console.WriteLine("Bot: Be cautious of emails or messages asking for personal info. Check links carefully before clicking.");
                    break;

                case "safe browsing.":
                    Console.WriteLine("Bot: Stick to trusted websites, keep your browser updated, and avoid downloading files from unknown sources.");
                    break;

                default:
                    Console.WriteLine("Bot: I’m not sure how to answer that yet. Try asking about passwords, phishing, or safe browsing.");
                    break;
            }
        }
    }
}
