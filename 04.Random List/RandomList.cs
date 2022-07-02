using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{

    public class RandomList : List<string>
    {
        private Random list;

        public RandomList()
        {
            list = new Random();
        }
        public string RandomString()
        {

            int index = list.Next(0, this.Count);
            string str = this[index];
            RemoveAt(index);
            return str;

        }
    }
}
