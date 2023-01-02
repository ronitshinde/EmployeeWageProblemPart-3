namespace RefactorEmpWage
{
    public class EmployeCheck
    {
        public static void EmpAttendance()
        {
            int Is_Full_Time = 1;

            Random random = new Random();
            int empcheck = random.Next(2);
            Console.WriteLine(empcheck);

            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }

    }
}

