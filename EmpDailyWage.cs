namespace RefactorEmpWage
{
    public class EmpDailyWage
    {

        public static void EmpWage()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;

            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
                Emphours = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Emphours = 0;
            }
            Empwage = Emphours * Emp_Rate_Per_Hour;

            Console.WriteLine("Daily employee wage is : " + Empwage);


        }
    }
}