using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyJump : MonoBehaviour
{

    public BunnyNew bunny;
    public bool jump;
    public float height = 8.5f;

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

        this.transform.LookAt(Player.transform);
        //this.transform.Rotate (new Vector3 (0, 0, 0));
        this.transform.Rotate(new Vector3(0, 180, 0));
        this.transform.eulerAngles = new Vector3(-90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);

        Vector3 newPos = (this.transform.position - Player.transform.position).normalized + Player.transform.position;
        this.transform.position = new Vector3(newPos.x + 2, newPos.y + 1, newPos.z);

    }

    void speech()
    {
        if (!SceneTrigger.boxerGone)
        {
            print("Look, Boxer's sick");
        }
    }
}
