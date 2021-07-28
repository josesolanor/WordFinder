using Application;
using Domain;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Sources\\DataSource.json");
            var jsonString = File.ReadAllText(path);
            var sourceObject = JObject.Parse(jsonString);

            Dictionary dictionary  = new Dictionary(sourceObject.SelectToken("Dictionary").Values<string>().ToList());
            Matrix matrix = new Matrix(sourceObject.SelectToken("Matrix").Values<string>().ToList());
            var result = new WordFinder(dictionary.Source).Find(matrix.Source);
            Console.WriteLine(string.Join(",", result));
        }
    }
}
