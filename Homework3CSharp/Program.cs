using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayWork();  //внутри 6 заданий
            //notA();
            //lastLetter();
            //oneLetter();
            //sumNumbers();  //последняя задача на сникерс))

        }
               

        static void arrayWork()
        {
            int[] arr = new int[10];
            int even = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 20);
                //1.	Напечатать весь массив целых чисел
                if (arr[i] % 2 == 0)
                    even++;
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            //	2. Найти индекс максимального значения в массиве(воспользоваться функцией)
            Console.WriteLine("Максимальное значение массива {0} ", arr.Max());
            //	3. Найти индекс максимального четного значения в массиве
            int[] tmp = new int[even];
            int k = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                    tmp[k++] = arr[j];
            }
            Console.WriteLine("Максимальное четное значение массива {0} ", tmp.Max());
            //	4. Удалить элемент из массива по индексу.
            int[] arr2 = new int[arr.Length - 1];
            int removedIndex = 2;
            int g = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != removedIndex)
                    arr2[g++] = arr[i];
            }

            Console.Write("Удален элемент массива с индексом 2 ");
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.WriteLine();
            //	5.  Удаление элементов из массива по значению
            Console.WriteLine("Введите значение, которое хотите удалить");
            int removedValue = Int32.Parse(Console.ReadLine());
            int countToBeRemoved = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == removedValue)
                    countToBeRemoved++;
            }
            int[] arr3 = new int[arr2.Length - countToBeRemoved];
            if (countToBeRemoved != 0)
            {
               
                int s = 0;
                for (int f = 0; f < arr2.Length; f++)
                {
                    if (arr2[f] != removedValue)
                        arr3[s++] = arr2[f];
                }

                Console.WriteLine("Удален-ы элемент-ы массива со значением {0}", removedValue);


                for (int r = 0; r < arr3.Length; r++)
                {
                    Console.Write("{0} ", arr3[r]);
                }
                Console.WriteLine();
            }
            else if (countToBeRemoved == 0)
                Console.WriteLine("В массиве нет элемента со значением {0}", removedValue);

            //	6.  Вставить элемент в массив по индексу

            Console.WriteLine("Введите значение, которое хотите вставить");
            int newValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите индекс");
            int newIndex = Int32.Parse(Console.ReadLine());
            if (newIndex > arr2.Length)
                Console.WriteLine("Введенный индекс вне исходного массива ");
            else if (newIndex < arr2.Length + 1&& newIndex>0)
            {
                int[] arr4 = new int[arr2.Length + 1];
                for (int i = 0; i < newIndex; i++)
                {
                    arr4[i] = arr2[i];
                }


                arr4[newIndex] = newValue;
                for (int j = newIndex; j < arr2.Length; j++)
                {
                    arr4[++newIndex] = arr2[j];
                }

                for (int r = 0; r < arr4.Length; r++)
                {
                    Console.Write("{0} ", arr4[r]);
                }
            }
        }

        static void notA()
        {
            //7.  Удалить из строки слова, в которых есть буква 'a'

            Console.WriteLine("Введите строку из слов:");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string result = "";
        

            for (int i = 0; i < words.Length; i++)
            {
                if (!(words[i].Contains('a')))
                    result += words[i]+ " ";                    
                
            }
            Console.WriteLine(result);        

        }

        static void lastLetter()
        {
            //8.  Удалить из строки слова, в которых есть хоть одна буква последнего слова
            Console.WriteLine("Введите строку из слов:");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string result = words[0];
            char last = words[0][words[0].Length - 1];
            for (int i = 0; i < words.Length; i++)
            {
                if (!(words[i].Contains(last)))
                    result += " "+words[i];
                last = words[i][words[i].Length - 1];           
            }
            Console.WriteLine(result);

        }
        

        static void oneLetter()
        {
            //9.  В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками
            Console.WriteLine("Введите строку из слов:");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            string result = "";
           
            for (int i = 0; i < words.Length; i++)
            {
                char first = words[i][0];
                char last = words[i][words[i].Length - 1];
                if (first == last)
                    result += "["+words[i] + "] ";
                else if (first!=last)
                    result += words[i] + " ";
            }
            Console.WriteLine(result);

        }
        // 10. Дана строка символов, состоящая из цифр от 0 до 9 и пробелов.Группы цифр, разделенные пробелами 
        //(одним или несколькими) и не содержащие пробелов внутри себя,  будем называть словами.
        //Рассматривая эти слова как числа,
        //определить и напечатать сумму чисел, оканчивающихся на цифры 3 или 4.
        static void sumNumbers()
        {
            string str = "567 3457 23 34 789 53";

            string[] words = str.Split(' ');
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                char last = words[i][words[i].Length - 1];
                if (last=='3' || last== '4')            
                    sum += Int32.Parse(words[i]);   
                                   
            }
            Console.WriteLine("{0}", str);
            Console.WriteLine("{0}", sum);
        }

    }
}
