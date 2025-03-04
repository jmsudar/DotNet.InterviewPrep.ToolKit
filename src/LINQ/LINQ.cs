using System;
using System.Collections.Generic;
using System.Linq;

namespace jmsudar.DotNet.InterviewPrep.ToolKit.LINQ
{
    class LINQ
    {
        static void Main(string[] args)
        {
            // General tips:
            // LINQ methods are lazy, meaning they don't execute until you iterate over them.
            // You can chain multiple LINQ methods together.
            // LINQ methods are extension methods, so they are called on an IEnumerable<T> object.
            // If you need to tell if a LINQ query operate in-place, check for a void return type.

            // Sample data
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var words = new List<string> { "apple", "banana", "cherry", "elderberry", "date" };
            var moreNumbers = new List<int> { 5, 6, 7, 8 };
            var duplicateNumbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("The following data structures are used in this example:");
            Console.WriteLine("numbers: " + string.Join(", ", numbers));
            Console.WriteLine("words: " + string.Join(", ", words));
            Console.WriteLine("moreNumbers: " + string.Join(", ", moreNumbers));
            Console.WriteLine("duplicateNumbers: " + string.Join(", ", duplicateNumbers));
            Console.WriteLine();

            // 1. Where: Filter elements
            // Uses the modulo operator to check if a number is even.
            // .Where() uses this lambda expression to filter the numbers list.
            Console.WriteLine(".Where()");
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine();

            // 2. Select: Transform elements
            // Multiplies each number by itself.
            // In this case, .Select() acts on every element in the numbers list.
            Console.WriteLine(".Select()");
            var squaredNumbers = numbers.Select(n => n * n);
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));
            Console.WriteLine();

            // 3. OrderBy: Sort ascending
            // Linq provides a method to sort, but does not sort in place.
            // By default, it sorts in ascending order.
            Console.WriteLine(".OrderBy()");
            var sortedWords = words.OrderBy(w => w);
            Console.WriteLine("Sorted words: " + string.Join(", ", sortedWords));
            Console.WriteLine();

            // 4. OrderByDescending: Sort descending
            // This method sorts in descending order.
            Console.WriteLine(".OrderByDescending()");
            var reverseSortedWords = words.OrderByDescending(w => w);
            Console.WriteLine("Reverse sorted words: " + string.Join(", ", reverseSortedWords));
            Console.WriteLine();

            // 5. GroupBy: Group elements
            // Groups elements by a given assessor.
            // In this case by their length.
            Console.WriteLine(".GroupBy()");
            var groupedByLength = words.GroupBy(w => w.Length);
            foreach (var group in groupedByLength)
            {
                Console.WriteLine($"Words of length {group.Key}: {string.Join(", ", group)}");
            }
            Console.WriteLine();

            // 6. Aggregate: Perform accumulation
            // Aggregation refers to the process of combining
            // multiple elements into a single result.
            // In this case, it concatenates all the words.
            Console.WriteLine(".Aggregate()");
            var sentence = words.Aggregate((current, next) => current + next);
            Console.WriteLine("Concatenated words: " + sentence);
            Console.WriteLine();

            // 7. Any: Check if any element meets a condition
            // Checks the entire collection against a condition for any fits.
            Console.WriteLine(".Any()");
            bool hasShortWord = words.Any(w => w.Length < 5);
            Console.WriteLine("There are words shorter than 5 char: " + hasShortWord);
            Console.WriteLine();

            // 8. All: Check if all elements meet a condition
            // Checks the entire collection against a condition for even one single fit.
            Console.WriteLine(".All()");    
            bool allLongWords = words.All(w => w.Length > 3);
            Console.WriteLine("There are words longer than 3 char: " + allLongWords);
            Console.WriteLine();

            // 9. Count: Count elements
            // Counts the number of elements in the collection.
            Console.WriteLine(".Count()");
            int countWords = words.Count();
            Console.WriteLine("Number of words: " + countWords);
            Console.WriteLine();

            // 10. First: Get first element
            // Gets the first element in the collection.
            Console.WriteLine(".First()");
            Console.WriteLine("First word in words: " + words.First());
            Console.WriteLine();

            // 11. FirstOrDefault: Get first element or default
            // Either gets the first element that satisfies a condition, or returns
            // the default value, which is usually but may not be null.
            Console.WriteLine(".FirstOrDefault()");
            Console.WriteLine("First word in words with 'z' or default: " 
                + words.FirstOrDefault(w => w.Contains('z')) ?? "None");
            Console.WriteLine();        

            // 12. Last: Get last element
            // Gets the last element in the collection.
            Console.WriteLine(".Last()");
            Console.WriteLine("Last word in words: " + words.Last());
            Console.WriteLine();

            // 13. LastOrDefault: Get last element or default
            // Either gets the last element that satisfies a condition, or returns
            // the default value, which is usually but may not be null.
            Console.WriteLine(".LastOrDefault()");
            Console.WriteLine("Last word in words with 'z' or default: " 
                + words.LastOrDefault(w => w.Contains('z')) ?? "None");
            Console.WriteLine();

            // 14. Take: Take first N elements
            // Grabs a specified number of elements from the start of the collection.
            Console.WriteLine(".Take()");
            Console.WriteLine("First 3 words: " + string.Join(", ", words.Take(3)));
            Console.WriteLine();

            // 15. Skip: Skip first N elements
            // Starts at the specified index and returns the rest of the collection.
            Console.WriteLine(".Skip()");
            Console.WriteLine("Skip first 2 words: " + string.Join(", ", words.Skip(2)));
            Console.WriteLine();

            // 16. Distinct: Remove duplicates
            // Dedupes a collection.
            Console.WriteLine(".Distinct()");
            Console.WriteLine("Unique numbers in duplicateNumbers: " 
                + string.Join(", ", duplicateNumbers.Distinct()));
            Console.WriteLine();

            // 17. Union: Combine lists without duplicates
            // Gets the unique elements between two collections.
            Console.WriteLine(".Union()");
            Console.WriteLine("Union of numbers and moreNumbers: " 
                + string.Join(", ", numbers.Union(moreNumbers)));
            Console.WriteLine();

            // 18. Intersect: Common elements in lists
            // Gets the common elements between two collections.
            Console.WriteLine(".Intersect()");
            Console.WriteLine("Intersection of numbers and moreNumbers: " 
                + string.Join(", ", numbers.Intersect(moreNumbers)));
            Console.WriteLine();

            // 19. Except: Elements in first list but not in second
            // Gets the elements in the first collection that are not in the second.
            Console.WriteLine(".Except()");
            Console.WriteLine("Numbers in numbers but not in moreNumbers: " 
                + string.Join(", ", numbers.Except(moreNumbers)));
            Console.WriteLine();

            // 20. Zip: Combine two lists element-wise
            // Combines two collections into a single collection of pairs.
            Console.WriteLine(".Zip()");
            var zippedList = numbers.Zip(words, (num, word) => $"{num}: {word}");
            Console.WriteLine("Zipped list of numbers and words: " 
                + string.Join(", ", zippedList));
        }
    }
}