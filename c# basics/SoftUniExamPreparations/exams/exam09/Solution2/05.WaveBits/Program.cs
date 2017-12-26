using System;

class Program
{
    static void Main()
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());
        ulong mask = 7; //101

        int waveLength = 0;
        int waveStartBit = 0;
        int longestWave = 0;
        int longestWaveStartBit = 0;

        bool waveFound = false;
        bool atWave = false;
        for (int bit = 0; bit < 61; bit++)
        {
            ulong checkedBits = (inputNumber & (mask << bit)) >> bit;

            if (checkedBits == 5)
            {
                waveLength++;
                waveFound = true;

                if (atWave == false)
                {
                    atWave = true;
                    waveStartBit = bit;
                }

                bit++;
            }
            else
            {
                atWave = false;
                if (waveLength > longestWave)
                {
                    longestWave = waveLength;
                    longestWaveStartBit = waveStartBit;
                }

                waveLength = 0;
            }
        }

        if (waveFound)
        {
            Console.WriteLine(ConvertToBinary(inputNumber).PadLeft(20, '0'));
            string bits = new string('1', longestWaveStartBit);
            bits = (bits == "") ? "0" : bits;
            ulong notChangedBits = inputNumber & (Convert.ToUInt64(bits, 2));

            inputNumber >>= (longestWave * 2 + 1) + longestWaveStartBit;
            inputNumber <<= longestWaveStartBit + 1;
            inputNumber = inputNumber | notChangedBits;

            Console.WriteLine(ConvertToBinary(inputNumber).PadLeft(20, '0'));
            Console.WriteLine(inputNumber);
        }
        else
        {
            Console.WriteLine("No waves found!");
        }
        
    }

    public static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        return b.ToString();
    }
}

