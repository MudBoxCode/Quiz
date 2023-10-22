using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            List<Question> questions = new List<Question>();

            questions.Add(new Year("In what year was the first Star Wars movie released?", "5", 1977));
            questions.Add(new Year("In what year was the first Star Trek movie released?", "5", 1979));
            questions.Add(new Year("In what year was the first Alien movie released?", "5", 1979));

            foreach (Question question in questions)
            {
                Console.WriteLine(question.QuestionText);
                string answer = Console.ReadLine();
                if (question.IsCorrect(answer))
                {
                    score += int.Parse(question.Points);
                }
            }
        }
    }
}
