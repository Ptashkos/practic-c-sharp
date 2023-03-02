Console.Write("Введите предложение: ");
string sentence = Console.ReadLine();

    string[] words = sentence.Split(' ');
    
    string temp = words[0];
    words[0] = words[words.Length - 1];
    words[words.Length - 1] = temp;

    words[1] = words[1] + words[2];

    char[] thirdWordChars = words[2].ToCharArray();
    Array.Reverse(thirdWordChars);
    string thirdWordReversed = new string(thirdWordChars);
    Console.WriteLine(thirdWordReversed);

    words[0] = words[0].Substring(2);

    string newSentence = string.Join(" ", words);
    Console.WriteLine(newSentence);

Console.ReadLine();