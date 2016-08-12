using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class After10Years
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            string birthDateText = Console.ReadLine();

            DateTime birthDate = DateTime.Parse(birthDateText);

            DateTime currentDate = DateTime.Now;

            int currentAge = currentDate.Year - birthDate.Year;

        }
    }