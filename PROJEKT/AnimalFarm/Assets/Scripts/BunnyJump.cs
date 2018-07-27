using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sprung des Hasens vor den Spieler.
/// </summary>
public class BunnyJump : MonoBehaviour
{
    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    public bool jump;
    public GameObject Player;

    //Initalisierung der erforderlichen Variablen.
    //Wichtig hier ist vor allem die Initialisierung der Variablen Player. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird. 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Hier wird der Hase zum Spieler gedreht und erhält eine neue Position, die sich an der des Spielers orientiert. Um einen Abstand zu gewinnen, wird zur x-und y-Position noch ein Wert addiert.
        //Dies ist eine abgewandelte Form des bereits vorhandenen Scripts "BunnyNew". 

        this.transform.LookAt(Player.transform);
        this.transform.Rotate(new Vector3(0, 180, 0));
        this.transform.eulerAngles = new Vector3(-90, this.transform.eulerAngles.y, this.transform.eulerAngles.z);

        Vector3 newPos = (this.transform.position - Player.transform.position).normalized + Player.transform.position;
        this.transform.position = new Vector3(newPos.x + 2, newPos.y + 1, newPos.z);

    }
}
