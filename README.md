# AnimalFarm_Part2

Gruppenmitglieder: Vera Malieske, Anja Wodzinski, Viviane Linne

In diesem Repository befindet sich das Virtual Reality Projekt "Animal Farm", welches im Rahmen des Kurses "Media Transformation" über die Dauer von zwei Semestern (Winter- und Sommersemester 2017/18)  an der Universität zu Köln erarbeitet wurde. Der Stand des vorangegangenen Semesters wurde kontinuierlich erweitert und die bestehenden Funktionen ausgebaut und neue Elemente implementiert.
Während der Fokus des vorigen Semesters auf der Modellierung der diegetischen Welt gerichtet war, lag das Hauptaugenmerk dieses Semesters auf der Animation sowie der Narration der Textgrundlage "Die Farm der Tiere" von George Orwell. 

Der Spieler kann beim Rundgang auf dem Farmgelände mit vielen Objekten interagieren und wird dadurch interaktiv in die Geschichte eingeführt und eingebunden. Im Folgenden werden die, in den letzten zwei Semestern erarbeiteten, Funktionen der Virtual Reality Anwendung kurz dargelegt und erläutert.


Erzählerhase: Der Erzählerhase wurde so programmiert, dass er dem Spieler folgt und immer an seiner Seite ist. Wenn man ihn anklickt, springt er ins Blickfeld des Spielers und es werden verschiedene Audiosequenzen abgespielt. Dabei fungiert er auch als Hilfestellung, wenn der Spieler nicht weiterweiß. 

Schilder: Die Schilder, die auf dem Farmgelände - meist vor Gebäuden - stehen, geben dem Spieler beim Anwählen mithilfe einer Audiosequenz Auskunft über das jeweilige Gebäude und etwas narrativen Kontext.

Gebäude: Die Gebäude können betreten werden, die Türen sind animiert und öffnen/schließen sich beim Klicken auf diese.

Animationen: Die meisten der Animationen in Animal Farm wurden einzeln erstellt und über die Timeline organisiert. Die Timeline konnte daraufhin über Scripte gestartet werden. Dies hatte den Vorteil, dass jeweils eine komplette Animationssequenz mit Sounddateien erstellt werden konnte.

Szene 1: Die erste animierte Szene umfasst die Eingangsszene des neunten Kapitels von "Die Farm der Tiere". Diese wird getriggert, wenn der Spieler durch Anklicken eine Medizinflasche im Stall aufhebt und diese Boxer (Pferd im Stall) übergibt. Nachdem der Spieler die Flasche übergeben hat, wird die animierte Szene abgespielt und er kann nicht ins Geschehen eingreifen, sondern verbleibt für den Moment in einer Zuschauerrolle.

Szene 2: Die zweite animierte Szene gibt den zweiten Teil des neunten Kapitels wieder und besteht aus zwei Timelines. Die Erste wird im Anschluss an einen Tag/Nacht-Wechsel getriggert und ist die Einleitung zur eigentlichen Szene, die jedoch erst abgespielt wird, wenn der Spieler einen bestimmten Bereich in unmittelbarer Nähe des geschehens betritt. 

Beide Szenen sind dazu da, um dem Spieler den gewählten Ausschnitt der Geschichte George Orwells zugänglich und erfahrbar zu machen.

Tag/Nacht Wechsel und Gebote an der Scheune: Am Ende der ersten Szene wird von einer Tagesatmosphäre in eine Nachtatmosphäre gewechselt, um einen Zeitsprung zu suggerieren. Ist die Nacht vorbei, wird der erste Teil der 2. Szene angestoßen (Schwatzwutz ruft zur Rede). Mit dem Wechsel verbunden ist eine Änderung der Textur an der Seite der Scheune (Commandments), auf die der Hase ebenfalls mit einer Audiosequenz hinweist.

Easteregg: Bei ersten Tests zur Animation und gekoppelten Tonsequenzen wurde der Brunnen vor dem Farmgebäude animiert und mit einem "Huch"-Sound versehen. Dies ist als kleines Easteregg auch in die finale Version mit übernommen worden.

Farbschema: Die Farben, in denen die VR Anwendung gehalten ist, basieren auf einem eigens erstellten Farbschema, welches sich an Propagandaplakaten vergangener Zeiten orientiert. Die Hauptfarben sind rot, schwarz und beige/weiß.

