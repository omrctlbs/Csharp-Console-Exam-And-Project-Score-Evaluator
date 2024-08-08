// A program to calculate the average score of a student based on two written exams and one project/assignment score, and determine the corresponding grade.
Console.WriteLine("Enter your first written exam score: ");
int exam1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second written exam score: ");
int exam2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your project/assignment score: ");
int proje = Convert.ToInt32(Console.ReadLine());

double average = (exam1 + exam2 + proje) / 3.00;
Console.Clear();
if (average >= 0 && average <= 44)
{
    Console.WriteLine("Your average score: " + average + ". Result: FAILED (1)");
}
else if (average > 44 && average <= 54)
{
    Console.WriteLine("Your average score: " + average + ". Result: PASS (2)");
}
else if (average > 55 && average <= 69)
{
    Console.WriteLine("Your average score: " + average + ". Result: AVERAGE (3)");
}
else if (average > 70 && average <= 84)
{
    Console.WriteLine("Your average score: " + average + ". Result: GOOD (4)");
}
else if (average > 85 && average <= 100)
{
    Console.WriteLine("Your average score: " + average + ". Result: EXCELLENT (5)");
}
else
{
    Console.WriteLine("Please enter a valid value...");
}
