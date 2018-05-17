using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneTrigger : MonoBehaviour {

    public PlayableDirector director;
    public GameObject obj, player, timeline, Flasche;
    private bool looking;
    public static bool boxerGone;
    public float minDistance = 10.0f;
    private float distance;

    public AudioClip search;
    public AudioSource audio;

    // Use this for initialization
    void Start () {
        looking = false;
        boxerGone = false;
        audio = GetComponent<AudioSource>();
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

                        director = timeline.GetComponent<PlayableDirector>();
                        
                        if(director != null)
                        {
                            director.Play();
                            boxerGone = true;
                        }
                    } else {
                        audio.PlayOneShot(search, 0.7F);
                    }
                }
            }
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
