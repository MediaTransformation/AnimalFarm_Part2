using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger2 : MonoBehaviour {
	//Schwatzwutz Rede mit allen Tieren usw

    
	public PlayableDirector schwatzwutzShout;
    public PlayableDirector scene2;
    public GameObject schwatzwutz, timeline;

	public static bool ready;
    public static bool end;

	// Use this for initialization
	void Start () {
		ready = false;
        end = false;
		//jump.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (NightDaySwitch.anim2ready == true)
        {
            NightDaySwitch.anim2ready = false;
            StartCoroutine(shout());
            //schwatzwutzShout = schwatzwutz.GetComponent<PlayableDirector>();
            //schwatzwutzShout.Play();
            //NightDaySwitch.anim2ready = false;
        }

        if (ColliderEnter.speachReady == true)
        {
            //schwatzwutzShout.Stop();
            //ready = true;
            ColliderEnter.speachReady = false;
            scene2 = timeline.GetComponent<PlayableDirector>();
            scene2.Play();
            end = true;
        }

        /*if (ready == true)
        {
            print("Go!");
            //StartCoroutine(Scene2());
            scene2 = timeline.GetComponent<PlayableDirector>();
            scene2.Play();
        }*/


/*		if(Input.GetKeyDown(KeyCode.Space)) {
			//Schwatzwutz jump and speak
			director = timeline.GetComponent<PlayableDirector>();

			if(ready == true) {
				director.Play();
				ready = false;
			} else {
				director.Stop();
				ready = true;
			}

		}*/
	}

    IEnumerator shout()
    {
        yield return new WaitForSeconds(10);
        schwatzwutzShout = schwatzwutz.GetComponent<PlayableDirector>();
        schwatzwutzShout.Play();
        yield return new WaitForSeconds(10);
        ready = true;

        /*if (ColliderEnter.speachReady == true)
        {
            //schwatzwutzShout.Stop();
            NightDaySwitch.anim2ready = false;
            ready = true;
        }*/
    }

    IEnumerator Scene2()
    {    
        yield return new WaitForSeconds(0);
        scene2 = timeline.GetComponent<PlayableDirector>();
        scene2.Play();
    }



}
