using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Student first = new Student(n);
            int w = 0;

            for (; ; )
            {
                Console.WriteLine("нажмите 1 чтобы добавить Студента");
                Console.WriteLine("нажмитье 2 для вывода информации об аспирантах");
                Console.WriteLine("нажмите 3 для вывода информации о студенте");
                Console.WriteLine("нажмите 4 для выхода");
               
                string myMenyu = Console.ReadLine();                
                switch (myMenyu)
                {
                    case "1": first = AddStu(first, n, w);
                        w++;
                        break;
                    case "2":
                        break;
                    case "3":PrintInfoStu(first);
                        break;
                    default:
                        break;
                }

                
            }
        }
        static bool CheckNum(string a)
        {            
                if (int.TryParse(a, out int b))
                    return true;
                else
                    return false;            
        }
        static bool CheckStr(string a)
        {            
                char[] ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };                
                for(int i=0;i<a.Length;i++)
                {
                    for(int j=0;j<ch.Length;j++)
                    {
                    if (a[i] == ch[j])
                        return false;
                    }
                }
            return true;
        }
        static int InNum()
        {
            for (; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckNum(a);
                if (b == true)
                {
                   int c = Convert.ToInt32(a);
                    return c;
                }
                else
                    Console.Write("не коректные данные повторите ввод:\t");
            }
        }
        static string InStr()
        {
            for(; ; )
            {
                string a = Console.ReadLine();
                bool b = CheckStr(a);
                if (b == true)
                    return a;
                else
                    Console.Write("не коректные данные повторите ввод:\t");
            }
        }
        static string InZachet()
        {
            for (; ; )
            {
                int a = InNum();
                if (a < 10000000 && a > 99999999)
                {
                    string b = Convert.ToString(a);
                    return b;
                }
                else
                    Console.Write("номер зачетной книжки дожен быть не меньше и не длиннее 8символов");
            }
        }        
        public static Student AddStu(Student first, int n, int i)
        {
            
            Console.WriteLine(i);
            for (; ; )
            {
                
                first[i] = new Student();
                Console.Write("введите имя студента:\t");
                first[i].Name = InStr();
                Console.Write("введите фамилию студента:\t");
                first[i].LastName = InStr();
                Console.Write("введите курс обучения:\t");
                first[i].Kurs = InNum();
                Console.Write("введите номер зачетной книжки:\t");
                first[i].Zachet = InNum();
               
                Console.Write("чтобы добавить ещё 1 студента нажмите 1:\t");
                Console.Write("чтобы выйти в меню нажмите любую цифру:\t");
                int a = InNum();
                if (a == 1)
                {
                    AddStu(first, n, i+1);
                }
                else
                    break;
            }
            return first;
            
        }
        static void AddAsp()
        {
            Aspirant firstAspirant = new Aspirant();
            Console.Write("введите имя аспиранта:\t");
            firstAspirant.Name = InStr();
            Console.Write("введите фамилию аспирантиа:\t");
            firstAspirant.LastName = InStr();
            Console.Write("введите курс обучения:\t");
            firstAspirant.Kurs = InNum();
            Console.Write("введите номер зачетной книжки:\t");
            firstAspirant.Zachet = InNum();
            Console.Write("введите название дисертации:\t");
            firstAspirant.Diss = InStr();
            firstAspirant[Aspirant.indexAsp] = new Aspirant();
        }
        static void PrintInfoStu(Student first)
        {
            Console.Write("введите номер студента для вывода информации:\t");
            int a = InNum();
            first[a].PrintInfo();
        }
    }
}
