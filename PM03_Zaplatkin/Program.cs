using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03_Zaplatkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = -1;
            Console.Write("Введите количество поездок для создания (целое число больше 0): ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Ошибка! Число введено с ошибкой! Введите количество поездок для создания (целое число больше 0): ");
            } 

            TouristicOperator touristicOperator = new TouristicOperator(N);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Поездка №" + (i + 1));
                try
                {
                    Trip trip = new Trip();
                    Console.Write("Введите длительность поездки (непустая строка): ");
                    trip.SetDuration(Console.ReadLine());
                    Console.Write("Введите цену поездки (число больше нуля): ");
                    trip.SetPrice(decimal.Parse(Console.ReadLine())); ;
                    Console.Write("Введите размер туристической группы поездки (число больше нуля): ");
                    trip.SetTourGroupSize(int.Parse(Console.ReadLine()));
                    touristicOperator.SetTripByIndex(trip, i);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ошибка! Вы ввели отличное от числа значение! Заполните информацию о поездке заново!");
                    i--;
                    continue;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Ошибка! Вы не ввели никакого значения! Заполните информацию о поездке заново!");
                    i--;
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message + " Заполните информацию о поездке заново!");
                    i--;
                    continue;
                }
            }
            Console.WriteLine("Несортированные данные: ");
            foreach (var t in touristicOperator.GetTrips())
            {
                Console.WriteLine(t);
            }

            touristicOperator.SortByPriceAndTourGroupSizeAsc();

            Console.WriteLine("\nОтсортированные данные по цене и размеру туристической группы: ");
            foreach (var t in touristicOperator.GetTrips())
            {
                Console.WriteLine(t);
            }
        }
    }
}
