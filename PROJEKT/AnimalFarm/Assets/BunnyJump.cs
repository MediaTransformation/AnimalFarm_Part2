using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyJump : MonoBehaviour
{

    public BunnyNew bunny;
    public bool jump;
    public float height = 5.5f;

    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");
        speech();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = (this.transform.position - Player.transform.position).normalized + Player.transform.position;
        this.transform.position = new Vector3(newPos.x + 1, newPos.y, newPos.z);

    }

    void speech()
    {
        if (!SceneTrigger.boxerGone)
        {
            print("Look, Boxer's sick");
        }
    }
}
