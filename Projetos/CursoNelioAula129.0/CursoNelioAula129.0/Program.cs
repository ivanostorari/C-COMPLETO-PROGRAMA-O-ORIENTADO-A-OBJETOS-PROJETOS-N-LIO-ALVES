
using System.Globalization;
using System.Threading.Channels;

namespace CursoNelioAula1290
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Nmme: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevael/Senior); ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1, i <= n, i++)
            {
                Console.WriteLine("Enter #{i} contract data");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valeu per hour");
                Double valeuPerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine));
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract):
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " +  monthAbdYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

