using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_01_lab_02_Cars_W
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Date date = new Date(1, 1, 2024);
            Console.WriteLine(date.ToString());

            date.Add(31);
            Console.WriteLine(date.ToString());

            date.Add(0, 29);
            Console.WriteLine(date.ToString());

            Date otherDate = new Date(1, 1, 1);
            date.Add(otherDate);
            Console.WriteLine(date.ToString());
        }
    }


    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day = 1, int month = 1, int year = 2022)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            Normalize();
        }

        public void Add(int days)
        {
            day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            months += months;
            day += days;
            Normalize();
        }

        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }


        private void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month++;
            }

            while (month > 12)
            {
                month -= 12;
                year++;
            }
        }

        public override string ToString()
        {
            return $"{year}-{month}-{day}";
        }
    }
}
