Console.WriteLine("Take a sentence as input and print out the words");

string userInput = Console.ReadLine();

string[] wordsOnly = userInput.Split(' ');
Console.WriteLine("The words in from our input are the following: ");
foreach (string word in wordsOnly)
{ 
    Console.WriteLine(word);
}