using L9Homework.Interfaces;

namespace L9Homework.Classes;

public class Exam : IGradeCalculator
{
    public double MaxMarks { get; set; }
    public double MarksObtained { get; set; }

    public Exam(double maxMarks, double marksObtained)
    {
        MaxMarks = maxMarks;
        MarksObtained = marksObtained;
    }
    
    public double CalculateGrade()
    {
        double result = MarksObtained / MaxMarks * 100;
        return result;
    }
}