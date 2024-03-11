using System;

class ReflectionActivity : Activity
{
    private string[] reflectionPrompts = {
        "Who is your role model and why?.",
        "Think of a time when you felt hope.",
        "Where do you see yourself in five years?",
        "Think of an event that shaped who you are.",
        "Think of a time when a small choice changed your life."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();

        Random random = new Random();

        for (int i = 0; i < Duration; i++)
        {
            string prompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];
            Console.WriteLine(prompt);
            PauseWithSpinner(3);

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(3);
            }
        }

        EndActivity();
    }
}

