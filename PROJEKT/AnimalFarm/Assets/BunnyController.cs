using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour
{

    public BunnyNew bunny;
    public BunnyJump b_jump;
    public bool jump;

    // Use this for initialization
    void Start()
    {
        bunny = GetComponent<BunnyNew>();
        b_jump = GetComponent<BunnyJump>();
        jump = false;
        b_jump.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bunny.enabled = false;
            jump = true;

        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            bunny.enabled = true;
        }

        if (jump == true)
        {
            b_jump.enabled = true;
        }
    }
}