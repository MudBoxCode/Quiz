
abstract class Question
{
    protected string QuestionText { get; set; }
    protected string Points { get; set; }

    public Question(string questionText, string points)
    {
        QuestionText = questionText;
        Points = points;
    }
}

class Year : Question
{
    protected int CorrectAnswer { get; set; }


    public Year(string questionText, string points, int correctAnswer) : base(questionText, points)
    {
        CorrectAnswer = correctAnswer;
    }
}