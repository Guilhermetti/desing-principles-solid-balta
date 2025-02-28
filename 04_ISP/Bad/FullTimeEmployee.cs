namespace SOLID._04_ISP.Bad
{
    public class FullTimeEmployee : IEmployee
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
