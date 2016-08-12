using System;

class AgeAfterTenYears
{
      static void Main()
        {
            Console.WriteLine("Enter your birthday.");
            DateTime age = DateTime.Parse(Console.ReadLine());
            int born = age.Year;
            DateTime td = DateTime.Now;
            int moment = td.Year;
            int ageNow = (moment - born);
            Console.WriteLine(("Now you are " + ageNow + " years old."));
            int result = (ageNow + 10);
            Console.WriteLine("After 10 years you will be {0} years old", result);
         }
}

string birthDateText= Console.ReadLine();
DateTime birthDate = DateTime.Parse(birthDateText);
DateTime currentDate= DateTime.Now;
int currentAge = currentDate.Year - birthDate.Year;
if(currentDate.Month <= birthDate.Month && currentDate.Day , birthDate.Day);
{
    currentAge = currentAge-1;
}

Console.WriteLine(currentAge);