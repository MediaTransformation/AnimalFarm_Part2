using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

/// <summary>
/// Trigger der ersten Szene (Boxer wird vom Abdecker abgeholt)
/// Durch die Aufnahme und Übergabe der Medizinflasche wird die Animation gestartet. Alle Animationen mit Sounddateien sind über die Timeline umgesetzt. 
/// Dadurch kann das Abspielen von Sound- und Animationsdateien organisiert werden. 
/// </summary>
public class SceneTrigger : MonoBehaviour
{

    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    //Neben den normalen Variablentypen kann auch direkt auf Unity-Komponenten zugegriffen werden, wie AudioClip, PlayableDirector oder eben das GameObject. 
    public PlayableDirector director;
    public GameObject obj, player, timeline, hase;
    public GameObject Flasche;
    private bool looking;
    public static bool boxerGone;
    public static bool drop;

    public AudioClip search;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist vor allem die Initialisierung der Variablen Player und Flasche. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird. Da eine der Flaschen am Player hängt, muss diese auch neu zugeordnet werden. 
    void Start()
    {
        looking = false;
        boxerGone = false;
        drop = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Das Gameobject "Flasche" muss in diesem Fall innerhalb der Update-Funktion gesucht werden, da es beim Start des Spiels noch nicht aktiv ist und deshalb nicht gefunden wird. 
        Flasche = GameObject.Find("Flasche");

        if (looking)
        {
            //Da wir zwei unterschiedliche Eingabegeräte haben (Controller und Tastatur/Maus), muss der Input unterschiedlich ablaufen. 
            //GetButtonDown() ist für die Maustaste und GetKeyDown() für eine Taste an einem Controller. Hierbei ist es egal, was es für ein Controller ist. 
            //Wichtig ist dabei nur die Tastenbelegung (Button 0), die bei vielen Controllern unterschiedlich ist. 
            if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                //Hier wird die Variable "carry" aus dem PickUp-Script überprüft. Nur, wenn diese Variable wahr ist, wird der nachfolgende Code ausgeführt.
                if (PickUp.carry == true)
                {
                    //Wichtig hier ist nur, dass die Flasche deaktiviert wird (Erklärungen im PickUp-Script).
                    //Erklärungen zu der Variable des BunnyController gibt es ebenfalls im entsprechenden Script. 
                    //Die Variable "drop" wird benötigt, um die Übergabe der Flasche an das Pferd zu signalisieren.
                    Flasche.SetActive(false);
                    drop = true;
                    BunnyController2.state = BunnyController2.jumpstate.commandments;
                }
                else
                {
                    //Wenn die Variable "carry" (noch) nicht wahr ist, wird die Audiodatei abgespielt. Hierbei wird der Spieler nochmal daran erinnert, 
                    //dass er die Flasche suchen soll.
                    GetComponent<AudioSource>().PlayOneShot(search, 0.7F);
                }
            }
        }

        //Hier wird letztendlich die Animation abgespielt, wenn die Medizinflasche übergeben wurde. 
        //Um zu verhindern, dass sie wiederholt wird, wurde noch die Variable "boxerGone" eingeführt. 
        if (drop == true && boxerGone == false)
        {
            director = timeline.GetComponent<PlayableDirector>();
            director.Play();
            boxerGone = true;
            drop = false;
        }
    }

    //Dieser Teil findet sich in allen Scripten, die mit Objekt-Interaktionen zu tun haben. 
    //Hier wird die Variable initialisiert, die dafür verantwortlich ist, ob sich der Pointer über einem Objekt befindet. 
    //Nur, wenn das der Fall ist, kann die Interaktion ausgeführt werden. 
    //Die Funktionen OnGazeEnter(), OnGazeExit() und OnGazeTrigger() sind vorgefertigte Funktionen für die Cardboard-Implementierung. 
    #region IGvrGazeResponder implementation

    public void OnGazeEnter()
    {
        looking = true;
    }
    public void OnGazeExit()
    {
        looking = false;
    }
    public void OnGazeTrigger()
    {
        looking = true;

    }
    #endregion
}
