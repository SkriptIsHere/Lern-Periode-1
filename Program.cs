using System.Threading;

class QuizMaster
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(72, 13);
        Console.Write("QUIZ MASTERS");

        Console.SetCursorPosition(72, 16);
        Console.Write("Start Game[1]");

        Console.SetCursorPosition(72, 17);
        Console.Write("Exit[2]");

        Console.SetCursorPosition(72, 20);
        Console.Write("> ");

        ConsoleKeyInfo input = Console.ReadKey();

        if (input.Key == ConsoleKey.D1)
        {
            Console.Clear();
            Console.ResetColor();
            Loading();
            Thread.Sleep(1000);
            Console.Clear();
            Quiz();
                
        }
        else if (input.Key == ConsoleKey.D2)
            {

            Environment.Exit(0);
        }

        

    }

    static void Loading()
    {
        string text = "Loading...";

        Console.SetCursorPosition(73, 15);
        foreach (char Buchstabe in text)
        {
            Console.Write(Buchstabe);
            Thread.Sleep(100);

        }

    }

    static void Quiz()
    {

    int Score = 0;
    int EndScore = 0;
    bool Weiter = true;
    int letzteFrage = -1;

    Random random = new Random();

    string[] questions =
    {
    "          Wie heißt die Hauptstadt von Deutschland? ", "            Wie heißt der höchste Berg der Welt? ",
    "         Welcher Planet ist der Sonne am nächsten? ", "  Welches Tier wird oft als „König der Tiere“ bezeichnet?  ", "          Wie viele Planeten hat unser Sonnensystem",
    "        Welches Land hat die meisten Einwohner der Welt?", "Welcher Komponist schuf das berühmte Werke wie die 9. Sinfonie?", "           Welches Land hat die meisten Inseln?", "         Welches Land hat die Form eines Stiefels?"

};

    string[] answers = {
    "Berlin", "Mount Everest", "Merkur", "Löwe", "Acht", "Indien", "Beethoven", "Schweden", "Italien"

};

    do
{
    //Titel
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(70, 4);
    Console.WriteLine("================");
    Console.SetCursorPosition(70, 5);
    Console.WriteLine("  QUIZ MASTERS");
    Console.SetCursorPosition(70, 6);
    Console.WriteLine("================");
    Console.ResetColor();


    //Alle Fragen and Antworten werden in ein Array gespeichert
    Console.ForegroundColor= ConsoleColor.Yellow;
    Console.SetCursorPosition(50, 8);
    

    //Die Zufallsfunktion
    int QuestionRandomizer = random.Next(questions.Length);


 // Verhindert doppel-Fragen
    while (letzteFrage == QuestionRandomizer)
    {
          QuestionRandomizer = random.Next(questions.Length);
    }

          letzteFrage = QuestionRandomizer;


    // Schreibt die zufallige Frage
    Console.WriteLine(questions[QuestionRandomizer]);


    //antworten
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(72, 12);
    Console.Write("> ");
    string answer = Console.ReadLine();

    //Prüfe mit der passenden Antwort + Score ( || = oder, && = und)
    if (answer.Equals(answers[QuestionRandomizer], StringComparison.OrdinalIgnoreCase)
    || (QuestionRandomizer == 4 && answer == "8"))
            {
        Console.WriteLine("Richtig!");
        Score = Score + 1;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dein Score ist " + Score);
        Console.ResetColor();
             

            }
    else
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Falsch! Richtige Antwort: " + answers[QuestionRandomizer]);
        EndScore = Score;
    Weiter = false;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dein Endscore ist " + EndScore);
        Console.ResetColor();
    }
}
while (Weiter == true);

    }

   
}




































