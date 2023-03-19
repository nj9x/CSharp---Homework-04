Console.WriteLine("Please enter a number:");
int number = int.Parse(Console.ReadLine());

int sum = SumOfDigits(number);

Console.WriteLine($"The sum of the digits in {number} is {sum}.");

Console.WriteLine("Please enter a sentence:");
string sentence = Console.ReadLine();

string largestWord = FindLargestWord(sentence);

Console.WriteLine($"The largest word in the sentence is '{largestWord}'.");


int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

string FindLargestWord(string sentence)
{
    string[] words = sentence.Split(' ');

    string largestWord = "";
    foreach (string word in words)
    {
        if (word.Length > largestWord.Length)
        {
            largestWord = word;
        }
    }
    return largestWord;
}