namespace SOLID._04_ISP.Bad
{
    public class ContracEmployee : IEmployee
    {
        public string Name { get; set; }

        public void CalculateSalary()
        {
            Console.WriteLine("Contract salary");
        }

        public void CalculateBenefits()
        {
            throw new NotImplementedException();
        }
    }
}
