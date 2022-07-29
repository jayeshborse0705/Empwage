using Empwage;

namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a particular problem:");
            Console.WriteLine("1 for checking Employee present or absent");

            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    EmpPresentOrNot empPresentAbsent = new EmpPresentOrNot();
                    empPresentAbsent.CheckEmpPresentAbsent();
                    break;
                case 2:
                    DailyWage dailyEmpWage = new DailyWage();
                    dailyEmpWage.DailyWage();
                    break;
            }
        }
    }
 }
