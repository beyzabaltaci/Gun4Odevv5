using System;

namespace Gun4Odevv5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(1234, "Beyza Baltacı");
            students.Add(1263, "Belgin Kaya");
            students.Add(1458, "Derya Malçok");
            students.Add(1254, "Nurbanu Kara");

            students.ToList();
        }
    }
}
