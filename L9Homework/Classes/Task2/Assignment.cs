using L9Homework.Interfaces;

namespace L9Homework.Classes.Task2;

public class Assignment : IGradeCalculator
{
    public double MaxScore { get; set; }
    public double ScoreAchieved { get; set; }

    public Assignment(double maxScore, double scoreAchieved)
    {
        MaxScore = maxScore;
        ScoreAchieved = scoreAchieved;
    }
    
    public double CalculateGrade()
    {
        double result = ScoreAchieved / MaxScore * 100;
        return result;
    }
}