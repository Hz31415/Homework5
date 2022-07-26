using HomeWork5._1;


Console.WriteLine("Do You want to test first or second task (Type 1/2)");

string taskNum = Console.ReadLine();

if (taskNum == "1")
{
    Console.WriteLine("Please input tour sentence");
    string sentence = Console.ReadLine(); //можно было и в нижюю строку вписать - SentenceProcessing.WordsArrOut(SentenceProcessing.Splitter(Console.ReadLine()));

    SentenceProcessing.WordsArrOut(SentenceProcessing.Splitter(sentence));
}
else if (taskNum == "2")
{
    Console.WriteLine("Please input tour sentence");
    string sentence = Console.ReadLine();
    SentenceProcessing.WordsArrOut(SentenceProcessing.ReversWords(sentence));
}

