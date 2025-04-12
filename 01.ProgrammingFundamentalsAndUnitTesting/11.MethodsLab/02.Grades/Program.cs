double grade = double.Parse(Console.ReadLine());

Grades(grade);

static void Grades(double grade)
{
    string resultOfGrade = "";
    switch (grade)
    {
        case >= 2.00 and < 3:
            resultOfGrade = "Fail";
            break; 
        case >= 3.00 and < 3.50:
            resultOfGrade = "Average";
            break; 
        case >= 3.50 and < 4.50:
            resultOfGrade = "Good";
            break; 
        case >= 4.50and < 5.50:
            resultOfGrade = "Very good";
            break;
        case >= 5.50 and <= 6.00:
            resultOfGrade = "Excellent";
            break;

    }
    Console.WriteLine(resultOfGrade);
}