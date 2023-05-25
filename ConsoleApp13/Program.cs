using System;
using System.Linq;
namespace ConsoleApp13
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EducationalInstitution { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //1



            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Отримати весь масив цілих
            var allNumbers = string.Join(" ", numbers);
            Console.WriteLine("Весь масив цілих:");
            Console.WriteLine(allNumbers);

            // Отримати парні цілі
            var evenNumbers = numbers.Where(number => number % 2 == 0);
            Console.WriteLine("Парні цілі:");
            Console.WriteLine(string.Join(" ", evenNumbers));

            // Отримати непарні цілі
            var oddNumbers = numbers.Where(number => number % 2 != 0);
            Console.WriteLine("Непарні цілі:");
            Console.WriteLine(string.Join(" ", oddNumbers));

            // Отримати значення більше заданого
            int a = 5;
            var amax = numbers.Where(number => number > a);
            Console.WriteLine("Значення більше " + a + ":");
            Console.WriteLine(string.Join(" ", amax));

            // Отримати числа в заданому діапазоні
            int minRange = 3;
            int maxRange = 8;
            var numbersInRange = numbers.Where(number => number >= minRange && number <= maxRange);
            Console.WriteLine("Числа в діапазоні [" + minRange + " ; " + maxRange + "]:");
            Console.WriteLine(string.Join(" ", numbersInRange));

            // Отримати числа, кратні семи, та відсортувати за зростанням
            var kr7 = numbers.Where(number => number % 7 == 0).OrderBy(number => number);
            Console.WriteLine("Числа, кратні семи, відсортовані за зростанням:");
            Console.WriteLine(string.Join(" ", kr7));

            // Отримати числа, кратні восьми, та відсортувати за спаданням
            var kr8 = numbers.Where(number => number % 8 == 0).OrderByDescending(number => number);
            Console.WriteLine("Числа, кратні восьми, відсортовані за спаданням:");
            Console.WriteLine(string.Join(" ", kr8));





            //2

            List<string> cities = new List<string> { "Kyiv", "London", "Paris", "New York", "Anta", "Nfvgk" };

            // Отримати весь масив міст
            var allCities = from city in cities
                            select city;
            Console.WriteLine("Весь масив міст:");
            Console.WriteLine(string.Join("\n", allCities));

            // Отримати міста з довжиною назви, що дорівнює заданому
            int b = 5;
            var bmax = from city in cities
                       where city.Length == b
                       select city;
            Console.WriteLine($"Міста з довжиною назви {b}:");
            Console.WriteLine(string.Join("\n", bmax));

            // Отримати міста, назви яких починаються з літери A
            var startA = from city in cities
                         where city.StartsWith("A")
                         select city;
            Console.WriteLine("Міста, назви яких починаються з літери A:");
            Console.WriteLine(string.Join("\n", startA));

            // Отримати міста, назви яких закінчуються літерою M
            var endM = from city in cities
                       where city.EndsWith("M")
                       select city;
            Console.WriteLine("Міста, назви яких закінчуються літерою M:");
            Console.WriteLine(string.Join("\n", endM));

            // Отримати міста, назви яких починаються з літери N і закінчуються літерою k
            var fi = from city in cities
                     where city.StartsWith("N") && city.EndsWith("k")
                     select city;
            Console.WriteLine("Міста назви яких починаються з літери N і закінчуються літерою K:");
            Console.WriteLine(string.Join("\n", fi));

            // Отримати міста, назви яких починаються з Ne, відсортовані за спаданням
            var citiesStartingWithNe =
                from city in cities
                where city.StartsWith("Ne")
                orderby city descending
                select city;
            Console.WriteLine("Міста, назви яких починаються з Ne (відсортовані за спаданням):");
            Console.WriteLine(string.Join("\n", citiesStartingWithNe));





            //3
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Doe", Age = 17, EducationalInstitution = "MIT" },
                new Student { FirstName = "Alice", LastName = "Smith", Age = 22, EducationalInstitution = "Oxford" },
                new Student { FirstName = "Boris", LastName = "Johnson", Age = 19, EducationalInstitution = "MIT" },
                new Student { FirstName = "Bob", LastName = "Brown", Age = 21, EducationalInstitution = "Harvard" },
                new Student { FirstName = "Andrew", LastName = "Brooks", Age = 18, EducationalInstitution = "Oxford" }
            };

            // Отримати весь масив студентів
            var allStudents = from student in students
                              select student;
            Console.WriteLine("Весь масив студентів:");
            Console.WriteLine(string.Join("\n", allStudents.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів з ім'ям Boris
            var students_NameBoris = from student in students
                                     where student.FirstName == "Boris"
                                     select student;
            Console.WriteLine("\nСписок студентів з ім'ям Boris:");
            Console.WriteLine(string.Join("\n", students_NameBoris.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів з прізвищем, яке починається з Bro
            var studentsBro = from student in students
                              where student.LastName.StartsWith("Bro")
                              select student;
            Console.WriteLine("\nСписок студентів з прізвищем, яке починається з Bro:");
            Console.WriteLine(string.Join("\n", studentsBro.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів, старших 19 років
            var students19 = from student in students
                             where student.Age > 19
                             select student;
            Console.WriteLine("\nСписок студентів, старших 19 років:");
            Console.WriteLine(string.Join("\n", students19.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів, старших 20 років і молодших 23 років
            var students20And23 = from student in students
                                  where student.Age > 20 && student.Age < 23
                                  select student;
            Console.WriteLine("\nСписок студентів, старших 20 років і молодших 23 років:");
            Console.WriteLine(string.Join("\n", students20And23.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів, які навчаються в MIT
            var MIT = from student in students
                      where student.EducationalInstitution == "MIT"
                      select student;
            Console.WriteLine("Список студентів, які навчаються в MIT:");
            Console.WriteLine(string.Join("\n", MIT.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));

            // Отримати список студентів, які навчаються в Oxford і вік яких старше 18 років, відсортований за віком, за спаданням
            var Oxford18 = from student in students
                           where student.EducationalInstitution == "Oxford" && student.Age > 18
                           orderby student.Age descending
                           select student;
            Console.WriteLine("\nСписок студентів, які навчаються в Oxford і вік яких старше 18 років, відсортований за віком, за спаданням:");
            Console.WriteLine(string.Join("\n", Oxford18.Select(student => $"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.EducationalInstitution}")));
        }
    }
}