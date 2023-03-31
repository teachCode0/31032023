using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Group
    {
        public int No { get; set; }
        private protected int Count { get; set; }

        //private int StudentCount { get; set; }

        protected int TableCount { get; set; }

        protected internal string Name { get; set; }

        //public string GetInfo()
        //{
        //    return $"{StudentCount}";
        //}
    }
}
