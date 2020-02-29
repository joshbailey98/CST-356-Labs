public static class BusinessRules
{
    public static bool isSpecial(Student student) =>
        student.EmailAddress.ToLower().StartsWith(specialKey);

    public static string specialKey = "j";
}