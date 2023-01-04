namespace RefactorEmpWage
{
    public class FixCondition
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hours_In_Month = 100;


        public static void DaysHoursOfMonth()
        {

            int Empwage;
            int Emphours;
            int TotalEmpwage = 0;
            int TotalEmphours = 0;
            int Totalworkingdays = 0;

            while (TotalEmphours < Max_Hours_In_Month && Totalworkingdays < Num_Of_Working_Days)
            {

                Totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(3);


                switch (empcheck)
                {
                    case Is_Full_Time:
                        Emphours = 8;
                        break;

                    case Is_Part_Time:
                        Emphours = 4;
                        break;

                    default:
                        Emphours = 0;
                        break;
                }

                TotalEmphours += Emphours;

                Console.WriteLine("Day # " + Totalworkingdays + " Emp hours " + Emphours);

            }
            Console.WriteLine();

            Console.WriteLine("Total employee hours : " + TotalEmphours);

            TotalEmpwage = TotalEmphours * Emp_Rate_Per_Hour;

            Console.WriteLine("Tota Employee wage : " + TotalEmpwage);

        }

    }
}

