using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Student
    {
        public string Name { get; private set; }
        private Dictionary<string, int> Scores { get; set; }

        public Student(string name)
        {
            Name = name;
            Scores = new Dictionary<string, int>();
        }

        public void AddScore(string subject, int score)
        {
            if (!Scores.ContainsKey(subject))
            {
                Scores.Add(subject, score);
            }
            else
            {
                Scores[subject] = score;
            }
        }

        public void RemoveScore(string subject)
        {
            if (Scores.ContainsKey(subject))
            {
                Scores.Remove(subject);
            }
        }

        public int GetScore(string subject)
        {
            return Scores.ContainsKey(subject) ? Scores[subject] : -1;
        }

        public Dictionary<string, int> GetScores()
        {
            return Scores;
        }
    }
}
