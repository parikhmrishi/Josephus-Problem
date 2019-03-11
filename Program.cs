using System;

namespace Josephus_Problem
{
    class Program
    {

        public static int Josephus(int number_of_people, int person_to_skip)
        {
            int safe_position;

            if (number_of_people == 1)
                return 1;
            else
            {
                safe_position = Josephus(number_of_people - 1, person_to_skip) + person_to_skip;
                if (safe_position > number_of_people)
                    safe_position = safe_position - number_of_people;
                return safe_position;
            }
        }
        static void Main(string[] args)
        {
            int safe_position = 0;
            Console.WriteLine("Enter the number of people:");
            int number_of_person = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of people to skip:");
            int person_to_skip = int.Parse(Console.ReadLine()) + 2;

            safe_position = Josephus(number_of_person, person_to_skip);
            Console.WriteLine("Safe position is " + safe_position);
            Console.ReadLine();
        }
    }
}
