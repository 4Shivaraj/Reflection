﻿// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Reflection Problems");
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in Happy Mood");
            Console.WriteLine("Mood is: " + moodAnalysis.AnalyseMood());

            Console.ReadLine();

        }
    }
}