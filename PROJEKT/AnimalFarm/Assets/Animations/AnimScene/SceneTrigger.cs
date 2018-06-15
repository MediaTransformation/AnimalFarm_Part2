using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger : MonoBehaviour {

    public PlayableDirector director;
    public GameObject obj, player, timeline, Flasche, hase;
    private bool looking;
    public static bool boxerGone;
    public static bool drop;
    public float minDistance = 10.0f;
    private float distance;

    public AudioClip search;

    // Use this for initialization
    void Start () {
        looking = false;
        boxerGone = false;
        drop = false;


    }
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.transform.position, obj.transform.position);

        if (looking)
        {
            if (distance <= minDistance)
            {


                if (Input.GetButtonDown("Fire1"))
                {
                    if(PickUp.carry == true) {
                        //Schwatzwutz noch Dazu
                        //Boxer "Danke"

                        Flasche.SetActive(false);
                        drop = true;

                    } else {
                        GetComponent<AudioSource>().PlayOneShot(search, 0.7F);
                    }
                }
            }
        }

        if (ColliderEnter.colliderReady == 3)
        {
            director = timeline.GetComponent<PlayableDirector>();
            director.Play();
            boxerGone = true;
        }
    }

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
