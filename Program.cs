namespace Task7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreManager scoreManager = new ScoreManager();

            // Add five initial students with scores
            Dictionary<string, int> johnScores = new Dictionary<string, int>
        {
            {"Math", 90},
            {"English", 85},
            {"History", 75}
        };

            Dictionary<string, int> aliceScores = new Dictionary<string, int>
        {
            {"Math", 95},
            {"English", 92},
            {"History", 88}
        };

            Dictionary<string, int> bobScores = new Dictionary<string, int>
        {
            {"Math", 88},
            {"English", 79},
            {"History", 70}
        };

            Dictionary<string, int> eveScores = new Dictionary<string, int>
        {
            {"Math", 92},
            {"English", 87},
            {"History", 80}
        };

            Dictionary<string, int> charlieScores = new Dictionary<string, int>
        {
            {"Math", 75},
            {"English", 70},
            {"History", 68}
        };

            scoreManager.AddStudent("John", johnScores);
            scoreManager.AddStudent("Alice", aliceScores);
            scoreManager.AddStudent("Bob", bobScores);
            scoreManager.AddStudent("Eve", eveScores);
            scoreManager.AddStudent("Charlie", charlieScores);

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Add Score");
                Console.WriteLine("4. Remove Score");
                Console.WriteLine("5. Get Student Score");
                Console.WriteLine("6. Get All Students with Scores");
                Console.WriteLine("7. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter student name: ");
                            string studentName = Console.ReadLine();
                            scoreManager.AddStudent(studentName, new Dictionary<string, int>());
                            break;

                        case 2:
                            Console.Write("Enter student name: ");
                            studentName = Console.ReadLine();
                            scoreManager.RemoveStudent(studentName);
                            break;

                        case 3:
                            Console.Write("Enter student name: ");
                            studentName = Console.ReadLine();
                            Console.Write("Enter subject: ");
                            string subject = Console.ReadLine();
                            if (int.TryParse(Console.ReadLine(), out int score))
                            {
                                scoreManager.AddScore(studentName, subject, score);
                            }
                            else
                            {
                                Console.WriteLine("Invalid score. Please enter a valid number.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter student name: ");
                            studentName = Console.ReadLine();
                            Console.Write("Enter subject: ");
                            subject = Console.ReadLine();
                            scoreManager.RemoveScore(studentName, subject);
                            break;

                        case 5:
                            Console.Write("Enter student name: ");
                            studentName = Console.ReadLine();
                            Console.Write("Enter subject: ");
                            subject = Console.ReadLine();
                            int studentScore = scoreManager.GetStudentScore(studentName, subject);
                            if (studentScore != -1)
                            {
                                Console.WriteLine($"{studentName} scored {subject}: {studentScore}");
                            }
                            else
                            {
                                Console.WriteLine("Student not found or no score for the subject.");
                            }
                            break;

                        case 6:
                            List<Student> studentsWithScores = scoreManager.GetStudentsWithScores();
                            Console.WriteLine("List of Students with Scores:");
                            foreach (var student in studentsWithScores)
                            {
                                Console.WriteLine($"{student.Name}'s Scores:");
                                foreach (var item in student.GetScores())
                                {
                                    Console.WriteLine($"{item.Key}: {item.Value}");
                                }
                            }
                            break;

                        case 7:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select the correct option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}