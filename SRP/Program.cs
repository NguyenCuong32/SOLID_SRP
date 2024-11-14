using SRP;
internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        var salary = employee.CalculateSalary();
        System.Console.WriteLine($"Your salary {salary}");
        EmployeeRepository employeeRepository = new EmployeeRepository();
        employeeRepository.SaveInformation(employee);
    }
}