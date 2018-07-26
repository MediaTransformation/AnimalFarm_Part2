# AnimalFarm_Part2


In diesem Repository befindet sich der zweite Teil des Virtual Reality Projektes "Animal Farm", welches im Rahmen des Kurses "Media Transformation" im Sommersemester 2018 an der Universität zu Köln erarbeitet wurde. Der Stand des vorangegangenen Semesters wurde kontinuierlich erweitert und die bestehenden Funktionen ausgebaut und neue Elemente implementiert.
In diesem Semester wurde der Fokus des vorherigen Semesters, der auf der Modellierung der diegetischen Erzählwelt lag, auf die Animation sowie Narration der Textgrundlage "Die Farm der Tiere" von George Orwell ausgeweitet. 

Der Spieler kann beim Rundgang auf dem Farmgelände mit vielen Objekten interagieren und wird dadurch interaktiv in die gewählte Geschichte eingeführt und eingebunden.Im folgenden werden die, in den letzten zwei Semestern erarbeiteten, Funktionen der Virtual Reality Anwendung kurz dargelegt und erläutert.


Erzählerhase: Der Erzählerhase wurde so programmiert, dass er dem Spieler folgt und immer an seiner Seite ist. Wenn man ihn anklickt, springt er ins Blickfeld des Spielers und es werden verschiedene Audiosequenzen abgespielt. Dabei fungiert er auch als Hilfestellung, wenn der Spieler nicht weiter weiß. 

Schilder: Die Schilder die auf dem Famrgelände, meist vor Gebäuden, stehen geben dem Spieler, beim Klicken auf diese, mithilfe einer Audiosequenz Auskunft über das jeweilige Gebäude und etwas narrativen Kontext.

Gebäude: Die Gebäude können betreten werden, die Türen sind animiert und öffnen/schließen sich beim Klicken auf diese.

Szene 1: Die erste animierte Szene umschließt den ersten Teil des neunten Kapitels von "Die Farm der Tiere". Diese wird getriggert, wenn der Spieler eine Medizinflasche im Stall aufhebt (durch klicken) und diese Boxer (Pferd im Stall) übergibt. Nachdem der Spieler die Flasche übergeben hat wird die animierte Szene abgespielt und er kann nicht ins Geschehen eingreifen, er ist nur Zuschauer in diesem Moment.

Szene 2: Die zweite animierte Szene umschließt den zweiten Teil des neunten Kapitels. Diese wird nach Ablauf einer bestimmten Zeit nach Ende der ersten Szene getriggert. Beide Szenen sind dazu da, um dem Spieler einen gewählten Ausschnitt der Geschichte George Orwells zugänglich und erfahrbar zu machen.

Tag/Nacht Wechsel und Gebote an der Scheune: Zeitgleich mit dem Trigger der zweiten Szene wird von einer Tagesatmosphäre in eine Nachtatmosphäre gewechselt um einen Zeitsprung zu suggerieren. Damit Verbunden ist eine Änderung der Textur an der Seite der Scheune, auf die der Hase ebenfalls mit einer Audiosequenz hinweist.

Easteregg: Bei ersten Tests zur Animation und gekoppelten Tonsequenzen wurde der Brunnen vor dem Farmgebäude animiert und mit einem "Huch" Sound versehen. Dies ist als kleines Easteregg auch in die finale Version mit übernommen worden.

Farbschema: Die Farben in denen die VR Anwendung gehalten ist basieren auf einem eigens erstellten Farbschema, welches sich an Propagandaplakaten vergangener Zeiten orientiert. Die Hauptfarben sind rot, schwarz und beige/weiß.


Unser Hauptziel war es, unseren eigenen Stil zu verwirklichen und dafür alles selber zu modellieren, zu gestalten und zu animieren um somit so wenig wie möglich auf schon bestehende Assets zurück greifen zu müssen und eine in sich stimmende virtuelle Welt zu erschaffen. Dafür hat jedes Gruppenmitglied seinen Beitrag in verschiedenen Bereichen geleistet, es folgt eine kurze Auflistung der Aufgabenbereiche der einzelnen Gruppenmitglieder, um einen Überblick über unsere Gruppenarbeit in den letzten zwei Semestern zu verschaffen.

Vera: 
      
      - Modelle: Scheune, Farmhaus, Stall, Steinwagen, Abdeckerwagen
      
      - Porgrammierung (Allgemein): Custom-MouseLook für Windows-Version, Custom-Spieler-Bewegung (va für VR wichtig), Tag/Nacht-Wechsel, Player-Controller (Objekt nach Plattform), Beenden der Pc-Version durch ESC-Taste
      
      - Programmierung (Szene): Audiosequenz durch Anklicken (Schilder, Boxer, Hase), Szenen-Trigger (Szene1, Szene 1.5 und 2, hüpfender Brunnen), Interaktion mit Objekten (Türen, Flasche), Hasen-Controller (springt zum Sprechen nach vorne und zurück an seinen Platz)
      
      - Animation: Szene 1 (Boxer wird abtransportiert), Szene 1.5 (Schwatzwutz ruft zur Rede), Szene 2 (Rede über Boxers Tod), hüpfender Brunnen --> alles inklusive Sounddateien, implementiert über "Timeline"
      fallende Whiskeykisten, Wolkenbewegung
      
      - Development: Icon und Splash-Image von Pc- und Android-Version, Erstellung der ausführbaren Dateien (exe-Datei und Android-App)
      
      - Sonstiges:  Erstellung des Terrains, externe Asset-Implementierung (VR-Komponenten, Schlachter, zusätzliche Tiere, Brunnen, Heu, Zaun), Custom-Player (Position Kamera, Bewegungsmöglichkeit, "Körper") 

Anja: 

      - Modelle: Hase (Erzähler), Pferde (Boxer jung/alt), Schweine (Napoleon, Schwatzwutz, Standard-Schwein),Esel,  Ziege, Zauntor am Ausgang der Farm, Berge die das Terrain umranden
      
      - Partikelsystem des Farmgrounds (Staub)
      
      - Skybox Design (Tag/Nacht)


Vivi:

    - Modelle: Bäume, Büsche, Gräser und Felsen, Whiskeyboxen, kaputte Mühle + Mühlenrad, Medizinflasche, Beschilderung, Wolken, Farmhaustisch, Lampen/Laternen, 

      - Beleuchtung der Farm: Lichteinstellungen der Laternen mit passenden Partikelsystemen die Glühwürmchen darstellen sollen
      
      - Erstellen des Dialogskripts für die Vertonung der ausgewählten Szenen (auf Basis der Buchvorlage), sowie Texte für die Vertonung der Schilder und des Erzählerhasen (alles selbst gesprochen)
      
      - Vertonung: Audiosequenzen des Hasen und der zwei implementieren, animierten Szenen, sowie der Schilder und einem Easter Egg (Brunnen) ( alles selbst gesprochen)
      
      - Musik:  Hintergrundmusik die dauerhaft zu hören ist (eigenhändig eingespielt als Cover von Yann Tiersens "Le Moulin")
      
      - Beschriftung der Objekte: Schilder, Abdeckerwagen, die Gebote auf der Scheune
      
      - Erstellen des 'Read me'
      
      
Modelliert wurde mit 3DSMax, Vertonung und Musik mit Audacity und GarageBand, entwickelt in Unity und programmiert mithilfe von Visual Studio.
      
