using System.Collections.Generic;
using System;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main()
        {
            List<string> initialCourses = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] args = input.Split(":");
                string command = args[0];

                switch (command)
                {
                    case "Add":
                        string subject = args[1];
                        AddSubject(initialCourses, subject);
                        break;
                    case
                        "Insert":
                        int index = int.Parse(args[2]);
                        subject = args[1];
                        InsertSubject(initialCourses, subject, index);
                        break;
                    case
                        "Remove":
                        subject = args[1];
                        RemoveSubject(initialCourses, subject);
                        break;
                    case
                        "Swap":
                        string subject1 = args[1];
                        string subject2 = args[2];
                        SwapSubject(initialCourses, subject1, subject2);

                        break;
                    case
                        "Exercise":
                        subject = args[1];

                        AddExercise(initialCourses, subject);

                        break;
                }

            }

            for (int i = 0; i < initialCourses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialCourses[i]}");
            }
        }

        static void AddExercise(List<string> initialCourses, string subject)
        {
            if (!initialCourses.Contains(subject + "-Exercise"))
            {
                if (initialCourses.Contains(subject))
                {
                    int subjectIndex = initialCourses.IndexOf(subject);
                    initialCourses.Insert(subjectIndex + 1, subject + "-Exercise"); ;
                }
                else
                {
                    initialCourses.Add(subject);
                    int subjectIndex = initialCourses.IndexOf(subject);
                    initialCourses.Insert(subjectIndex + 1, subject + "-Exercise");
                }
            }

                
        }

        static void SwapSubject(List<string> initialCourses, string subject1, string subject2)
        {
            int firstIndex = initialCourses.IndexOf(subject1);
            int secondIndex = initialCourses.IndexOf(subject2);
            if (initialCourses.Contains(subject1) && initialCourses.Contains(subject2))
            {

                initialCourses[firstIndex] = subject2;
                initialCourses[secondIndex] = subject1;
            }
            
            
                initialCourses = SwapExercise(initialCourses, subject1, secondIndex);
                initialCourses = SwapExercise(initialCourses, subject2, firstIndex);
            
            
        }
        private static List<string> SwapExercise(List<string> initialCourses, string title, int titleIndex)
        {
            string exerciseTitle = $"{title}-Exercise";
            int index = initialCourses.FindIndex(x => x == exerciseTitle);
                if (index >= 0)
                {
                
                    initialCourses.Remove(exerciseTitle);
                    initialCourses.Insert(titleIndex + 1, exerciseTitle);
                
                    
   
            }

            return initialCourses;
        }
            static void InsertSubject(List<string> initialCourses, string subject, int index)
            {
                if (!initialCourses.Contains(subject))
                {
                    initialCourses.Insert(index, subject);
                }
            }

            static void RemoveSubject(List<string> initialCourses, string subject)
            {
                if (initialCourses.Contains(subject))
                {
                    initialCourses.Remove(subject);
                }
            }

            static void AddSubject(List<string> initialCourses, string subject)
            {
                if (!initialCourses.Contains(subject))
                {
                    initialCourses.Add(subject);
                }



            }
        }
    }

