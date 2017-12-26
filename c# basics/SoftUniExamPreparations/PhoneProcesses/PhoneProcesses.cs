using System;

namespace PhoneProcesses
{
    class PhoneProcesses
    {
        static void Main(string[] args)
        {
            string innitialPower = Console.ReadLine();
            innitialPower = innitialPower.Replace('%', ' ');
            int power = int.Parse(innitialPower);
            bool isPhoneOff = false;
            bool needRecharge = false;
            int remainingProccess = 0;
            
            string command = Console.ReadLine();
            while (!command.ToLower().Equals("end"))
            {
                int percentage = int.Parse(command.Substring(command.Length - 3, 2));
                if (power > 15 )//|| power - percentage >= 0)
                {
                    power -= percentage;
                }
                else
                {
                    remainingProccess++;
                    command = Console.ReadLine();
                    continue;
                }
                command = Console.ReadLine();
            }

            if (power <= 15 && power > 0)
            {
                needRecharge = true;
            }
            else if (power <= 0)
            {
                isPhoneOff = true;
            }

            if (needRecharge)
            {
                Console.WriteLine("Connect charger -> {0}%", power);
                Console.WriteLine("Programs left -> {0}", remainingProccess);
            }
            else if (isPhoneOff)
            {
                Console.WriteLine("Phone Off");
            }
            else
            {
                Console.WriteLine("Successful complete -> {0}%", power);
            }
        }
    }
}
