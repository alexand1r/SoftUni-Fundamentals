using System;

namespace DecryptTheMessages
{
    class DecryptTheMessages
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "start" && command != "START")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            int countMessages = 0;
            string encryptedMessage = String.Empty;

            while (command != "end" && command != "END")
            {
                if (string.IsNullOrWhiteSpace(command))
                {
                    command = Console.ReadLine();
                    continue;
                }

                for(int i = command.Length - 1 ; i >= 0; i--)
                {
                    char currentSymbol = command[i];

                    if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                    {
                        encryptedMessage += (char)(currentSymbol + 13);
                    }
                    else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                    {
                        encryptedMessage += (char)(currentSymbol - 13);
                    }
                    else if ('0' <= currentSymbol && currentSymbol <= '9')
                    {
                        encryptedMessage += currentSymbol;
                    }
                    else
                    {
                        switch (currentSymbol)
                        {
                            case '+': encryptedMessage += ' '; break;
                            case '%': encryptedMessage += ','; break;
                            case '&': encryptedMessage += '.'; break;
                            case '#': encryptedMessage += '?'; break;
                            case '$': encryptedMessage += '!'; break;
                        }
                    }
                }
                encryptedMessage += Environment.NewLine;
                countMessages++;

                command = Console.ReadLine();
            }
            if (countMessages == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", countMessages);

                Console.Write(encryptedMessage);
            }
        }
    }
}
