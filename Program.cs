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

    static void Text(string text)
    {
        foreach (char Buchstabe in text)
        {
            Console.Write(Buchstabe);
            Thread.Sleep(40);

        }


    }

    static void Quiz()
    {

    int Score = 0;
    int EndScore = 0;
    bool Weiter = true;
    int letzteFrage = -1;

    Random random = new Random();


        //Alle Fragen and Antworten werden in ein Array gespeichert
        string[] questions =
    {
    "          Wie heißt die Hauptstadt von Deutschland? ", "            Wie heißt der höchste Berg der Welt? ",
    "         Welcher Planet ist der Sonne am nächsten? ", "  Welches Tier wird oft als „König der Tiere“ bezeichnet?  ", "          Wie viele Planeten hat unser Sonnensystem",
    "        Welches Land hat die meisten Einwohner der Welt?", "Welcher Komponist schuf das berühmte Werke wie die 9. Sinfonie?", "           Welches Land hat die meisten Inseln?", "         Welches Land hat die Form eines Stiefels?",  "Wie heißt die Hauptstadt von Frankreich?",
    "         Wie viele Kontinente gibt es?",
    "         Welcher Planet ist als Roter Planet bekannt?",
    "         Wie heißt der längste Fluss der Welt?",
    "         Wie viele Tage hat ein Schaltjahr?",
    "         Wer malte die Mona Lisa?",
    "         Wie heißt das größte Land der Welt?",
    "         Wie viele Beine hat eine Spinne?",
    "         Welches Meer liegt zwischen Europa und Afrika?",
    "         Wie heißt die Hauptstadt von Japan?",
    "         Welches Element hat das chemische Symbol O?",
    "         Wie viele Spieler hat eine Fußballmannschaft auf dem Spielfeld?",
    "         Welches ist das größte Säugetier der Welt?",
    "         Wie heißt der höchste Berg der Schweiz?",
    "         In welchem Land stehen die Pyramiden von Gizeh?",
    "         Wie viele Minuten hat eine Stunde?",
    "         Welcher Planet ist der größte in unserem Sonnensystem?",
    "         Wie heißt die Hauptstadt von Italien?",
    "         Wie viele Seiten hat ein Würfel?",
    "         Welches Land ist für seine Form eines Stiefels bekannt?",
    "         Wer schrieb das Drama 'Faust'?",
    "         Wie heißt der natürliche Satellit der Erde?",
    "         Wie viele Farben hat ein Regenbogen normalerweise?",
    "         Welches Tier ist das schnellste Landtier?",
    "         Wie heißt die Hauptstadt von Spanien?",
    "         Welches Organ pumpt Blut durch den menschlichen Körper?",
    "         Wie viele Monate hat ein Jahr?",
    "         Welcher Kontinent ist der größte?",
    "           Wie heißt die Währung der Schweiz?",
    "         Welches Gas brauchen Menschen zum Atmen?"

};

    string[] answers = {
    "Berlin", "Mount Everest", "Merkur", "Löwe", "Acht", "Indien", "Beethoven", "Schweden", "Italien",  "Paris",
    "7",
    "Mars",
    "Nil",
    "366",
    "Leonardo da Vinci",
    "Russland",
    "8",
    "Mittelmeer",
    "Tokio",
    "Sauerstoff",
    "11",
    "Blauwal",
    "Dufourspitze",
    "Ägypten",
    "60",
    "Jupiter",
    "Rom",
    "6",
    "Italien",
    "Goethe",
    "Mond",
    "7",
    "Gepard",
    "Madrid",
    "Herz",
    "12",
    "Asien",
    "Franken",
    "Sauerstoff"

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
            Text(questions[QuestionRandomizer]);


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
        Text("Falsch! Richtige Antwort: " + answers[QuestionRandomizer]);
        EndScore = Score;
    Weiter = false;

        Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
        Text("Dein Endscore ist " + EndScore);
        Console.ResetColor();
    }
}
while (Weiter == true);

    }

   
}




































