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

            byte _byte = 1;
            sbyte _sbyte = 127;
            _sbyte = sbyte.MinValue;
            _sbyte = sbyte.MinValue;

            //Анологичные переменные с использованием разного написания
            Int16 int16 = 2;
            short _int16 = 4;

            UInt16 uint16 = 2;
            ushort _uint16 = 4;

            Int32 int32 = 4;
            int _int32 = 8; // _int32 – это переменная, 8 – это литерал
            int32 = 5 + 2; // 5 + 2 – это выражение, 5 и 2 – это литералы
            //Литерал — это фиксированное значение, которое записывается непосредственно в исходном коде

            UInt32 uint32 = 4;
            uint _uint32 = 8;

            Int64 int64 = 8;
            long _int64 = 16;

            UInt64 uint64 = 8;
            ulong _uint64 = 16;

            uint _uint = 0U;
            long _long = 0L;
            ulong _ulong = 30UL;
            float _float = 0F;
            double _double = 0D;
            decimal _decimal = 0M;

            int? dasda; //null

            dasda = 0;
            dasda = dasda + 1;

            List<int> datas = new List<int> { 1, 2, 3, 4 };

            if (datas.Where(z => z > 3) != null) datas.Where(x => x > 3);
            int? values = datas.Where(x => x > 3)?.FirstOrDefault();

            char _char = ' ';
            //https://metanit.com/sharp/tutorial/2.1.php

            //Ссылочные типы данных
            string _string = String.Empty;
            String _String = "";
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
                                 //https://learn.microsoft.com/ru-ru/dotnet/api/system.gc.collect?view=net-7.0
                                 //https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals
                                 //https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/fundamentals#:~:text=%D0%94%D0%BB%D1%8F%20%D0%BE%D0%BF%D1%82%D0%B8%D0%BC%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D0%B8%20%D0%BF%D1%80%D0%BE%D0%B8%D0%B7%D0%B2%D0%BE%D0%B4%D0%B8%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8%20%D1%81%D0%B1%D0%BE%D1%80%D1%89%D0%B8%D0%BA%D0%B0%20%D0%BC%D1%83%D1%81%D0%BE%D1%80%D0%B0,%D0%BD%D0%BE%D0%B2%D1%8B%D0%B5%20%D0%BE%D0%B1%D1%8A%D0%B5%D0%BA%D1%82%D1%8B%20%D0%B2%20%D0%BF%D0%BE%D0%BA%D0%BE%D0%BB%D0%B5%D0%BD%D0%B8%D0%B8%200.
                                 //https://learn.microsoft.com/ru-ru/dotnet/standard/garbage-collection/large-object-heap


            //Ключевое слово using имеет два основных применения:
            //
            //Директива using создает псевдоним для пространства имен или импортирует типы, определенные в других пространствах имен.
            //Оператор using определяет область, в конце которой удаляется объект.

            //Область видимости (контекст) переменных и констант
            //https://metanit.com/sharp/tutorial/2.18.php


            int identicate;  // применение слова identicate в качестве идентификатора
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