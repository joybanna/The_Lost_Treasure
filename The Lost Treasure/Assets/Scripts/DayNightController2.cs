using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DayNightController2 : MonoBehaviour {
    public Light sun;
    public Material skybox1;
    public Material skybox2;
    public float secondsInFullDay = 120f;
    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    [HideInInspector]
    public float timeMultiplier = 1f;
    public Text timetext;
    static public bool isDay;
    float sunInitialIntensity;
    float hours;
    float min;   
    int fullH;
    int mins;
    
    
    
    void Start()
    {
       
        
        sunInitialIntensity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();
        UpdateTime();
    
        if (fullH > 6 && fullH < 18)
        {
            
            isDay = true;
            RenderSettings.skybox = skybox2;
        }
        else 
        {
            
            isDay = false;
            RenderSettings.skybox = skybox1;
        }
       
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);

        float intensityMultiplier = 1;
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        else if (currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        else if (currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }

        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
    void UpdateTime()
    {
        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;
        hours = currentTimeOfDay / (float)0.0417;
        min = currentTimeOfDay / (float)0.000694;
        mins = (int)min % 60;
        fullH = (int)hours;
        
        timetext.text = "H:" + fullH + ":M:" + mins;
        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }
}
