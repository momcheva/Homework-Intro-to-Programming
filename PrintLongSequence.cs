using System;

class PrintLongSequence
{
   static void Main()
  
    {
        for (int i = 2; i <= 1001; i++) /* i++ index = index + 1*/
        {
            if (i % 2 != 0) /* % деление, !=0 различно от нула */
            {
                Console.Write(-i + ",");
            }
            else
            {
                Console.Write(i + ",");
            }
        }
       
    }
}

