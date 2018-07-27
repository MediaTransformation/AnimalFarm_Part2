using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interaktionen mit Türen. 
/// </summary>
public class DoorClick : MonoBehaviour
{
    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    public GameObject obj, player;
    private bool looking;

    public Animator animator;

    public bool open;
    public bool close;
    public bool isOpen;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist vor allem die Initialisierung der Variablen Player. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird.
    //Hervorzuheben ist hier, dass der Animator in diesem Fall beim Start ausgeschaltet werden muss, da er sonst automatisch abspielt. 
    //Das liegt daran, dass es nur zwei mögliche Situationen gibt: Öffnen und schließen. Sobald das Spiel beginnt, wird in die erste Situation geleitet. 
    //Um das zu umgehen, wird der Animator ausgeschaltet. 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator.enabled = false;
        //open = false;
        //close = false;
        looking = false;
        //isOpen = false;
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
                //Der Animator wird in jedem Fall einzeln aktiviert. Je nachdem, ob die Tür offen oder geschlossen ist, tritt ein anderer Fall ein.
                //Geregelt ist das Ganze mit Booleans.
                if (isOpen == false)
                {
                    animator.enabled = true;
                    open = true;
                    close = false;
                    isOpen = true;
                }
                else if (isOpen == true)
                {
                    animator.enabled = true;
                    close = true;
                    open = false;
                    isOpen = false;
                }

                //Im Animator sind die Übergänge innerhalb der Animation mit Booleans organisiert. Wenn in den oberen if-Statements die Variablen gesetzt werden, 
                //wird im Animator die entsprechende Variable aktiviert und die Animation ausgeführt. 
                if (open == true)
                {
                    animator.SetBool("open", true);
                    animator.SetBool("close", false);
                }
                if (close == true)
                {
                    animator.SetBool("close", true);
                    animator.SetBool("open", false);
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
