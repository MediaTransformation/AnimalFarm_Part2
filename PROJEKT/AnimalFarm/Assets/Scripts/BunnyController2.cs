using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller des Hasen.
/// Hier wird das Hervorspringen des Hasen organisiert. Bei einem Klick springt er vor den Player und spricht mit ihm. 
/// Bei erneutem Klick geht er wieder an seinen Platz. Dies ist durch das An- und Ausschalten der entsprechenden Scripte realisiert.
/// </summary>
public class BunnyController2 : MonoBehaviour
{
    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    //Hervorzuheben ist hier lediglich der Zustand "jumpstate", der dafür sorgt, dass der Hase den passenden Text sagen kann.

    public GameObject obj, player;
    private bool looking;
    private float distance;

    public BunnyNew bunny;
    public BunnyJump b_jump;
    public bool jump;

    public AudioClip welcomeClip;
    public AudioClip medizinSearch;
    public AudioClip medizinDrop;
    public AudioClip commandments;

    public enum jumpstate { welcome, medizin, commandments };
    public static jumpstate state;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist das Einbinden der beiden Scripte, die deaktiviert und aktiviert werden (BunnyNew und BunnyJump). 
    //Gleich zu Anfang wird der Jump mit der ersten Aussage des Hasen ausgeführt, um eine Einleitung in das Spiel zu erhalten. 
    void Start()
    {
        looking = false;
        player = GameObject.FindGameObjectWithTag("Player");
        bunny = GetComponent<BunnyNew>();
        b_jump = GetComponent<BunnyJump>();

        bunny.enabled = false;
        b_jump.enabled = true;
        jump = true;
        GetComponent<AudioSource>().PlayOneShot(welcomeClip);
        state = jumpstate.medizin;
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
                if (jump == false)
                {
                    //Wenn der Hase nicht vor dem Spieler ist, wird der Jump ausgeführt und je nach Situation die entsprechende Sounddatei abgespielt. 
                    bunny.enabled = false;
                    b_jump.enabled = true;
                    jump = true;

                    //Wenn der Spieler die Medizinflasche nicht in der Hand hat, fordert er ihn auf, nach ihr zu suchen. 
                    if (state == jumpstate.medizin && PickUp.carry == false)
                    {
                        GetComponent<AudioSource>().PlayOneShot(medizinSearch);
                    }
                    //Wenn die 2.Szene zu Ende gespielt wurde, erzählt der Hase, dass sich an der Scheunenwand etwas geändert hat. 
                    else if (SceneTrigger2.end == true)
                    {
                        GetComponent<AudioSource>().PlayOneShot(commandments);
                    }
                    else if (SceneTrigger2.end == false && state == jumpstate.medizin)
                    {
                        //Wenn der Spieler die Medizinflasche noch nicht abgegeben hat, aber in der Hand hält, sagt der Hase, wohin sie gebracht werden soll.
                        if (SceneTrigger.drop == false)
                        {
                            GetComponent<AudioSource>().PlayOneShot(medizinDrop);
                        }
                    }

                }
                //Um den Hasen wieder in seine Position zu bringen, muss er nochmals angeklickt werden.
                else
                {
                    bunny.enabled = true;
                    b_jump.enabled = false;
                    jump = false;
                }
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

