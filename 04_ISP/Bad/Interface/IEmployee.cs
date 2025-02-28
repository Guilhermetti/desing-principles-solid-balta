namespace SOLID._04_ISP.Bad
{
    public interface IEmployee
    {
        public string Name { get; set; }
        void CalculateSalary();
        void CalculateBenefits();
    }
}
