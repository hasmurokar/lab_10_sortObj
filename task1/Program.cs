using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var list = new List<CityBuild>();
            for (int i = 1; i <= 5; i++)
            {
                var cName = "Building " + rnd.Next(1, 9);
                var bObject = "Object " + rnd.Next(1, 9);
                var square = rnd.Next(20, 100);
                var sDate = RandomDay();
                var eDate = RandomDay().AddYears(rnd.Next(5, 7));
                var state = "No Info";
                list.Add(new CityBuild(cName, bObject, square, sDate, eDate, state));
            }

            Outputer(list);
            list.Sort();
            Console.WriteLine("Сортировка по названию компании");
            Outputer(list);
            Console.WriteLine("Сортировка по названию здания");
            list.Sort(new CityBuild.SortByBuildObject());
            Outputer(list);
            Console.WriteLine("Сортировка по площади строения");
            list.Sort(new CityBuild.SortBySquare());
            Outputer(list);
            Console.WriteLine("Сортировка по дате начала строительства");
            list.Sort(new CityBuild.SortByStartDate());
            Outputer(list);

        }
        public static DateTime RandomDay()
        {
            var start = new DateTime(2018, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        private static void Outputer(List<CityBuild> builds)
        {
            Console.WriteLine("Название     |Объект        |Площадь   |Дата начала |Дата окончания|Состояние   | Остаток дней");
            foreach (var item in builds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        public static bool IsEndFourQurtal(DateTime endDate)
        {
            var startQ = new DateTime(2022, 10, 1);
            var endQ = new DateTime(2022, 12, 31);
            if (endDate > startQ && endDate < endQ)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
