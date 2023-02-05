using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //задание 8
           /* string s = "Лишняя бууква";
            Console.WriteLine(s);
            Console.WriteLine("Введите кол-во символов, которые хотите удалить");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позиицию символа, который хотите удалить");
            int num1 = Convert.ToInt32(Console.ReadLine());
            s = s.Remove(num1, num);
            Console.WriteLine(s);

            Console.WriteLine("-----------------------------------");
            //задание 9


            string str1 = "Hello world!";
            Console.WriteLine(str1);
            Console.WriteLine("Введите символ который будет удален в строке");
            string sym = Console.ReadLine();
            str1 = str1.Replace("l", "");
            Console.WriteLine(str1);


            Console.WriteLine("-----------------------------------");


            //задание 10
            string s2 = "Hello worl!";
            Console.WriteLine(s2);
            Console.WriteLine("Введите символ, который хотите добавить");
            string a = Console.ReadLine();
            Console.WriteLine("Введите позиицию, в которую хотите добавить");
            int b = Convert.ToInt32(Console.ReadLine());
            s2 = s2.Insert(b, a);
            Console.WriteLine(s2);
            Console.WriteLine("-----------------------------------");*/



            //задание 11

            Console.WriteLine("Введите строку");
            string polindrom = Console.ReadLine();
            for (int i = 0; i < polindrom.Length; i++)
            {
                if (polindrom[i] != polindrom[polindrom.Length - 1 - i])  //если элементы в массиве не равны элементам массива с конца
                {
                    Console.WriteLine("Not polindrom");     //то это не полиндром
                }
                else
                    Console.WriteLine("Polindrom");  //иначе полиндром 
                break;
            }

            Console.WriteLine("-----------------------------------");
            //задание 12
            string words = "Hello world, Hello World!"; 
            Console.WriteLine(words);
            Console.WriteLine("Количество слов:" + words.Split().Count());  //делим на массивы и берем количество слов


            Console.WriteLine("-----------------------------------");
            //задание 13
            Console.WriteLine("Введите предложение: ");
            string str11 = Console.ReadLine();
            Console.WriteLine("Введите слово для поиска: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("Введите слово для замены: ");
            string str3 = Console.ReadLine();

            Console.WriteLine("Исходное предложение: ");
            Console.WriteLine(str11);

            str11 = str11.Replace(str2, str3);   //заменяем искомое слово на введённое 
            Console.WriteLine("Новое предложение: ");
            Console.WriteLine(str11);

            Console.WriteLine("-----------------------------------");


            //задание 14
            Console.WriteLine("Введите предложение: ");
            string[] strrr = Console.ReadLine().Split(' ');   //снова делим на массивы
            Array.Reverse(strrr);   //меняем местами 
            Console.WriteLine(String.Join(" ", strrr));  //и собираем обратно


            Console.WriteLine("-----------------------------------");
            //задание 15
            string VOWELS = "AaEeIiOoUuYyАаЕеЁёИиОоУуЫыЭэЮюЯя";
            while (true)
            {
                Console.WriteLine("Введите предложение на русском: ");
                string str33 = Console.ReadLine();
                if (str33 == "")
                {
                    break;
                }
                int count = 0;
                foreach (string word in str33.Split(null as char[], StringSplitOptions.RemoveEmptyEntries))
                {
                    if (VOWELS.IndexOf(word[word.Length - 1]) >= 0)
                    {
                        Console.WriteLine(word);
                        count += 1;
                    }
                }
                Console.Write(count + " слов(о) заканчивае(ю)тся на гласную букву.");
                break;
            }
        }
    }
    }

