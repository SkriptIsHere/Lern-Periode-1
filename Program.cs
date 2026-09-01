//Titel
Console.SetCursorPosition(71, 4);
Console.WriteLine("================");
Console.SetCursorPosition(71, 5);
Console.WriteLine("  Quiz Masters");
Console.SetCursorPosition(71, 6);
Console.WriteLine("================");

//Alle fragen werden in ein Array gespeichert
Console.SetCursorPosition(60, 8);
string[] questions =
{
    "Wie heißt die Hauptstadt von Deutschland? ", "Wie heißt der höchste Berg der Welt? ",
    "Welcher Planet ist der Sonne am nächsten? ", "Welches Tier wird oft als „König der Tiere“ bezeichnet? "

};

//Die Zufallsfunktion
Random random = new Random();
int QuestionRandomizer = random.Next(questions.Length);

Console.WriteLine(questions[QuestionRandomizer]);

//antworten
Console.SetCursorPosition(70, 12);
string answer = Console.ReadLine();



















