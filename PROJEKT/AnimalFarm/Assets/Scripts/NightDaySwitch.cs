using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller für den Tag/Nacht-Wechsel
/// Wir haben uns für einen einmaligen Wechsel entschieden, deswegen wird hier wieder die Coroutine verwendet. 
/// Neben der Skybox werden Licht und allgemeine Farben geändert. Außerdem wird der Text auf der Scheunenwand ausgewechselt. 
/// </summary>
public class NightDaySwitch : MonoBehaviour
{

    //Deklaration der wichtigsten Variablen. Hervorzuheben ist hier, dass nur static-Variablen von anderen Scripten genutzt werden können. 
    //Public-Variablen sind im Unity-Inspector sichtbar, private-Variablen nicht. 
    //Hier werden neben den "normalen" Variablen auch die Komponenten von Material, Texture, Light und Color deklariert.
    //Diese werden für die Änderungen benötigt. 
    public bool lightOn;
    public static bool anim2ready;
    public static bool night;
    public static bool nightend;
    public Light sun;
    public Material skyboxDay;
    public Material skyboxNight;

    public GameObject sign;
    public Texture commandment1;
    public Texture commandment2;

    public Color fullLight;
    public Color fullDark;

    //Zu Anfang werden die Komponenten für den "Tag-Modus" initialisiert. Hier wird auch die Anfangstextur der commandments auf der Scheunenwand festgelegt. 
    //Die Klasse "RenderSettings" beinhaltet die Werte für die visuellen Elemente der Szene. Auf diese muss zugegriffen werden, um die Skybox ändern zu können. 
    //Genauso ist es mit dem Licht. 
    void Start()
    {
        sun.enabled = true;
        RenderSettings.skybox = skyboxDay;
        RenderSettings.ambientLight = fullLight;
        sign.GetComponent<Renderer>().material.mainTexture = commandment1;
        lightOn = true;
        night = false;
        anim2ready = false;
        nightend = false;
    }

    void Update()
    {
        //Der erste Wechsel (Tag->Nacht) wird eingeleitet, wenn Boxer abgeholt wurde und es Tag ist. 
        //Die Variable nightend wurde nötig, um einen weiteren Wechsel zu vermeiden. 
        if (SceneTrigger.boxerGone == true && lightOn == true && nightend == false)
        {
            nightend = true;
            StartCoroutine(Switch1());

            //Der zweite Wechsel wird eingeleitet, wenn die erste Coroutine komplett durchgelaufen ist. 
        }
        else if (night == true)
        {
            night = false;
            StartCoroutine(Switch2());

        }

    }

    //Der Wechsel findet erst nach 250 Sekunden statt, sprich, nachdem die erste Animation fertig ist. 
    //Die Einstellungen entsprechen dem "Nacht-Modus". 
    IEnumerator Switch1()
    {
        yield return new WaitForSeconds(250);
        sun.enabled = false;
        RenderSettings.skybox = skyboxNight;
        RenderSettings.ambientLight = fullDark;
        sign.GetComponent<Renderer>().material.mainTexture = commandment2;
        lightOn = false;
        night = true;
    }

    //Der zweite Wechsel (Nacht->Tag) findet nach 30 Sekunden statt, um dem Spieler etwas Zeit in der Nachtatmosphäre zu geben. 
    //Die Variablen werden wieder auf den "Tag-Modus" zurückgesetzt, nur die Commandments bleiben geändert. 
    IEnumerator Switch2()
    {
        yield return new WaitForSeconds(30);
        sun.enabled = true;
        RenderSettings.skybox = skyboxDay;
        RenderSettings.ambientLight = fullLight;
        lightOn = true;
        night = false;
        anim2ready = true;
    }

}
