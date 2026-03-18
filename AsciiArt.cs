using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace POEPart1
{
    internal static class AsciiArt
    {
            public static void DisplayLogo()
        {
            string logo = @"
      ┌─────────────────────┐
      │   CYBERSECURITY     │
      │     AWARENESS BOT   │
      └─────────────────────┘
             ______
            /      \
           |  LOCK  |
           |        |
            \______/
             |    |
             |    |
             |____|
   Protecting your digital world...
";
            Console.WriteLine(logo);
        }
    }
}
