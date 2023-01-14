using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheduleWF
{
    public class Weekday
    {
        public int Id { get; set; }
        public string Lesson1 { get; set; }
        public string Lesson2 { get; set; }
        public string Lesson3 { get; set; }
        public string Lesson4 { get; set; }
        public string Lesson5 { get; set; }
        public string Lesson6 { get; set; }
        public string Lesson7 { get; set; }
        public string Lesson8 { get; set; }
    }
    public class Lesson
    {
        public int Id { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeFin { get; set; }
    }
}
