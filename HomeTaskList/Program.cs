using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            //стр 108 № 17, 19, 22
            Console.WriteLine("Задание 17");
            Console.WriteLine("Заполнить список послеовательностью случайных различных целых чисел и " +
                "просуммировать элементы этого списка, расположенные между минимальным и максимальным элементами" +
                "(если минимальный элемент предшествует максимальному)");
            Random random = new Random();
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            List<int> vs = new List<int>(N);
            for (int i = 0; i < N; i++)
                vs.Add(random.Next(-100, 100));
            Console.WriteLine("Исходный массив:");
            PrintList(vs);
            int min = int.MaxValue;
            int max = int.MinValue;
            int imin = 0;
            int imax = 0;
            for (int i = 0; i < N; i++)
            {
                if (vs[i] < min)
                {
                    min = vs[i]; 
                    imin = i;
                }
                if (vs[i] > max)
                {
                    max = vs[i]; 
                    imax = i;
                }
            }
            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Максимальное число: " + max);
            
            var first = Math.Min(imin, imax);
            var last = Math.Max(imin, imax);
            
            var sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (i > first && i < last)
                    sum += vs[i];                
            }
            Console.WriteLine("Сумма чисел: " + sum);

            Console.WriteLine("Задание 19");
            Console.WriteLine("Дан список, содержащий натуральные числа. " +
                "Удалить из неего элементы кратные заданному числу k");            
            Console.WriteLine("Введите N:");
            int M = int.Parse(Console.ReadLine());
            List<int> vs1 = new List<int>(M);
            for (int i = 0; i < M; i++)
                vs1.Add(random.Next(-100, 100));
            Console.WriteLine("Исходный массив:");
            PrintList(vs1);
            Console.WriteLine("Введите k:");
            int k = int.Parse(Console.ReadLine());
            for(int i = 0; i < M; i++)
            {
                vs1.RemoveAll(x => x % k == 0);
            }
            Console.WriteLine("Результат:");
            PrintList(vs1);

            Console.WriteLine("Задание 22");
            Console.WriteLine("Дан список, содержащий целые числа. " +
                "Определить количество различных элементов этого списка.");            
            Console.WriteLine("Введите N:");
            int K = int.Parse(Console.ReadLine());
            List<int> vs2 = new List<int>(K);
            for (int i = 0; i < K; i++)
                vs2.Add(random.Next(-100, 100));
            Console.WriteLine("Исходный массив:");
            PrintList(vs2);
            List<int> vsRes = vs2.Distinct().ToList();
            Console.WriteLine("Результат:");
            PrintList(vsRes);
            int count = vsRes.Count();
            Console.WriteLine("Количество различных элементов списка: " + count);
            Console.ReadKey();
        }

        private static void PrintList(List<int> vs)
        {
            foreach (var c in vs)
                Console.WriteLine(c);
        }
    }
}
