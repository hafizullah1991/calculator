using System;

class ChatBox
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Chat Box!");

        while (true)
        {
            Console.Write("You: ");
            string userMessage = Console.ReadLine();

            // Check for exit condition
            if (userMessage.ToLower() == "exit")
            {
                Console.WriteLine("Chat Box closed. Goodbye!");
                break;
            }

            // Respond to user
            string botResponse = GetBotResponse(userMessage);
            Console.WriteLine($"Bot: {botResponse}");
        }
    }

    static string GetBotResponse(string userMessage)
    {
        // You can customize the bot's responses based on user input
        // For simplicity, let's just echo the user's message
        return $"You said: {userMessage}";
    }
}