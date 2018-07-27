using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

/// <summary>
/// Script für das Abspielen der Audiodateien der Farmschilder.
/// </summary>
public class SoundFiles : MonoBehaviour
{
    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht.
    public GameObject obj, player;
    private bool looking;
    public AudioClip myclip;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist vor allem die Initialisierung der Variablen Player. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird. 
    //Das Einbinden der Audiodateien ist hier anders als in den anderen Scripts. Dies ist von Julian Kamphausen realisiert worden und ist lediglich ein anderer Weg. 
    void Start()
    {
        looking = false;
        player = GameObject.FindGameObjectWithTag("Player");
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.myclip = GetComponent<AudioClip>();
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
                //Hier wird auf Tastendruck die hinterlegte Audiodatei abgespielt. 
                this.GetComponent<AudioSource>().Play();
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
