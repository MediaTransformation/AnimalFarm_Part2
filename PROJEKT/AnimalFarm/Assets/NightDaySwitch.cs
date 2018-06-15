using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDaySwitch : MonoBehaviour {

    public bool lightOn;
    public static bool night;
    public Light sun;
    public Material skyboxDay;
    public Material skyboxNight;

    public GameObject sign;
    public Texture commandment1;
    public Texture commandment2;

    public Color fullLight;
    public Color fullDark;

    // Use this for initialization
    void Start()
    {
        sun.enabled = true;
        RenderSettings.skybox = skyboxDay;
        RenderSettings.ambientLight = fullLight;
        sign.GetComponent<Renderer>().material.mainTexture = commandment1;
        lightOn = true;
        //StartCoroutine(Example());
    }

    void Update()
    {
        if (SceneTrigger.boxerGone == true)
        {
            StartCoroutine(Switch());
        }

        if (Input.GetKeyDown(KeyCode.F))
        {

            if (lightOn == false)
            {
                sun.enabled = false;
                RenderSettings.skybox = skyboxNight;
                RenderSettings.ambientLight = fullDark;
                sign.GetComponent<Renderer>().material.mainTexture = commandment2;
                lightOn = true;
            }
            else
            {
                sun.enabled = true;
                RenderSettings.skybox = skyboxDay;
                RenderSettings.ambientLight = fullLight;
                sign.GetComponent<Renderer>().material.mainTexture = commandment1;
                lightOn = false;
            }
        }

    }


    IEnumerator Switch()
    {
        yield return new WaitForSeconds(90);
        //print(Time.time);
        sun.enabled = false;
        RenderSettings.skybox = skyboxNight;
        RenderSettings.ambientLight = fullDark;
        sign.GetComponent<Renderer>().material.mainTexture = commandment2;
        lightOn = false;
        night = true;
    }

    /*
    void Start()
    {
        sun.enabled = true;
        RenderSettings.skybox = skyboxDay;
        lightOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (lightOn == false)
            {
                sun.enabled = false;
                RenderSettings.skybox = skyboxNight;
                RenderSettings.ambientLight = fullDark;
                lightOn = true;
            }
            else
            {
                sun.enabled = true;
                RenderSettings.skybox = skyboxDay;
                RenderSettings.ambientLight = fullLight;
                lightOn = false;
            }
        }
    }*/
}
