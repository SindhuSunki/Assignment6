using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array to store student scores
            int[][] studentScores = new int[3][];

            // Get the number of scores for each student from the user
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Enter the number of scores for student {i + 1}: ");
                int numScores = int.Parse(Console.ReadLine());

                // Create an array to store the scores for the current student
                studentScores[i] = new int[numScores];

                // Get the scores for the current student from the user
                for (int j = 0; j < numScores; j++)
                {
                    Console.Write($"Enter score {j + 1} for student {i + 1}: ");
                    studentScores[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Print the scores of each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.WriteLine($"Scores for student {i + 1}:");

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.WriteLine($"Score {j + 1}: {studentScores[i][j]}");
                }

                Console.WriteLine();
            }

            // Calculate and print the average score for each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = (double)sum / studentScores[i].Length;

                Console.WriteLine($"Average score for student {i + 1}: {average:F2}");
            }

            // Calculate and print the average score for all the students combined
            int totalSum = 0;
            int totalCount = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }

            double totalAverage = (double)totalSum / totalCount;

            Console.WriteLine($"Average score for all students combined: {totalAverage:F2}");
            Console.ReadKey();
        }
    }
}