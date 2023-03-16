using System;
using System.Security.Cryptography.X509Certificates;


class Thrivetech
{
    static void Main(string[] args)
    {
        Mulumba();
    }

    public static void Mulumba()
    {


        Console.WriteLine("Please enter the number of scripts to be marked");
        int scripts = Convert.ToInt32(Console.ReadLine());
        if (scripts == 0)
        {
            Console.WriteLine("Scripts must be greate than 0");
        }


        Console.WriteLine("Please enter the number of questions in the test");
        int ques = Convert.ToInt32(Console.ReadLine());
        if (ques < 1 && ques > 10)
        {
            Console.WriteLine("Questions must be not greater than 10 and less than 1");

        }



        Console.WriteLine("Please enter the subtotal of each question");
        int sub = Convert.ToInt32(Console.ReadLine());

        while (sub < ques)
        {
            Console.WriteLine("Please enter the subtotal of each question");
            int sub1 = Convert.ToInt32(Console.ReadLine());


            if (sub1 == 0)
            {
                Console.WriteLine("The subtotal must be greater than 0");
            }

            Console.WriteLine("Please enter the number of lecturers that are going to mark the question");
            int lec = Convert.ToInt32(Console.ReadLine());
            if (lec == 0)
            {
                Console.WriteLine("The number of lecturers must be greater than 0");
            }
            else
            {
                int lecscripts = scripts / lec;
                Console.WriteLine("Each lecturer will mark this number of scripts:" + " " + lecscripts);
                int time = ques / 2;
                int min = time * 60;
                int hours = min / 60;
                if (min > 60)
                {
                    int hours1 = hours + 1;
                    int min1 = min - 60;


                    Console.WriteLine("It will take a lecturer" + " " + hours1 + " " + "hours and" + " " + min1 + " " + "minutes to finish");
                }
                else
                    Console.WriteLine("It will take a lecturer" + " " + hours + " " + "hours and" + " " + min + " " + "minutes to finish");
            }



        }






    }
}
