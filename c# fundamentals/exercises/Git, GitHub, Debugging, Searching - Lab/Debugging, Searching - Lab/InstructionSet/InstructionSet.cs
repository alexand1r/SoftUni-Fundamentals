using System;

namespace InstructionSet
{
    class InstructionSet
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            long result = 0;

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                result = 0;

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
