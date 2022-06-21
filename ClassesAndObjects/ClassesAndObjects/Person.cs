// Primitive Datatypes
/*
 * int, string, char, bool, etc
 */
 
// Object Oriented Programming - Creating your own datatypes

/*
 * Class - Blueprint
 */
// Single Responsibility Principle
// Let each unit have 1 responsibility


public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    // Fields when private
    private double _salary { get; set; }
    
    // Method to set private salary
    public void setSalary(double salary)
    {
        _salary = salary;
    }
    // Method to get private salary
    public double getSalary() // Must be same data type as field
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}"; 
    }
}