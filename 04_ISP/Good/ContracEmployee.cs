namespace SOLID._04_ISP.Good
{
    public class ContracEmployee : ISalaryCalculator
    {
        public string Name { get; set; }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }
    }
}
