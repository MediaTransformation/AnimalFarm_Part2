using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller, um den richtigen Player auszuwählen. 
/// VR und Tastatur/Maus-Steuerung haben jeweils andere Voraussetzungen, deswegen muss vor der Anwendung entschieden werden, welches Objekt genutzt wird, je nach Plattform. 
/// Vor allem liegt das am RigidBody, der für die Bewegung am Pc benötigt wird, jedoch innerhalb der VR-App zu Komplikationen führt. 
/// </summary>
public class PlayerController : MonoBehaviour
{
    //Die nötigen Variablen werden deklariert. Wichtig sind hierbei die beiden GameObjects der beiden Player. 
    public GameObject playerPc;
    public GameObject playerAndroid;

    //Im Gegensatz zu der Funktion Start wird Awake aufgerufen, bevor das Spiel startet. Um Fehlermeldungen über doppelte Player-Objekte zu vermeiden, ist dies wichtig. 
    void Awake()
    {

        //Plattformbedingte Compilation
        //Je nach Plattform wird das benötigte Objekt aktiviert und das überflüssige deaktiviert. Außerdem wird dem aktiven Objekt das Tag "Player" zugewiesen. 
        //Mit diesem Tag kann das Objekt von den anderen Scripten gefunden werden. 
/*#if UNITY_EDITOR
        playerPc.SetActive(true);
        playerAndroid.SetActive(false);
        playerPc.gameObject.tag = "Player";
#endif*/

#if UNITY_STANDALONE_WIN
        playerPc.SetActive(true);
        playerAndroid.SetActive(false);
        playerPc.gameObject.tag = "Player";
#endif

#if UNITY_ANDROID
        Debug.Log("Android");
        playerPc.SetActive(false);
        playerAndroid.SetActive(true);
        playerAndroid.gameObject.tag = "Player";
#endif


    }

}
