/*
=============
🏆 Exercise 
=============

1. Create a base class "Employee" with the following protected properties:
    - Name (string)
    - Salary (double)
    - Position (string)

2. Implement a constructor in "Employee" that initializes its values.

3. Add a virtual method "CalculateBonus()" that returns a bonus of 5% of the salary.

4. Add a method "ShowInfo()" that displays the employee's details:
    - Name
    - Position
    - Salary
    - Calculated bonus

5. Create two derived classes from "Employee":
    - "TeamLeader": Its bonus is 10% of the salary.
    - "Developer": Its bonus is 7% of the salary.

6. Instantiate a list of employees with at least the following data:
    - Carlos (Team Leader, 5000)
    - Ana (Developer, 4000)
    - Laura (Team Leader, 6000)
    - Luis (Developer, 3500)

7. Iterate through the list of employees and display the information of each one using the "ShowInfo()" method.
*/

partial class Program
{
    static void ShowEmployeesInformation()
    {

        List<Employee> employees = [
            new TeamLeader("Carlos", 5000, "Team Leader"),
            new Developer("Ana", 4000, "Developer"),
            new TeamLeader("Laura", 6000, "Team Leader"),
            new Developer("Luis", 3500, "Developer")
        ];

        employees.ForEach(e => e.ShowInfo());

    }

    class Employee(string name, double salary, string position)
    {
        protected string Name { get; set; } = name;
        protected double Salary { get; set; } = salary;
        protected string Position { get; set; } = position;

        public virtual double CalculateBonus() => Salary * .05;

        public void ShowInfo() =>  WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary:C}, Calculated Bonus: {CalculateBonus():C}");
    }

    class TeamLeader(string name, double salary, string position) : Employee(name, salary, position)
    {
        public override double CalculateBonus() => Salary * 0.1;
    }
    class Developer(string name, double salary, string position) : Employee(name, salary, position)
    {
        public override double CalculateBonus() => Salary * 0.07;
    }
}
