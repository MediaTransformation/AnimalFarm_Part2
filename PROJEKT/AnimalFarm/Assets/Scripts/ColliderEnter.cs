using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Trigger für die 2. Animation (Rede des Schweins).
/// Wenn der Spieler den Collider berührt, wird die Variable "speachReady" wahr und die Rede beginnt (siehe dazu Script "SceneTrigger2").
/// </summary>
public class ColliderEnter : MonoBehaviour
{

    public static bool speachReady;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enter" && SceneTrigger2.ready == true)
        {
            speachReady = true;
        }
    }
}
