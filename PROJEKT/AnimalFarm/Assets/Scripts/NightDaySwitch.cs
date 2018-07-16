using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDaySwitch : MonoBehaviour {

    public bool lightOn;
    public static bool anim2ready;
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
        night = false;
        anim2ready = false;
        //StartCoroutine(Example());
    }

    void Update()
    {
        if (SceneTrigger.boxerGone == true && night == false)
        {

            StartCoroutine(Switch1());

        } else if(night == true)
        {
            StartCoroutine(Switch2());
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


    IEnumerator Switch1()
    {
        yield return new WaitForSeconds(250);
        //print(Time.time);
        sun.enabled = false;
        RenderSettings.skybox = skyboxNight;
        RenderSettings.ambientLight = fullDark;
        sign.GetComponent<Renderer>().material.mainTexture = commandment2;
        lightOn = false;
        night = true;
        SceneTrigger.boxerGone = false;
    }

    IEnumerator Switch2()
    {
        yield return new WaitForSeconds(30);
        //print(Time.time);
        sun.enabled = true;
        RenderSettings.skybox = skyboxDay;
        RenderSettings.ambientLight = fullLight;
        sign.GetComponent<Renderer>().material.mainTexture = commandment1;
        lightOn = false;
        night = false;
        anim2ready = true;
        
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
