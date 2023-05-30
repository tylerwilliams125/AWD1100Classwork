Console.WriteLine("Enter your GPA");


for (int i = 0; i < 10; i++)
{
    decimal gpa = Convert.ToDecimal(Console.ReadLine());
    if (gpa > 3.2m && gpa <= 4.0m)
    {
        Console.WriteLine("Your Grade is : A");
    }
    if (gpa > 2.5m && gpa <= 3.2m)
    {
        Console.WriteLine("Your Grade is : B");
    }
    if (gpa > 1.5m && gpa <= 2.5m)
    {
        Console.WriteLine("Your Grade is : C");
    }
    if (gpa > 0.0m && gpa <= 1.0m)
    {
        Console.WriteLine("Your Grade is : D"); ;
    }
    if (gpa == 0.0m)
    {
        Console.WriteLine("Your Grade is : F"); ;
    }

    if (gpa < 0 || gpa > 4.0m)
    {
        Console.WriteLine("GPA OUT OF RANGE ( GPA > 0 OR GPA < 4)");
    }
}