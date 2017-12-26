using System;
using System.Collections;

namespace EncryptTheMessages
{
    class EncryptTheMessages
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ArrayList encryptedMessages = new ArrayList();
            string encrypt = string.Empty;
            int counter = 0;

            command = Console.ReadLine();

            while (command != "START" && command != "start")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "END" && command != "end")
            {
                if (string.IsNullOrWhiteSpace(command))
                {
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    char current = command[i];
                    if ((current >= 'a' && current <= 'm') || (current >= 'A' && current <= 'M'))
                    {
                        encrypt += (char)(current + 13);
                    }
                    else if ((current >= 'n' && current <= 'z') || (current >= 'N' && current <= 'Z'))
                    {
                        encrypt += (char)(current - 13);
                    }
                    else if (current >= '0' && current <= '9')
                    {
                        encrypt += current;
                    }
                    else
                    {
                        switch (current)
                        {
                            case ' ': encrypt += '+'; break;
                            case ',': encrypt += '%'; break;
                            case '.': encrypt += '&'; break;
                            case '?': encrypt += '#'; break;
                            case '!': encrypt += '$'; break;
                        }
                    }
                }
                
                encryptedMessages.Add(encrypt);
                counter++;
                encrypt = string.Empty;
                
                command = Console.ReadLine();
            }
            if (counter == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", counter);

                foreach (var item in encryptedMessages)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
