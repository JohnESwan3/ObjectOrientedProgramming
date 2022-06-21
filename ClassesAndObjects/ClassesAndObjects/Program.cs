// See https://aka.ms/new-console-template for more information

// Object Declaration
Person person = new();
string middleName = string.Empty;
Console.WriteLine("Enter First Name:");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name:");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Middle Name:");
middleName = Console.ReadLine();


Console.WriteLine("Enter Age:");
person.Age = Convert.ToInt32(Console.ReadLine());

// Get Salary from input and assign it to the Person class
Console.WriteLine("Enter Salary:");
double salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);

// Console.WriteLine($"First Name: {person.FirstName}");
// Console.WriteLine($"Last Name: {person.LastName}");
if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Name: " + person.getFullName());
}
else
{
    Console.WriteLine("Name: " + person.getFullName(middleName));
}
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"Salary: {person.getSalary()}");

Console.WriteLine();