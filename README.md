# dffFingeruebungCSharp
Aufgabe für die Bewerbung bei dff solutions 


Ich habe mich für eine Umsetzung in einer Windows Forms Anwendung entschieden. Der Grund dafür ist einfach der, dass ich damit am sichersten bin.

GUI
Die GUI ist sehr funktional gehalten. Die 9 auswählbaren Felder sind Buttons, welche auf Click das Symbol des Spielers, der am Zug ist, annehmen. Ist ein Spiel vorbei (durch Sieg oder Unentschieden) werden die Buttons deaktiviert und ein neuer Button taucht auf um das Spiel neu zu starten. 


Code
Der interessanteste Teil eines Tic Tac Toe Spiels ist natürlich die Überprüfung der Siegbedingung. In meiner Lösung habe ich quasi das Spielfeld in einer Button Liste abgebildet.
 
Jede Spalte und Zeile, sowie die beiden Diagonalen werden in Button Listen abgebildet. Der Liste „spielfeld“ werden die Listen der Reihen zugewiesen. Wird ein Button jetzt geklickt kann durch die Spielfeld Liste gelooped werden um jedes Element einer Reihe auf seinen Inhalt zu prüfen. Dadurch umgeht man eine hunderte Zeilen lange „If-Then“ Verkettung, die den Sieg ermittelt.


Einzelspieler Modus
„Je nach Ihren Fähigkeiten kann das Spiel für zwei Spieler sein, oder „Mensch gegen Maschine“
Ich habe mich für eine Umsetzung für zwei Spieler entschieden. Der Gründe dafür sind folgende:
Eine vernünftige KI übersteigt meine Fähigkeiten. Allerdings wäre das auch sehr witzlos für den Menschlichen Spieler, da das Spiel nur in einer Niederlage oder einem Unentschieden enden kann. Der Spielspaß ist also sehr gering.
Eine zweite Möglichkeit wäre ein Zufallsgenerator, der eines der freien Felder auswählt und befüllt. Dadurch ergibt sich jedoch ein weiteres Problem. Der Zufall würde dumme Entscheidungen treffen: 
Der Spieler hat zwei Kreuze platziert. Nur noch ein Kreuz dazwischen und er hat gewonnen. Der Computer ist dran und er platziert seinen Kreis in der gegenüberliegenden Ecke. Einfach so. Es hindert weder den Menschen am Gewinnen, noch hilft es dem Computer zu gewinnen.
Statistisch gesehen wären hier für den Menschen also nur ein Sieg oder ein Unentschieden möglich. Eine Niederlage ist sehr unwahrscheinlich. 
Es gibt also aus Game Design Gründen keinen Grund für einen Computer Gegner. 
Jetzt ist mir natürlich klar, dass Sie mit mir nicht Millionen an einem guten Tic Tac Toe Spiel verdienen wollen, und dass der Sinn der Aufgabe es war zu sehen, wie ich programmiere. Ich hoffe jedoch darauf, dass Sie durch meine Begründung gegen einen Einzelspieler auch sehen können, dass ich mich mit meinen Aufgaben auseinandersetze und versuche, nicht unnötig Ressourcen zu verschwenden.

