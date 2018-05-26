using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Test : MonoBehaviour
{

    private Transform vrCamera;
    public float speed = 3f;
    CharacterController myCC;

    public bool isWalking = false;
    public float jumpSpeed = 8.0F;
    bool isOpen;

    public bool movement;
    public GameObject Player;
    public static Vector3 PlayerPos;
    public static Vector3 position;

    // Use this for initialization
    void Start()
    {
        myCC = gameObject.GetComponent<CharacterController>();
        vrCamera = Camera.main.transform;
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        position = vrCamera.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal"));
        myCC.SimpleMove(speed * position);

        Vector3 PlayerPos = (this.transform.position - Player.transform.position) + Player.transform.position;
        this.transform.position = new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z);
    }
}
