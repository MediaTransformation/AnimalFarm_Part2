using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

/// <summary>
/// Aufnahme der Medizinflasche.
/// Im Projekt gibt es zwei Flaschen. Die Testflasche steht auf dem Gelände, die Flasche ist am Player, sodass es nach der Aufnahme aussieht, als würde man sie tragen. 
/// </summary>
public class PickUp : MonoBehaviour
{

    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    public GameObject Flasche, Testflasche, player;
    private bool looking;
    public static bool carry;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist vor allem die Initialisierung der Variablen Player und Flasche. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird. Da eine der Flaschen am Player hängt, muss diese auch neu zugeordnet werden. 
    //Ausserdem werden hier die Objekte Flasche und Testflasche deaktiviert bzw aktiviert. So wird nur jeweils eine der Flaschen angezeigt. 
    //Zu Anfang wird die Testflasche aktiviert und die Flasche deaktiviert. 
    void Start()
    {
        looking = false;
        carry = false;
        player = GameObject.FindGameObjectWithTag("Player");
        Flasche = GameObject.Find("Flasche");
        Testflasche.SetActive(true);
        Flasche.SetActive(false);
    }

    void Update()
    {

        if (looking)
        {
            //Da wir zwei unterschiedliche Eingabegeräte haben (Controller und Tastatur/Maus), muss der Input unterschiedlich ablaufen. 
            //GetButtonDown() ist für die Maustaste und GetKeyDown() für eine Taste an einem Controller. Hierbei ist es egal, was es für ein Controller ist. 
            //Wichtig ist dabei nur die Tastenbelegung (Button 0), die bei vielen Controllern unterschiedlich ist. 
            if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                //Beim Klick auf die Testflasche wird diese deaktiviert und die Flasche am Player aktiviert. 
                //Die Variable "carry" ist notwendig, um die Funktion des SceneTriggers auszulösen. 
                Testflasche.SetActive(false);
                Flasche.SetActive(true);
                carry = true;
            }
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

