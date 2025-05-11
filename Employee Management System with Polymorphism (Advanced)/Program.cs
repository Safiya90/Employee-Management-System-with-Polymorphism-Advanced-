namespace Employee_Management_System_with_Polymorphism__Advanced_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp= new Employee[2];
            emp[0] = new Manager("Muna", 2000);
            emp[1] = new Developer("Ali", 1000);
          

            HR hr = new HR();
            hr.Bonuses(emp);
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary >= 0 ? salary : 0;
        }

        public virtual double CalculateBonus()
        {
            return Salary * 0.10;
        }

    }
    class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) 
        { 
        }

        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
    }
    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.15;
        }
    }
    class HR
    {
        public void Bonuses(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].Name} has a bouns of : {employees[i].CalculateBonus()}");
               
            }
        }
    }
}
