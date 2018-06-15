using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger2 : MonoBehaviour {
	//Schwatzwutz Rede mit allen Tieren usw

	public PlayableDirector director;
    public GameObject schwatzwutz, timeline;

	public bool ready;

	// Use this for initialization
	void Start () {
		ready = true;
		//jump.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (NightDaySwitch.night == true)
        {
            StartCoroutine(Scene2());

        }


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

    IEnumerator Scene2()
    {

        yield return new WaitForSeconds(90);
        director = timeline.GetComponent<PlayableDirector>();

        if (ColliderEnter.colliderReady == 1)
        {
            director.Play();
        }
        else
        {
            director.Stop();
        }
    }
}
