using System;
using System.Text;
using System.Text.RegularExpressions;

namespace jmsudar.DotNet.InterviewPrep.ToolKit.String
{
    class String
    {
        static void Main(string[] args)
        {
            // Sample strings
            string sampleText = "  Hello, World!  ";
            string anotherText = "C# is a powerful language.";
            string sentence = "The quick brown fox jumps over the lazy dog.";
            string csvData = "apple,banana,grape,orange";
            string formatPattern = "My name is {0} and I am {1} years old.";
            string email = "example@email.com";
            string specialChars = "C#_is@Awesome!";
            string paddedText = "42";
            string whitespaceText = "   ";
            string mixedCase = "cOding is Fun!";
            string numericString = "12345";

            Console.WriteLine("The following strings are used in this example:");
            Console.WriteLine($"sampleText: \"{sampleText}\"");
            Console.WriteLine($"anotherText: \"{anotherText}\"");
            Console.WriteLine($"sentence: \"{sentence}\"");
            Console.WriteLine($"csvData: \"{csvData}\"");
            Console.WriteLine($"formatPattern: \"{formatPattern}\"");
            Console.WriteLine($"email: \"{email}\"");
            Console.WriteLine($"specialChars: \"{specialChars}\"");
            Console.WriteLine($"paddedText: \"{paddedText}\"");
            Console.WriteLine($"whitespaceText: \"{whitespaceText}\"");
            Console.WriteLine($"mixedCase: \"{mixedCase}\"");
            Console.WriteLine($"numericString: \"{numericString}\"");
            Console.WriteLine();

            // 1. Length: Get string length
            Console.WriteLine(".Length");
            Console.WriteLine($"Length of sampleText: {sampleText.Length}");
            Console.WriteLine();

            // 2. Trim: Remove leading and trailing spaces
            Console.WriteLine(".Trim()");
            Console.WriteLine($"Trimmed: \"{sampleText.Trim()}\"");
            Console.WriteLine();

            // 3. ToUpper: Convert to uppercase
            Console.WriteLine(".ToUpper()");
            Console.WriteLine($"Uppercase: \"{sampleText.ToUpper()}\"");
            Console.WriteLine();

            // 4. ToLower: Convert to lowercase
            Console.WriteLine(".ToLower()");
            Console.WriteLine($"Lowercase: \"{sampleText.ToLower()}\"");
            Console.WriteLine();

            // 5. Contains: Check if string contains substring
            Console.WriteLine(".Contains()");
            Console.WriteLine($"Does sentence contain 'fox'? {sentence.Contains("fox")}");
            Console.WriteLine();

            // 6. StartsWith: Check prefix
            Console.WriteLine(".StartsWith()");
            Console.WriteLine($"Does anotherText start with 'C#'? {anotherText.StartsWith("C#")}");
            Console.WriteLine();

            // 7. EndsWith: Check suffix
            Console.WriteLine(".EndsWith()");
            Console.WriteLine($"Does anotherText end with 'language.'? {anotherText.EndsWith("language.")}");
            Console.WriteLine();

            // 8. IndexOf: Find first occurrence of substring
            Console.WriteLine(".IndexOf()");
            Console.WriteLine($"Index of 'quick' in sentence: {sentence.IndexOf("quick")}");
            Console.WriteLine();

            // 9. LastIndexOf: Find last occurrence of substring
            Console.WriteLine(".LastIndexOf()");
            Console.WriteLine($"Last index of 'o' in sentence: {sentence.LastIndexOf("o")}");
            Console.WriteLine();

            // 10. Replace: Replace occurrences of substring
            Console.WriteLine(".Replace()");
            Console.WriteLine($"Replace 'lazy' with 'energetic': \"{sentence.Replace("lazy", "energetic")}\"");
            Console.WriteLine();

            // 11. Split: Split string into array
            Console.WriteLine(".Split()");
            var fruits = csvData.Split(',');
            Console.WriteLine("Split csvData into:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($" - {fruit}");
            }
            Console.WriteLine();

            // 12. Substring: Extract portion of string
            Console.WriteLine(".Substring()");
            Console.WriteLine($"Substring from index 4, length 5: \"{sentence.Substring(4, 5)}\"");
            Console.WriteLine();

            // 13. Remove: Remove portion of string
            Console.WriteLine(".Remove()");
            Console.WriteLine($"Remove first 4 characters: \"{sentence.Remove(0, 4)}\"");
            Console.WriteLine();

            // 14. PadLeft: Pad left with spaces
            Console.WriteLine(".PadLeft()");
            Console.WriteLine($"Padded left (5 spaces): \"{paddedText.PadLeft(5)}\"");
            Console.WriteLine();

            // 15. PadRight: Pad right with spaces
            Console.WriteLine(".PadRight()");
            Console.WriteLine($"Padded right (5 spaces): \"{paddedText.PadRight(5)}\"");
            Console.WriteLine();

            // 16. IsNullOrEmpty: Check if string is null or empty
            Console.WriteLine("String.IsNullOrEmpty()");
            Console.WriteLine($"Is whitespaceText null or empty? {string.IsNullOrEmpty(whitespaceText)}");
            Console.WriteLine();

            // 17. IsNullOrWhiteSpace: Check if string is null or whitespace
            Console.WriteLine("String.IsNullOrWhiteSpace()");
            Console.WriteLine($"Is whitespaceText null or whitespace? {string.IsNullOrWhiteSpace(whitespaceText)}");
            Console.WriteLine();

            // 18. Join: Join array elements into string
            Console.WriteLine("String.Join()");
            Console.WriteLine($"Joined fruits: \"{string.Join(" | ", fruits)}\"");
            Console.WriteLine();

            // 19. Compare: Compare two strings
            Console.WriteLine("String.Compare()");
            int compareResult = string.Compare("apple", "banana");
            Console.WriteLine($"Comparing 'apple' with 'banana': {compareResult} (negative means 'apple' comes first)");
            Console.WriteLine();

            // 20. Equals: Check if two strings are equal
            Console.WriteLine(".Equals()");
            Console.WriteLine($"Does 'apple' equal 'Apple' (case-sensitive)? {"apple".Equals("Apple")}");
            Console.WriteLine();

            // 21. String.Format: Format strings dynamically
            Console.WriteLine(".Format()");
            string formatted = string.Format(formatPattern, "John", 30);
            Console.WriteLine(formatted);
            Console.WriteLine();

            // 22. String Interpolation: A cleaner alternative to Format()
            Console.WriteLine("String Interpolation ($)");
            string interpolated = $"My name is John and I am {30} years old.";
            Console.WriteLine(interpolated);
            Console.WriteLine();

            // 23. Join: Combine an array or list into a single string
            Console.WriteLine(".Join()");
            // The fruits array was created in the .Split() (#11) example above
            string joined = string.Join(", ", fruits);
            Console.WriteLine("Joined string: " + joined);
            Console.WriteLine();

            // 24. Split: Split a string into an array of substrings
            Console.WriteLine(".Split()");
            string[] splitCsv = csvData.Split(',');
            Console.WriteLine("Split CSV Data: " + string.Join(" | ", splitCsv));
            Console.WriteLine();

            // 25. Replace: Replace all occurrences of a substring
            Console.WriteLine(".Replace()");
            string replaced = sentence.Replace("fox", "cat");
            Console.WriteLine("Replaced Sentence: " + replaced);
            Console.WriteLine();

            // 26. Regex.Match: Find a pattern in a string
            Console.WriteLine("Regex.Match()");
            Match match = Regex.Match(email, @"\w+@\w+\.\w+");
            Console.WriteLine("Regex Match Found: " + match.Value);
            Console.WriteLine();

            // 27. Regex.Replace: Replace using regex pattern
            Console.WriteLine("Regex.Replace()");
            string sanitized = Regex.Replace(specialChars, @"[^a-zA-Z0-9]", "");
            Console.WriteLine("Sanitized String: " + sanitized);
            Console.WriteLine();

            // 28. Encoding.UTF8.GetBytes: Convert a string to a byte array
            Console.WriteLine("Encoding.UTF8.GetBytes()");
            byte[] bytes = Encoding.UTF8.GetBytes(sentence);
            Console.WriteLine("Byte Array: " + BitConverter.ToString(bytes));
            Console.WriteLine();

            // 29. StringBuilder: Efficient string manipulation
            Console.WriteLine("StringBuilder (Append, Insert, Replace, Remove)");
            StringBuilder sb = new StringBuilder("Hello World");
            sb.Append("!!!");
            sb.Insert(6, "C# ");
            sb.Replace("World", "Developers");
            sb.Remove(12, 2);
            Console.WriteLine("Modified StringBuilder: " + sb.ToString());
            Console.WriteLine();

            // 30. Normalize: Normalize Unicode strings (important for comparisons)
            Console.WriteLine(".Normalize()");
            string decomposed = "e\u0301"; // é decomposed into 'e' + accent
            string normalized = decomposed.Normalize(NormalizationForm.FormC);
            Console.WriteLine("Original: " + decomposed);
            Console.WriteLine("Normalized: " + normalized);
            Console.WriteLine();
        }
    }
}