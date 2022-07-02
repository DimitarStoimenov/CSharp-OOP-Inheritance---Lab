using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("23");
            list.Add("12");
            list.Add("44");
            list.Add("443");
            list.Add("21");

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            
        }
    }
}
