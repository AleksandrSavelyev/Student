using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        private string name;
        private string lastName ;
        private int kurs;
        private int zachet;
        private int n;
        //public static int index=0;
        public Student[] data;
        public Student() { }
        public Student(int n)
        {
            data = new Student[n];
        }
        public Student(string name,string lastName,int kurs,int zachet,int n)
        {
            data = new Student[n];
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public int Zachet
        {
            get { return zachet; }
            set { zachet = value; }
        }
        public Student this[int index ]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
       /* public static void InnIndex()
        {
            index += 1;
        }*/
        public virtual void PrintInfo()
        {
            Console.WriteLine($"имя фамилия:{name} {lastName} курс: {kurs} номер зачетной книжки: {zachet}");
        }
    }
    class Aspirant:Student
    {
        private string diss;        
        private Aspirant[] dataAsp;
        public Aspirant() { }
        public Aspirant(int n) 
        {
            dataAsp = new Aspirant[n];
        }
        public Aspirant(string name,string lastName,int kurs,int zachet,string diss,int n)
            :base(name,lastName,kurs,zachet,n)
        {
            dataAsp = new Aspirant[n];
        }
        public string Diss
        {
            get { return diss; }
            set { diss=value;}
        }
        public new Aspirant this[int index]
        {
            get
            {
                return dataAsp[index];
            }
            set
            {
                dataAsp[index] = value;
            }
        }
        public new void PrintInfo()
        {
            Console.WriteLine($"имя фамилия студента: {Name} {LastName} номер зачетной книги: {Zachet} работает над дисертацией: {diss}");
        }
    }
}
