using System;

namespace SentimentModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a positive or negative comment that you would say about some resturant, business, etc..");
            Console.Write("> ");
            var userInput = Console.ReadLine();


            // Add input data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = userInput
            };

            // Load model and predict output of sample data
            var result = SentimentModel.Predict(sampleData);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            string sentiment = result.Prediction == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

        }
    }
}
