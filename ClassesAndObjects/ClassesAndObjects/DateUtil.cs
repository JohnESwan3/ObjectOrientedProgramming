// Static Class - Doesn't need instantiation

internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    
    // Overload
    public static int YearOfBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return DateTime.Now.Year - dateOfBirth.Year;
    }
}