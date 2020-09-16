using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            Student first = new Student(n);
            int w = 0;
            Aspirant firstAsp = new Aspirant(n);
            int z = 0;

            for (; ; )
            {
                Console.WriteLine("нажмите 1 чтобы добавить Студента");
                Console.WriteLine("нажмите 2 чьобы добавить аспиранта");
                Console.WriteLine("нажмите 3 чтобы узнать информацию о студентах");
                Console.WriteLine("нажмите 4 чтобы узнать информацию о аспирантах ");
               
                string myMenyu = Console.ReadLine();                
                switch (myMenyu)
                {
                    case "1": first = AddStu(first, w);
                        w++;
                        break;
                    case "2":firstAsp = AddAsp(firstAsp, z);
                        z++;
                        break;                        
                    case "3":PrintInfoStu(first,w);
                        break;
                    case "4":PrintInfoAsp(firstAsp,z);
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
        public static Student AddStu(Student first, int i)
        {    
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
               
                Console.WriteLine("чтобы добавить ещё 1 студента нажмите 1:\t");
                Console.WriteLine("чтобы выйти в меню нажмите любую цифру:\t");
                int a = InNum();
                if (a == 1)
                {
                    AddStu(first, i+1);
                }
                else
                    break;
            }
            return first;
            
        }
        static Aspirant AddAsp(Aspirant firstAsp, int i)
        {
            Console.WriteLine(i);
            for (; ; )
            {
                firstAsp[i] = new Aspirant();
                Console.Write("введите имя аспиранта:\t");
                firstAsp[i].Name = InStr();
                Console.Write("введите фамилию аспирантиа:\t");
                firstAsp[i].LastName = InStr();
                Console.Write("введите курс обучения:\t");
                firstAsp[i].Kurs = InNum();
                Console.Write("введите номер зачетной книжки:\t");
                firstAsp[i].Zachet = InNum();
                Console.Write("введите название дисертации:\t");
                firstAsp[i].Diss = InStr();

                Console.WriteLine("нажмите 1 чтобы добавить ещё аспиранта");
                Console.WriteLine("Нажмите любую цифру чтобы выйти");
                int a = InNum();
                if (a == 1)
                    AddAsp(firstAsp, i + 1);
                else
                    break;                
            }
            return firstAsp;
        }
        static void PrintInfoStu(Student first,int stud)
        {
            Console.WriteLine($"всего зарегестрированно {stud} студентов");
            Console.Write("введите номер студента для вывода информации:\t");
            int a = InNum();
            first[a]?.PrintInfo();
        }
        static void PrintInfoAsp(Aspirant firstAsp,int asp)
        {
            Console.WriteLine($"всего зарегестрированно {asp} аспирантов");
            Console.Write("введите номер аспиранта для вывода информации");
            int a = InNum();
            firstAsp[a]?.PrintInfo();
        }
    }
}
