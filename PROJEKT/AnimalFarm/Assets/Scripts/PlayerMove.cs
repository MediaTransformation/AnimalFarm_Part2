using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Einbindung der CharacterController-Komponente.
[RequireComponent(typeof(CharacterController))]

/// <summary>
/// Custom-Bewegung des Players.
/// Da durch die VR-App eine andere Art der Fortbewegung nötig war, konnte nicht die Unity-eigene Bewegung des First-Person-Controller genommen werden.
/// </summary>
public class PlayerMove : MonoBehaviour
{
    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    //Wichtig hier ist vor allem die Transform-Komponente der vrCamera, das Einbinden des CharacterController und die statischen Vector-Strukte. 
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

    //Initalisierung der erforderlichen Variablen.
    //Hier wird die Variable vrCamera mit der MainCamera des Projektes belegt. Hierfür muss die entsprechende Camera mit dem Tag "Main" belegt werden. 
    //Auch hier die Initialisierung der Variablen Player. Das Gameobject mit dem zugewiesenen Tag "Player" wird im gesamten Projekt gesucht.
    //Damit ist sichergestellt, dass immer der richtige Player gefunden wird.
    void Start()
    {
        myCC = gameObject.GetComponent<CharacterController>();
        vrCamera = Camera.main.transform;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Die Werte des Eingabegerätes (in diesem Fall der VR-Brille über die Achsen -->getAxis) werden im Vector "position" gespeichert.
    //Mit der vorgegebenen Geschwindigkeit (speed) läuft der Player. Die neue Position wird daraufhin in einem neuen Vector gespeichert. 
    void Update()
    {
        position = vrCamera.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal"));
        myCC.SimpleMove(speed * position);

        Vector3 PlayerPos = (this.transform.position - Player.transform.position) + Player.transform.position;
        this.transform.position = new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z);
    }
}
