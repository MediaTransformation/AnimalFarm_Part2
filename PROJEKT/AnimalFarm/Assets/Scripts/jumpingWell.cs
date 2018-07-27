using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// Hüpfender Brunnen.
/// Dies war anfangs nur ein Testobjekt der Timeline für die großen Animationen. Als Easteregg wurde das schlussendlich ins fertige Projekt übernommen.
/// Berührt der Player den Collider des Objektes, wird die Timeline ausgeführt. 
/// Die Funktion "OnTriggerEnter()" ist eine vorgefertigte Funktion von Unity. 
/// </summary>
public class jumpingWell : MonoBehaviour
{

    public PlayableDirector director;
    public GameObject obj, player, well;
    public bool jumpW;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            director = well.GetComponent<PlayableDirector>();
            if (director != null)
            {
                director.Play();
            }
        }
    }
}
