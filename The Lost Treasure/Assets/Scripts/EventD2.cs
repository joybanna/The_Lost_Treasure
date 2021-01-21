using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventD2 : MonoBehaviour {
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject switch4;
    public GameObject switch5;
    public GameObject switch6;
    
    [HideInInspector]
    public static bool sun1 ;
    public static bool sun2 ;
    public static bool sun3 ;
    public static bool sun4 ;
    public static bool sun5 ;
    public static bool sun6 ;

    

    // Use this for initialization
    void Start () {
        sun1 = false;
        sun2 = false;
        sun3 = false;
        sun4 = false;
        sun5 = false;
        sun6 = false;
        switch1.SetActive(false);
        switch2.SetActive(false);
        switch3.SetActive(false);
        switch4.SetActive(false);
        switch5.SetActive(false);
        switch6.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        SwitchController();
    }
    void SwitchController()
    {
        if (sun1 == true)
        {
            switch1.SetActive(true);
        }
        if (sun2 == true)
        {
            switch2.SetActive(true);
        }
        if (sun3 == true)
        {
            switch3.SetActive(true);
        }
        if (sun4== true)
        {
            switch4.SetActive(true);
        }
        if (sun5 == true)
        {
            switch5.SetActive(true);
        }
        if (sun6 == true)
        {
            switch6.SetActive(true);
        }
    }
   
}
