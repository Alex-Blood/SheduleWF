namespace SheduleWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FillDb();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        static void FillDb()
        {
            using ApplicationContext db = new ApplicationContext();
            Weekday Monday = new Weekday
            {
                Lesson1 = "���������",
                Lesson2 = "������ ������",
                Lesson3 = "ͳ�. ����",
                Lesson4 = "ͳ�. ����",
                Lesson5 = "Գ����",
                Lesson6 = "������/��",
                Lesson7 = "����. ����",
                Lesson8 = "�������㳿",
                Id = 1
            };
            Weekday Tuesday = new Weekday
            {
                Lesson1 = "��",
                Lesson2 = "���. ��.",
                Lesson3 = "�����.",
                Lesson4 = "�����.",
                Lesson5 = "������",
                Lesson6 = "Գ����",
                Lesson7 = "Գ�-��",
                Lesson8 = "-",
                Id = 2
            };
            Weekday Wednesday = new Weekday
            {
                Lesson1 = "�������",
                Lesson2 = "�������",
                Lesson3 = "�����.",
                Lesson4 = "������.",
                Lesson5 = "������.",
                Lesson6 = "����. ����",
                Lesson7 = "����. ����",
                Lesson8 = "Գ�-��",
                Id = 3
            };
            Weekday Thursday = new Weekday
            {
                Lesson1 = "������",
                Lesson2 = "ճ��",
                Lesson3 = "�����. ������",
                Lesson4 = "���. ����",
                Lesson5 = "���. ����",
                Lesson6 = "ճ��",
                Lesson7 = "����. ��.",
                Lesson8 = "-",
                Id = 4
            };
            Weekday Friday = new Weekday
            {
                Lesson1 = "���. ��.",
                Lesson2 = "���. ��.",
                Lesson3 = "����. ����",
                Lesson4 = "����. ����",
                Lesson5 = "Գ����",
                Lesson6 = "�������������",
                Lesson7 = "Գ����",
                Lesson8 = "-",
                Id = 5
            };
            Lesson Lesson1 = new Lesson {TimeStart = TimeOnly.ParseExact("8:30","t"),
            TimeFin = TimeOnly.ParseExact("9:15","t"), Id =1};
            Lesson Lesson2 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("9:25", "t"),
                TimeFin = TimeOnly.ParseExact("10:10", "t"),
                Id =2
            };
            Lesson Lesson3 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("10:25", "t"),
                TimeFin = TimeOnly.ParseExact("11:10", "t"),
                Id=3
            };
            Lesson Lesson4 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("11:25", "t"),
                TimeFin = TimeOnly.ParseExact("12:10", "t"),
                Id=4
            };
            Lesson Lesson5 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("12:15", "t"),
                TimeFin = TimeOnly.ParseExact("13:00", "t"), Id=5
            };
            Lesson Lesson6 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("13:05", "t"),
                TimeFin = TimeOnly.ParseExact("13:50", "t"), Id=6
            };
            Lesson Lesson7 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("13:55", "t"),
                TimeFin = TimeOnly.ParseExact("14:40", "t"), Id = 7
            };
            Lesson Lesson8 = new Lesson
            {
                TimeStart = TimeOnly.ParseExact("14:45", "t"),
                TimeFin = TimeOnly.ParseExact("15:30", "t"), Id= 8
            };
            db.Weekdays.AddRange(Monday, Tuesday, Wednesday, Thursday, Friday);
            db.Lessons.AddRange(Lesson1, Lesson2, Lesson3, Lesson4, Lesson5, Lesson6, Lesson7, Lesson8);
            db.SaveChanges();
            
        }
    }
}