using System;
using System.Linq;
using System.Text;


namespace OOTP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Типы
            bool flag = true;            // 1
            byte smth = 1;               // 1 (0 to 255)
            char letter = 'f';           // 2
            decimal AintMyMoney = 12.2E5m;// 16
            double ddd = 123.5;          // 8
            float fff = 57.4f;           // 4
            int ii = 111;                // 4
            uint ui = 155;               // 4
            long ll = 222;               // 8
            ulong ul = 444;              // 8
            short si = 44;               // 2
            ushort us = 88;              // 2

            Console.WriteLine("flag = {0}, smth = {1}, letter = {2}", flag, smth, letter);
            Console.WriteLine("AintMyMoney = {0}, ddd = {1}, fff = {2}", AintMyMoney, ddd, fff);
            Console.WriteLine("ii = {0}, ll = {1}, ui = {2}, ll = {3}, ul = {4}, si = {5}, us = {6}", ii, ll, ui, ll, ul, si, us);

            short spreobr = 3;
            int ipreobr = 6;
            float fpreobr = 123.7f;
            double dpreobr = 12.62;

            long lnpreobr = ipreobr; // неявное
            int innpreobr1 = spreobr;
            decimal decnpreobr = ipreobr;
            double dnpreobr0 = fpreobr;
            double dnpreobr1 = ipreobr;

            int inyavpreobr0 = (int)fpreobr;    //явное
            int inyavpreobr1 = (int)dpreobr;
            double dyavpreobr = (double)spreobr;
            decimal decyavpreobr0 = (decimal)dpreobr;
            decimal decyavpreobr1 = (decimal)fpreobr;

            int inconvert = Convert.ToInt32(spreobr);   //использование Convert

            int iboxing = 6;            
            Object objforboxing = iboxing;   //упаковка

            int intforunboxing = (int)objforboxing; // распаковка

            var nyavtype = 44.4;            //неяно типизированная переменная
            Console.WriteLine(nyavtype);
            Console.WriteLine(nyavtype.GetType());

            int? x1 = 666;// == Nullable<T> XXX
            Nullable<int> x2 = 666;
            Console.WriteLine("x1 = {0}, x2 = {1}",x1, x2);

            //var v1, v2 = 2;
            //ключевое слово 'var' может применяться тольков объявлении локальной переменной
            //неявно типизированные локальные переменные не допускают множественного объявления


            //2)Строки
            string t = "hello";
            string p = "world";
            int result = String.Compare(t, p);

            if (result < 0)
            {
                Console.WriteLine("Строка t перед стракой p в алфавите");
            }

            else if (result > 0)
            {
                Console.WriteLine("Строка t после строки p в алфавите");
            }

            else
            {
                Console.WriteLine("Строки t и p идентичны");
            }


            string str1 = "I wonna those";
            string str2 = " day";
            string str3;
            string str4 = "when y don't wonna wake up";

            Console.WriteLine(str1 + str2);
            str3 = str2;
            Console.WriteLine(str3);
            String substr = str1.Substring(2, 5);
            Console.WriteLine(substr);
            String[] words = str1.Split(' ');
            Console.WriteLine(words[0]);
            String str4insert = "Everything ";
            String modifiedstr = str4insert.Insert(11, "is Fed");
            Console.WriteLine(modifiedstr);
            String LimpBizkit = "Everyone is scks";
            String BreakStuff = LimpBizkit.Remove(12);
            Console.WriteLine(BreakStuff);

            
            //2c
            String str5 = "";
            String str6 = null;
            if (String.IsNullOrEmpty(str5))
            {
                Console.WriteLine("Строка str5 пуста или NULL");
            }
            else
            {
                Console.WriteLine("не NULL");
            }
            
            if (String.IsNullOrEmpty(str6))
            {
                Console.WriteLine("Строка str6 пуста или NULL");
            }
            else 
                Console.WriteLine("не NULL");
            
            
            //2d
            StringBuilder sb = new StringBuilder(" Qприду к твоему дому");
            sb.Remove(1, 1);
            sb.Insert(0, "И я");
            sb.Append("сидя верхом на коне, в окружении крестьян с вилами....");
            Console.WriteLine(sb);
            
            //3Massive

            int[,] arr = new int[3, 3] {{1, 0, 0}, {0, 1, 0}, {0, 0, 1}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(arr[i, j] + " "); 
                Console.WriteLine();
            }

            string[] str_arr = new string[3] {"asdasd", "zxcvb", "qwerty"};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(str_arr[i]);
            }
            Console.WriteLine("Длинна массива строк = " + str_arr.Length);

            Console.WriteLine("Введите строку для замены");
            string temp = Console.ReadLine();
            Console.WriteLine("Введите номер массива, на который будет заменена строка");
            string numb = Console.ReadLine();
            int innumb = Convert.ToInt32(numb);
            str_arr[innumb] = temp;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(str_arr[i]);
            }
            
            //ступенчатый массив
            int[][] arrSt = new int[3][];
            arrSt[0] = new int[2];
            arrSt[1] = new int[3];
            arrSt[2] = new int[4];
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите число");
                numb = Console.ReadLine();
                innumb = Convert.ToInt32(numb);
                arrSt[0][i] = innumb;
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число");
                numb = Console.ReadLine();
                innumb = Convert.ToInt32(numb);
                arrSt[1][i] = innumb;
            }
            Console.WriteLine();
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите число");
                numb = Console.ReadLine();
                innumb = Convert.ToInt32(numb);
                arrSt[2][i] = innumb;
            }
            Console.WriteLine();
            
            //неявно типизированные переменные для хранения
            var nyavArr = new int[] {1, 2, 3, 4, 5};
            var nyavStr = "\nMalina";
            for (int i = 0; i < 5; i++)
                Console.WriteLine(nyavArr[i]);
            Console.WriteLine(nyavStr);
            
            //4) Кортежи
            (int, string, char, string, ulong) gonnasleep = (23, "Ночи", 'я', "сонный", 53);
            Console.WriteLine(gonnasleep);
            Console.WriteLine(gonnasleep.Item1 + " " + gonnasleep.Item3 + " " + gonnasleep.Item4);
            
            (var a, var b) = ("123", 456);
            Console.WriteLine($"{a} {b}" +  "\n\t___________________\n" );

            var kort1 = (a: 10, b: 3);
            var kort2 = (a: 10, b: 3);
            if(kort1 == kort2)
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");
            
            //5)Создайте лок. функцию main и вызовите её

            void funcFor5(int[] a, string b)
            {
                int max = a.Max();
                int min = a.Min();
                int sumElem = a.Sum();
                char FirstCh = b[0];

                var kortfunc = (max, min, sumElem, FirstCh);
                Console.WriteLine(kortfunc);
            }

            int[] intForFunc = new int[3] {2, 3, 5};
            string strForFunc = "Jazz";
            funcFor5(intForFunc,strForFunc);
            
            //6)Работа с Checked/unchecked
            void checkedTask()
            {
                checked
                {
                    int maxElem = int.MaxValue;
                    Console.WriteLine(maxElem);
                }   
            }
            void uncheckedTask()
            {
                unchecked
                {
                    int maxElem = int.MaxValue;
                    Console.WriteLine(maxElem);
                }
            }
            
            checkedTask();
            uncheckedTask();
        }
    }
}
