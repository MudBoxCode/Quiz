using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Question> questions = new List<Question>();
            int score = 0;
            string userAnswer;
            questions.Add(new Year("In what year was the first Star Wars movie released?", 5, 1977));
            questions.Add(new Year("In what year was the first Star Trek movie released?", 5, 1979));
            questions.Add(new Year("In what year was the first Alien movie released?", 5, 1979));

            foreach (Question question in questions)
            {
                Console.WriteLine(question);
                userAnswer = Console.ReadLine();    

                if (question.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct!");
                    score += question.Points;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }

            }

            Console.WriteLine($"Your score is {score}."); 

        }
    }
}
