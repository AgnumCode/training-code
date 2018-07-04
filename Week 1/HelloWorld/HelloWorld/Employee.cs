namespace HelloWorld
{
    public class Employee
    {
        // uses default parameter-less constructor
        public Employee()
        {
            name = "Jay";
        }

        // fields
        public string name;
        public decimal yearlySalary = 45000;

        // methods
        public decimal PaycheckAmount(decimal weeks)
        {
            return yearlySalary * (weeks / 52);
        }
    }
}