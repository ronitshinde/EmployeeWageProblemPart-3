namespace RefactorEmpWage
{
    public class Program
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hours_In_Month = 100;


        public static int computeEmpWage()
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours < Max_Hours_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {

                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);


                switch (empcheck)
                {
                    case Is_Full_Time:
                        empHours = 8;
                        break;

                    case Is_Part_Time:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;
                }

                totalEmpHours += empHours;
                int dailyWage = empHours * Emp_Rate_Per_Hour;

                Console.WriteLine("Day # " + totalWorkingDays + " Emp hours " + empHours + " * " + Emp_Rate_Per_Hour + " = " + dailyWage);
            }
            Console.WriteLine();

            Console.WriteLine("Total employee hours : " + totalEmpHours);


            int totalEmpWage = totalEmpHours * Emp_Rate_Per_Hour;

            Console.WriteLine("Total Employee Wage : " + totalEmpWage);

            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }

    }
}
