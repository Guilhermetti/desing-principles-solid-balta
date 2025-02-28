namespace SOLID._04_ISP.Good
{
    public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
    {
        public string Name { get; set; }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }

        public void CalculateBenefits()
        {
            Console.WriteLine("Contract benefits");
        }
    }
}
