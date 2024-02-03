using System;

class Program
{
    public class Journal
    {
        public GetPrompt()
        {
             string datePrompt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return "Enter your journal entry (type 'exit' to stop): ";
        }

        void run()
        {
            Console.WriteLine("Journal is running...");
        }

        void saveToFile()
        {

        }

        void loadToFile()
        {
            
        }

    }
    

}