using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string basePath = @"D:\QINSHIFT\PROEKTI\GITHUB\seesharpadvanced_homeworks\homework7\homework7.sln\homework7.app";
        string folderPath = Path.Combine(basePath, "Files");
        string namesFilePath = Path.Combine(folderPath, "names.txt");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Folder created!");
        }
        else
        {
            Console.WriteLine("Folder already exists!");
        }

        if (!File.Exists(namesFilePath))
        {
            File.Create(namesFilePath).Close();
            Console.WriteLine("File created!");
        }
        else
        {
            Console.WriteLine("File already exists!");
        }

        string existingContent = File.ReadAllText(namesFilePath);
        Console.WriteLine("Current contents of names.txt:");
        Console.WriteLine(string.IsNullOrWhiteSpace(existingContent) ? "(empty)" : existingContent);

        Console.WriteLine("\nEnter new names, separated by commas:");
        string input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            List<string> newNames = input.Split(',')
                                         .Select(name => name.Trim())
                                         .Where(name => !string.IsNullOrEmpty(name))
                                         .ToList();

            File.AppendAllLines(namesFilePath, newNames);
            Console.WriteLine("Names have been added to the file.");
        }
        else
        {
            Console.WriteLine("No names entered.");
        }

        string[] allNames = File.ReadAllLines(namesFilePath);

        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            var filteredNames = allNames
                .Where(name => !string.IsNullOrWhiteSpace(name) && name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                .Distinct()
                .ToList();

            if (filteredNames.Any())
            {
                string filteredFilePath = Path.Combine(folderPath, $"namesStartingWith_{letter}.txt");

                if (File.Exists(filteredFilePath))
                {
                    var existingFilteredNames = File.ReadAllLines(filteredFilePath).ToHashSet(StringComparer.OrdinalIgnoreCase);

                    var namesToAdd = filteredNames.Where(n => !existingFilteredNames.Contains(n)).ToList();

                    if (namesToAdd.Any())
                    {
                        File.AppendAllLines(filteredFilePath, namesToAdd);
                    }
                }
                else
                {
                    File.WriteAllLines(filteredFilePath, filteredNames);
                }
            }
        }

        Console.WriteLine("Filtering and saving by starting letters completed.");
    }
}
