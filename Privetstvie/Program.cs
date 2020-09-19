using System;

namespace Privetstvie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут ?");
            string Username = Console.ReadLine();
            Console.WriteLine(Username + " Напишите день своего рождения");
            int day = int.Parse(Console.ReadLine());
            if (day > 31 | day < 1)
            { 
                Console.WriteLine("Вы допустили ошибку, попробуйте ещё раз");
                return;
            }
            Console.WriteLine("Напишите месяц своего рождения");
            int mouth = int.Parse(Console.ReadLine());
            if (mouth > 12 | mouth < 1)
            { 
                Console.WriteLine("Вы допустили ошибку, попробуйте ещё раз");
                return;
            }
                else if (mouth == 2 && day > 29)
            {
                Console.WriteLine("Вы допустили ошибку, попробуйте ещё раз");
                return;
            }
            else
            Console.WriteLine("Напишите год своего рождения");
            int year = int.Parse(Console.ReadLine());
            int visyaer = (year % 4);
              if (day == 29 && mouth == 2 && visyaer != 0)
            {
                Console.WriteLine("Вы допустили ошибку, попробуйте ещё раз");
                return;
            }
            DateTime bday = new DateTime(year, mouth, day);
            DateTime now = DateTime.Today;
            int age = now.Year - bday.Year;
            if (age <= 0 | age >= 100)
            {
                Console.WriteLine("Вы допустили ошибку, попробуйте ещё раз");
                return;
            }
            Console.WriteLine($"Ваш возраст {age} лет");
            

        }
    }
}