Plattformen: Animal Farm kann entweder als PC-Version oder Android-App gestartet werden. Beide Dateien befinden sich im Projektordner. Die exe-Datei liegt im Ordner "AnimalFarmGame" und kann über einen Doppelklick aufgerufen werden. Gespielt wird entweder mit den Richtungstasten oder WASD, sowie der Maus. 
Die Android-apk befindet sich im Ordner "AnimalFarmAndroid". Hier wird für die Bewegung auf der Animal Farm ein Controller vorausgesetzt. Aktionen werden mit dem Button 0 (Null) ausgelöst. Auf einem PS4-Controller entspricht dies der Taste "X", auf einem Bluetooth- oder XBOX-Controller ist die Tastenbelegung in der jeweiligen Anleitung nachzulesen. 

Unser Hauptziel war es, unseren eigenen Stil zu verwirklichen und dafür alles selber zu modellieren, zu gestalten und zu animieren, um somit so wenig wie möglich auf schon bestehende Assets zurück greifen zu müssen und eine in sich stimmige virtuelle Welt zu erschaffen. Dafür hat jedes Gruppenmitglied seinen Beitrag in verschiedenen Bereichen geleistet. Es folgt eine kurze Auflistung der Aufgabenbereiche der einzelnen Gruppenmitglieder, um einen Überblick über unsere Gruppenarbeit in den letzten zwei Semestern zu verschaffen.

Vera: 
      
      - Modelle: Scheune, Farmhaus, Stall, Steinwagen, Abdeckerwagen, (Pilze, Heuballen, Nadelbaum)
      
      - Programmierung (Allgemein): 
      Custom-MouseLook für Windows-Version, Custom-Spieler-Bewegung (Bewegung in Blickrichtung),  Player-Controller (Player nach Plattform),
      einmaliger Tag/Nacht-Wechsel, Beenden der Pc-Version durch ESC-Taste
      
      - Programmierung (Szene): 
      Audiosequenz durch Anklicken (Schilder, Boxer, Hase), Szenen-Trigger (Szene1, Szene 1.5 und 2, hüpfender Brunnen), 
      Interaktion mit Objekten (Türen, Flasche), Hasen-Controller (springt zum Sprechen nach vorne und zurück an seinen Platz), 
      
      - Animation: Szene 1 (Boxer wird abtransportiert), Szene 2.1 (Schwatzwutz ruft zur Rede), Szene 2.2 (Rede über Boxers Tod), hüpfender Brunnen --> alles inklusive Sounddateien, implementiert über "Timeline"
      fallende Whiskeykisten, Wolkenbewegung
      
      - Development: Icon und Splash-Image von PC- und Android-Version, Erstellung der ausführbaren Dateien (exe-Datei und Android-App), Einstellung der verschiedenen Settings
      
      - Sonstiges:  Erstellung des Terrains, externe Asset-Implementierung (VR-Komponenten, Schlachter, zusätzliche Tiere, Brunnen, Zaun), Custom-Player (Position Kamera, Bewegungsmöglichkeit, "Körper"), Überblick über Arbeitsschritte und Projektentwicklung
      
      - Kommentieren der Scripte

Anja: 

      - Modelle: Hase (Erzähler), Pferde (Boxer jung/alt, Kleeblatt), Schweine (Napoleon, Schwatzwutz, Standard-Schwein),Esel, Ziege, Zauntor am Ausgang der Farm, Berge die das Terrain umranden
      
      - Partikelsystem des Farmgrounds (Staub)
      
      - Skybox Design (Tag/Nacht)


Vivi:

    - Modelle: Bäume, Büsche, Gräser und Felsen, Whiskeyboxen, kaputte Mühle + Mühlenrad, Medizinflasche, Beschilderung, Wolken, Farmhaustisch, Lampen/Laternen

      - Beleuchtung der Farm: Lichteinstellungen der Laternen mit passenden Partikelsystemen, die Glühwürmchen darstellen sollen
      
      - Erstellen des Dialogskripts für die Vertonung der ausgewählten Szenen (auf Basis der Buchvorlage), sowie Texte für die Vertonung der Schilder und des Erzählerhasen
      
      - Vertonung: Audiosequenzen des Hasen und der zwei implementieren, animierten Szenen, sowie der Schilder und einem EasterEgg (Brunnen) ( alles selbst gesprochen)
      
      - Musik:  Hintergrundmusik, die dauerhaft zu hören ist (eigenhändig eingespielt als Cover von Yann Tiersens "Le Moulin")
      
      - Beschriftung der Objekte: Schilder, Abdeckerwagen, die Gebote auf der Scheune
      
      - Erstellen des 'Read me'
      
      
Modelliert wurde mit 3DSMax, Vertonung und Musik mit Audacity und GarageBand, entwickelt in Unity und programmiert mithilfe von Visual Studio.
      
