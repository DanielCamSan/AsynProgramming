using System;
using System.Collections.Generic;
namespace AsynProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            cities.Add("France", "Paris, Ratatouille");
        
            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
