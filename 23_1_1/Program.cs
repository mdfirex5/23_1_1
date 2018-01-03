using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class A
    {
        public string Name1;
        public string Name2;
        public string Name3;
        public string Name4;
        public string Name5;

        public ArrayList word = new ArrayList();

        public A(string s1, string s2, string s3, string s4, string s5)
        {
            Name1 = s1;
            Name2 = s2;
            Name3 = s3;
            Name4 = s4;
            Name5 = s5;

            word.Add(s1);
            word.Add(s2);
            word.Add(s3);
            word.Add(s4);
            word.Add(s5);
        }

        public void reWrite()
        {
            Console.WriteLine("Класс А: {0}", Name1);
            Console.WriteLine("Класс А: {0}", Name2);
            Console.WriteLine("Класс А: {0}", Name3);
            Console.WriteLine("Класс А: {0}", Name4);
            Console.WriteLine("Класс А: {0}\n", Name5);
        }
    }

    public class B
    {
        public string Name_B;
        public string Name_B2;
        public int B2 = -1;

        public int checkarray(ArrayList asd, string w)
        {
            int ccount = 0;
            foreach (object o in asd)
            {
                if (o.ToString().Length == w.Length)
                {
                    ccount++;
                    Console.WriteLine("{0}ое минимальное имя : {1}", ccount, o);
                }
            }

            return ccount;
        }

        public void FillArray(ArrayList list)
        {
            if (list == null)
            {
                list = new ArrayList(10);
            }
            list.Insert(0, "Bozhena");
            list.Insert(1, "Denis");
            list.Insert(2, "Nick");
            //list.Add("123");

            foreach (object o in list)
            {
                Name_B = Name_B + o;
            }

            foreach (object o in list)
            {
                Name_B2 = o.ToString();

                for (int i = 0; i < list.Count; i++)
                {
                    if (Name_B.Length > Name_B2.Length)
                    {
                        B2++; // id
                        Name_B = Name_B2; // string
                    }
                }

                Console.WriteLine("Класс Б: {0}", o);
            }

            Console.WriteLine();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            A ex = new A("Alexandr", "Mihail", "Ortem", "Dima", "Elizabeth");
            ex.reWrite();
            B obr = new B();
            obr.FillArray(ex.word);
            obr.checkarray(ex.word, obr.Name_B);
            Console.ReadLine();
        }
    }
}