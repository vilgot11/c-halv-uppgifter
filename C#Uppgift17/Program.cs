using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<int, string> subjects = new Dictionary<int, string>
            
            {
                {1, "Add a new subject" },
                {2, "Remove a subject" },
                {3, "Display all subject and their teacher" },
                {4, "Exit" }
                
            };
            for (int i = 0; i < subjects.Count; i++)
            {
                KeyValuePair<int, string> pair = subjects.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            string choise = Console.ReadLine();

            Console.WriteLine("Choose option between 1 and 4: ");
            Console.ReadLine();

            switch (choise)
            {/*
                case "1":
                    Console.WriteLine("Enter subject name");
                    string subjectName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(subjectName))
                    {
                        Console.WriteLine("no subject writen");
                    }
                    

                    Console.WriteLine("Enter Teacher name");
                    string TeacherName = Console.ReadLine();

                    if (string.IsNullOrEmpty(TeacherName))
                    {
                        Console.WriteLine("no Teacher writen");
                    }

                    if (!subjects.ContainsKey(subjectName))
                    {
                        subjects.Add(subjectName, TeacherName);
                        Console.WriteLine($"subject {subjectName} added and teacher {TeacherName} added");

                    }
                    
                    break;
                    */
                    case "2":
                    Console.WriteLine("Subject to remove name");
                    string SubjectToRemove = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace (SubjectToRemove))
                    {
                        Console.WriteLine($"subject to remove {SubjectToRemove}");
                    }
                    break;

                    case "3":


                    if (subjects.Count == 0)
                    {
                        Console.WriteLine("no subjects");
                    }
                    else
                    {
                        Console.WriteLine("subjects: ");
                        foreach (var subject in subjects)
                        {
                            Console.WriteLine($"{subject.Key} {subject.Value}");
                        }
                    }
                    break;
                    case "4":
                    Console.WriteLine("Bye");
                    break;
                        
                    

                    

            }
            

            Console.ReadLine();
            }
        

            
            
















                
        }
    }

