﻿namespace RefactorEmpWage
{
    public class EmpPTime
    {
        public static void PartTime()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int Is_Part_Time = 2;
            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(3);

            if (empcheck == Is_Full_Time)
            {

                Emphours = 8;

            }
            else if (empcheck == Is_Part_Time)
            {

                Emphours = 4;

            }
            else
            {

                Emphours = 0;

            }
            Empwage = Emphours * Emp_Rate_Per_Hour;

            Console.WriteLine("Daily employee wage is : " + Empwage);

        }

    }
}
