
abstract class Question
{
    public string QuestionText { get; set; }
    public int Points { get; set; }

    public Question(string questionText, int points)
    {
        QuestionText = questionText;
        Points = points;
    }

    public override string ToString()
    {
        return $"Points: {Points}. Question: {QuestionText}";
    }

    public virtual bool CheckAnswer(string answer)
    {
        return true;
    }
}

class Year : Question
{
    public int CorrectAnswer { get; set; }


    public Year(string questionText, int points, int correctAnswer) : base(questionText, points)
    {
        CorrectAnswer = correctAnswer;
    }

    public override bool CheckAnswer(string answer)
    {
        int answerInt = int.Parse(answer);
        return answerInt == CorrectAnswer;
    }
}