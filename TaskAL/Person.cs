using System;
using System.Collections.Generic;
using SQLite;

namespace TaskAL
{
    public class Person
    {
        public static List<string> personData = new List<string>();

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public  string Firstname { get; set; }
        public string Lastname { get; set; }
        public  string Age { get; set; }

        public Person()
        {
        }

        
    }
}
