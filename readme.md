# Lern-Periode 1

28.8 bis ?


## fertiges Projekt - QUIZ MASTERS

Mein Projekt stellt den Benutzer Allgemein Wissen fragen, die man dann Beantworten kann. Das Quiz geht unendlich bis man falsch hat. Nach eine richtigen Antwort bekommt der Benutzer +1 Punkt und der Highscore wird auch angezeigt wenn man verloren hat.



<img width="400" height="205" alt="code1" src="https://github.com/user-attachments/assets/3a1825d6-4e79-4727-af36-369fec230b3d" />
<img width="400" height="203" alt="Code2" src="https://github.com/user-attachments/assets/d95ce683-c10a-4ab0-8a8f-f0ae7dbd2549" />



Mein Projekt heisst Quiz Masters und es geht um ein Quiz. Seit dem Anfang hatte ich die Vision ein Quiz spiel mit Punktesystem der unendlich geht. Meine Inspiration ist Flappy Bird aber nur das Unendlichkeits- und Punktesystem also was ich damit meine ist, dass ich das ähnliche gefühl wie bei Flappy Bird machen wollte wo man sich mit seinen Freunden misst oder seinen eigenen Highscore brechen will.

Mein wichtigstes Erfolg war die Entdeckung von Funktionen oder besser gesagt von (static void) dies hat mir viel mehr Möglichkeiten geben neue Funktionen in mein Quiz spiel einzubauen wie z.B Ein Titel-screen, ein Loading-screen usw. Es hat auch alles viel strukturirter für mich gemacht das nicht alles in einer Methode ist. Ein andere wichtiger Meilenstein war auch die Entdeckung von (Console.SetCursorPoition) was die ansicht ermöglicht hat und auch die Möglichkeit Texte zu farbieren. Honorable Mentions: Ein wichtiger Schritt um coole Funktionen zum funktionieren zu bringen war die ReadKey Funktion sowie die DateTime Funktion die sehr nützlich ist wenn man mit Zeit arbeiten will.

Was ich daraus gelernt habe ist, dass ich immer etwas krasseres machen will, obwohl ich noch nicht die Kenntnisse dafür habe. Ich bin aber zufrieden das es so ist weil ich auf dem Weg neue Funktionen oder Begriffe gelernt habe, die wir gerade nicht in Module lernen. Dies gibt mir immer Motivation etwas neues zu lernen um noch bessere und krassere Projekte zu machen.




## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
2. Quiz master(ähnlich wie "wer wird Millionär") 1 frage 4 antwortmöglichkeiten, mit jeder richtigen antwort bekommt man punkte, bei falsch direkt zum anfang. Die fragen sollen in einer random reihenfolge kommen.

## 28.8.2026
Heute habe ich angefangen mit meinen Projekt Quiz Masters. Zuerst habe ich am Titel gearbeitet und wollte was spezielles erstellen, ich habe dann versucht es mit der ASCII Art Technik machen was auch funktionierte aber erstens sehr aufwändig war und es schwer war sie zu bewegen. Darum habe ich dann wie im Code zusehen die Normale Art genommen und es dann so eingebaut. Als nächstes habe ich 4 fragen mit einer variable gespeichert, doch später habe ich von ChatGPT erfahren das Arrays dafür besser geeingnet sind, weil sie mehrere Elemente mit einem Wort speichern können. Der nächste Schritt war das diese 4 Fragen in einer zufälligen Reihenfolge kommen, also gerade das es beim Start auch zufällig kommen bis jetzt. Am Ende habe ich dann noch eingefügt, dass man unter der Frage seine Antwort schreiben kann doch dies hat noch keine richtige Funktion.



## 6.9.2026

- [x]  Die Funktion auf die Fragen antworten zu können, also zu jeder Frage die Richtige Antwort hinzufügen.
- [x]  Nach einer richtigen Antwort soll die nächste zufällige frage kommen
- [x]  Nach einer richtigen Antwort soll der Benutzer punkte bekommen (z.B +1) und falls ich noch Zeit habe einen EndScore.

✍️ Heute habe ich zu meinen Quiz-fragen Antwort Möglichkeiten geaddet, sowie das jede Antwort zu der richtigen frage gehört. Ich habe das mit dem Index gemacht, also das die fragen und antworten die gleiche Index Nummer haben. Dann habe ich das alles in eine do...while schleiche reingetan damit nach der Antwort die nächste frage kommt und ein Score System gemacht, dass nach jeder richtigen Antwort man + 1 Score bekommt und wenn man falsch hat steht dort der Endscore. Am Ende habe ich noch mehr Fragen hinzufügt und die Positonen von den fragen verbessert.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 11.9.2026

- [X] Gleiche fragen dürfen nicht nacheinander kommen.
- [X] Einen Titelscreen mit dem Titel "Quiz Masters"
- [X] *Input* mit dem man zum Quiz kommt
- [X] Besondere Texte mit einer anderen Farbe machen
- [x] Ein Text der nach dem *Input* einen loading screen macht mit Text Animation (type in animation) bevor das Quiz startet.
- [x] Die Möglichkeit mit Zahlen zu antworten
      
 HA:
- [X] Ich möchte generell mehr Allgemein Wissen Fragen einfügen und noch eine Animation (type in animation) für die Fragen machen


Heute habe ich eine variable gemacht die, die letzte Frage merkt und anschliessend habe ich gemacht, dass die gleichen Fragen nicht nacheinander kommen. Dann habe ich einen Titelscreen gemacht bei dem man wählen kann ob man spielen will oder Verlassen. Ich habe gelernt wie man texte verschiedene farben geben kann und habe sie angewendet. Zwischen Titelscreen und dem Quiz habe ich einen Loading screen  mit animation gemacht. Ich habe gemacht, dass es keine rolle mehr spielt ob man gross oder klein schreibt und bei einer frage habe ich gemacht das man auch mit einer Zahl antworten kann. 

## 18.9.2026

- [x] Effekt nach dem man eine Antwort richtig hat (mit . oder # )
- [x] Nach 10 punkte kommt kommt ein spezielles event


Heute habe ich die letzten fein schliffe vom Projekt gemacht. Also ich habe gemacht das der Text der Fragen automatisch zentriert wird, dann ein Effekt nach dem man eine Frage richtig hat mit einem Smiley. Dann im letzten Arbeitspaket habe ich ein mini Event eingebaut das nach 10 punkten ausgeführt wird.











