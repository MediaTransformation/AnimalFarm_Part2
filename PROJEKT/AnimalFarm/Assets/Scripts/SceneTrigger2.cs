using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger2 : MonoBehaviour
{

    /// <summary>
    /// Schwatzwutz Rede mit allen Tieren
    /// In einer ersten Animation wird zur Rede gerufen. Sind alle Teilnehmer anwesend, wird die zweite Animation gestartet. 
    /// </summary>

    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    public PlayableDirector schwatzwutzShout;
    public PlayableDirector scene2;
    public GameObject schwatzwutz, timeline;

    public static bool ready;
    public static bool end;

    //Initalisierung der erforderlichen Variablen.
    void Start()
    {
        ready = false;
        end = false;
    }

    void Update()
    {

        //Hier wird auf die Variable des NightDaySwitch-Scriptes zugegriffen, um zu überprüfen, ob die erste Animation gestartet werden kann. Dies passiert, nach Tagesanbruch im Spiel. 
        if (NightDaySwitch.anim2ready == true)
        {
            //Um zu verhindern, dass die Szene erneut abgespielt wird, muss der Boolean wieder zurückgesetzt werden.
            //Danach wird eine Coroutine gestartet, die in unserem Fall vor allem dafür sorgt, dass die nachfolgenden Codezeilen erst nach einer bestimmten Zeit ausgeführt werden.  
            NightDaySwitch.anim2ready = false;
            StartCoroutine(shout());
        }

        //Berührt der Spieler den Collider (befindet sich im Spiel kurz vor den redenden Schweinen), wird die zweite Animation gestartet. 
        if (ColliderEnter.speachReady == true)
        {
            //Da hier keine zeitliche Verzögerung nötig ist, wird hier sofort die Timeline abgespielt. 
            ColliderEnter.speachReady = false;
            scene2 = timeline.GetComponent<PlayableDirector>();
            scene2.Play();
            end = true;
        }
    }

    IEnumerator shout()
    {
        //Hier wird 10 Sekunden gewartet, bevor die Timeline gestartet wird. Außerdem wird die Variable ready erst 10 Sekunden nach der Animation auf true gesetzt, 
        //um zu verhindern, dass die nächste Animation zu früh gestartet wird. 
        yield return new WaitForSeconds(10);
        schwatzwutzShout = schwatzwutz.GetComponent<PlayableDirector>();
        schwatzwutzShout.Play();
        yield return new WaitForSeconds(10);
        ready = true;
    }

}
