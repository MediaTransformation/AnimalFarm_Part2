using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController2 : MonoBehaviour
{

    public GameObject obj, player;
    private bool looking;
    public float minDistance = 10.0f;
    private float distance;

    public BunnyNew bunny;
    public BunnyJump b_jump;
    public bool jump;

    public AudioClip welcomeClip;
    public AudioClip medizinSearch;
    public AudioClip medizinDrop;

    public enum jumpstate {welcome, medizin};
    jumpstate state;

    // Use this for initialization
    void Start()
    {
        looking = false;

        bunny = GetComponent<BunnyNew>();
        b_jump = GetComponent<BunnyJump>();
        jump = false;
        b_jump.enabled = false;
     
        state = jumpstate.welcome;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, obj.transform.position);

        if (looking)
        {
            if (distance <= minDistance)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    if(jump == false) 
                    {
                        bunny.enabled = false;
                        b_jump.enabled = true;
                        jump = true;

                        if (state == jumpstate.welcome)
                        {
                            GetComponent<AudioSource>().PlayOneShot(welcomeClip);
                            state = jumpstate.medizin;
                        }
                        else if (state == jumpstate.medizin)
                        {
                            GetComponent<AudioSource>().PlayOneShot(medizinSearch);
                            //state = jumpstate.medizin;
                        }
                        else if (SceneTrigger.drop == true)
                        {
                            GetComponent<AudioSource>().PlayOneShot(medizinDrop);
                        }

                    } else
                    {
                        bunny.enabled = true;
                        b_jump.enabled = false;
                        jump = false;
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

