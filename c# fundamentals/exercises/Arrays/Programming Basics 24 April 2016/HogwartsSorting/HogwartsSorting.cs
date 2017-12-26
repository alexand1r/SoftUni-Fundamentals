using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class HogwartsSorting
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int gryffindorCount = 0, slytherinCount = 0
                , ravenclawCount = 0, hufflepuffCount = 0;

            for (int i = 0; i < n; i++)
            {
                string initials = Console.ReadLine();
                char firstNameLetter = initials[0];
                char lastNameLetter = initials[initials.IndexOf(" ") + 1];

                string name = initials.Replace(" ", "");
                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    int current = (int)name[j];
                    sum += current;
                }

                int reminder = sum % 4;

                switch (reminder)
                {
                    case 0: gryffindorCount++;
                        Console.WriteLine("Gryffindor {0}{1}{2}"
                            , sum, firstNameLetter, lastNameLetter);
                        break;
                    case 1: slytherinCount++;
                        Console.WriteLine("Slytherin {0}{1}{2}"
                            , sum, firstNameLetter, lastNameLetter);
                        break;
                    case 2: ravenclawCount++;
                        Console.WriteLine("Ravenclaw {0}{1}{2}"
                            , sum, firstNameLetter, lastNameLetter);
                        break;
                    case 3: hufflepuffCount++;
                        Console.WriteLine("Hufflepuff {0}{1}{2}"
                            , sum, firstNameLetter, lastNameLetter);
                        break;
                    default: break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}", gryffindorCount);
            Console.WriteLine("Slytherin: {0}", slytherinCount);
            Console.WriteLine("Ravenclaw: {0}", ravenclawCount);
            Console.WriteLine("Hufflepuff: {0}", hufflepuffCount);
        }
    }
}
