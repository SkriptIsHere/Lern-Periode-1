
int Score = 0;
int EndScore = 0;
bool Weiter = true;

do
{
    //Titel
    Console.SetCursorPosition(71, 4);
    Console.WriteLine("================");
    Console.SetCursorPosition(71, 5);
    Console.WriteLine("  QUIZ MASTERS");
    Console.SetCursorPosition(71, 6);
    Console.WriteLine("================");


    //Alle Fragen and Antworten werden in ein Array gespeichert
    Console.SetCursorPosition(55, 8);
    string[] questions =
    {
    "     Wie heißt die Hauptstadt von Deutschland? ", "       Wie heißt der höchste Berg der Welt? ",
    "   Welcher Planet ist der Sonne am nächsten? ", "Welches Tier wird oft als „König der Tiere“ bezeichnet?  ", "     Wie viele Planeten hat unser Sonnensystem",
    "   Welches Land hat die meisten Einwohner der Welt?", "Welcher Komponist schuf das berühmte Werke wie die 9. Sinfonie?", "      Welches Land hat die meisten Inseln?", "    Welches Land hat die Form eines Stiefels?"

};

    string[] answers = {
    "Berlin", "Mount Everest", "Merkur", "Löwe", "Acht", "Indien", "Beethoven", "Schweden", "Italien"

};

    //Die Zufallsfunktion
    Random random = new Random();
    int QuestionRandomizer = random.Next(questions.Length);


    Console.WriteLine(questions[QuestionRandomizer]);

    //antworten
    Console.SetCursorPosition(74, 12);
    string answer = Console.ReadLine();

    //Prüfe mit der passenden Antwort + Score
    if (answer == answers[QuestionRandomizer])
    {
        Console.WriteLine("Richtig!");
        Score = Score + 1;
        Console.Clear();
      
        Console.WriteLine("Dein Score ist " + Score);
             

            }
    else
    {
        Console.WriteLine("Falsch! Richtige Antwort: " + answers[QuestionRandomizer]);
        EndScore = Score;
    Weiter = false;

        Console.WriteLine("Dein Endscore ist " + EndScore);
    }
}
while (Weiter == true);































