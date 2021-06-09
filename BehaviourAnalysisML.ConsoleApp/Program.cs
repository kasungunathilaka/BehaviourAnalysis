using System;
using BehaviourAnalysisML.Model;

namespace BehaviourAnalysisML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Feeling_nervous = 4F,
                Panic = 3F,
                Breathing_rapidly = 1F,
                Sweating = 3F,
                Trouble_in_concentration = 2F,
                Having_trouble_in_sleeping = 1F,
                Having_trouble_with_work = 1F,
                Hopelessness = 2F,
                Anger = 1F,
                Over_react = 2F,
                Change_in_eating = 1F,
                Suicidal_thought = 2F,
                Feeling_tired = 6F,
                Close_friend = 10F,
                Social_media_addiction = 6F,
                Weight_gain = 7F,
                Material_possessions = 8F,
                Introvert = 6F,
                Popping_up_stressful_memory = 4F,
                Having_nightmares = 5F,
                Avoids_people_or_activities = 5F,
                Feeling_negative = 1F,
                Trouble_concentrating = 5F,
                Blamming_yourself = 3F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Disorder with predicted Disorder from sample data...\n\n");
            Console.WriteLine($"Feeling_nervous: {sampleData.Feeling_nervous}");
            Console.WriteLine($"Panic: {sampleData.Panic}");
            Console.WriteLine($"Breathing_rapidly: {sampleData.Breathing_rapidly}");
            Console.WriteLine($"Sweating: {sampleData.Sweating}");
            Console.WriteLine($"Trouble_in_concentration: {sampleData.Trouble_in_concentration}");
            Console.WriteLine($"Having_trouble_in_sleeping: {sampleData.Having_trouble_in_sleeping}");
            Console.WriteLine($"Having_trouble_with_work: {sampleData.Having_trouble_with_work}");
            Console.WriteLine($"Hopelessness: {sampleData.Hopelessness}");
            Console.WriteLine($"Anger: {sampleData.Anger}");
            Console.WriteLine($"Over_react: {sampleData.Over_react}");
            Console.WriteLine($"Change_in_eating: {sampleData.Change_in_eating}");
            Console.WriteLine($"Suicidal_thought: {sampleData.Suicidal_thought}");
            Console.WriteLine($"Feeling_tired: {sampleData.Feeling_tired}");
            Console.WriteLine($"Close_friend: {sampleData.Close_friend}");
            Console.WriteLine($"Social_media_addiction: {sampleData.Social_media_addiction}");
            Console.WriteLine($"Weight_gain: {sampleData.Weight_gain}");
            Console.WriteLine($"Material_possessions: {sampleData.Material_possessions}");
            Console.WriteLine($"Introvert: {sampleData.Introvert}");
            Console.WriteLine($"Popping_up_stressful_memory: {sampleData.Popping_up_stressful_memory}");
            Console.WriteLine($"Having_nightmares: {sampleData.Having_nightmares}");
            Console.WriteLine($"Avoids_people_or_activities: {sampleData.Avoids_people_or_activities}");
            Console.WriteLine($"Feeling_negative: {sampleData.Feeling_negative}");
            Console.WriteLine($"Trouble_concentrating: {sampleData.Trouble_concentrating}");
            Console.WriteLine($"Blamming_yourself: {sampleData.Blamming_yourself}");
            Console.WriteLine($"\n\nPredicted Disorder value {predictionResult.Prediction} \nPredicted Disorder scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
