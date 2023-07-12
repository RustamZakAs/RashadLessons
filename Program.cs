using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace RashadLessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\b ");
            int? dasda; //null

            dasda = 0;
            dasda = dasda + 1;

            List<int> datas = new List<int> { 1, 2, 3, 4 };

            if (datas.Where(z => z > 3) != null) datas.Where(x => x > 3);
            int? values = datas.Where(x => x > 3)?.FirstOrDefault();
            //https://metanit.com/sharp/tutorial/2.1.php

            //Ссылочные типы данных
            string _string = string.Empty;
            string _String = "";
            _string = "";
            _String = string.Empty;

            //Аналогичные действия с использованием разного написания
            _string = _string + ""; //Бинарная операция
            _string += ""; //Унарная операция
            //https://metanit.com/sharp/tutorial/2.16.php


            //SecureString
            SecureString secured = new SecureString();
            string asd = "password";
            for (int i = 0; i < asd.Length; i++)
                secured.AppendChar(asd[i]);

            secured.ToString();
            //https://learn.microsoft.com/ru-ru/dotnet/api/system.security.securestring?view=net-8.0


            //StringBuilder
            StringBuilder builder = new StringBuilder(10001);

            string text = builder.ToString();
            //https://learn.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-7.0

            System.GC.Collect(); //Заставляет очистить память //Принудительно начинает сборку мусора


            int peramenntaya = 0;
            peramenntaya--;
            Console.WriteLine(peramenntaya);
            Console.WriteLine(peramenntaya++);
            Console.WriteLine(peramenntaya--);
            Console.WriteLine(peramenntaya);
            peramenntaya = 0;
            Console.WriteLine(++peramenntaya);
            Console.WriteLine(--peramenntaya);


            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            int asddasdas = intArray.Length / 2;
            int[] snacala = new int[intArray.Length / 2];
            for (int i = 0; i < intArray.Length / 2; i++)
            {
                snacala[i] = intArray[i];
                Console.WriteLine($"{snacala[i]}-{intArray[i]}");
            }

            int[] skonca = new int[intArray.Length / 2];
            for (int i = intArray.Length - 1, j = 0; i > intArray.Length / 2; i--, j++)
            {
                skonca[j] = intArray[i];
                Console.WriteLine($"{j}-{skonca[j]}/{i}-{intArray[i]}");
            }

            int[] skonca3 = new int[intArray.Length / 2];
            for (int i = intArray.Length - 1, j = skonca3.Length - 1; i > intArray.Length / 2; i--, j--)
            {
                skonca3[j] = intArray[i];
                Console.WriteLine($"{j}-{skonca3[j]}/{i}-{intArray[i]}");
            }

            int[] skonca2 = new int[intArray.Length / 2];
            for (int i = intArray.Length - 1; i > intArray.Length / 2; i--)
            {
                skonca2[i - skonca2.Length - 1] = intArray[i];
                Console.WriteLine($"{i - skonca2.Length - 1}-{skonca2[i - skonca2.Length - 1]}/{i}-{intArray[i]}");
            }
            foreach (var item in skonca2)
            {
                Console.Write($"{item},");
            }

            int a = 2;
            int b = 2;
            int c = 2;

            double valuess = 10.0 / 4.0;
            valuess = valuess - (int)valuess;

            int d = (c--) - (b * a) * (c + 1);
            Console.WriteLine(d);

            int shotcik = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                int _a = 1;
                int _b = 1;
                if ((_a == 1 || _b == 2) && /*and - və*/(_a == 1 || _b == 2)) //(or - və ya)
                {

                }    
                    
                shotcik = shotcik + 2;
                shotcik += 2;
                shotcik = ++shotcik;
                //Operations
                if (intArray.Length % 50 == 0)
                {
                }
            }


        }

        public int one { get; set; }
        private int two { get; set; }
        internal int three { get; set; }

        public static int four { get; set; }
        private static int five { get; set; }
        internal static int six { get; set; }

        public virtual int seven { get; set; }
        internal virtual int eight { get; set; }

        private protected int ten { get; set; }
        protected internal int eleven { get; set; }

        //https://metanit.com/sharp/tutorial/3.2.php
    }
}