using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Verfolgungsscript des Hasen.
/// Dies wurde von Julian Kamphausen geschrieben, der im ersten Semester des Kurses in dieser Gruppe war. 
/// </summary>
public class BunnyNew : MonoBehaviour
{

    public GameObject Player;
    public float speed = 1.0f;
    public float MinimumDistance = 5.5f;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        doTheCreepyFollow();
        doTheCreepyTurn();
    }

    void doTheCreepyTurn()
    {
        this.transform.LookAt(Player.transform);
        this.transform.Rotate(new Vector3(0, 180, 0));
        this.transform.eulerAngles = new Vector3(-90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
    }

    void doTheCreepyFollow()
    {

        Vector3 newPos = (this.transform.position - Player.transform.position).normalized * MinimumDistance + Player.transform.position;
        this.transform.position = new Vector3(newPos.x, 100.07f, newPos.z);
    }


}

