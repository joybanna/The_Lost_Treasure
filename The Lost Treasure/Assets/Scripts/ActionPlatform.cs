using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlatform : MonoBehaviour {
    public static int count = 0;
    GameObject platform1;
    int poitt = 1;
    public GameObject pointplatform1;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject lighttail1;
    public GameObject lighttail2;
    public GameObject lighttail3;
    public GameObject lighttail4;
    public GameObject Meteo;
    public GameObject Outgate;
    
    public static bool open1 = false;
    public static bool open2 = false;
    public static bool open3 = false;
    public static bool open4 = false;
    public static bool open5 = false;
    public static bool open6 = false;
    public static bool open7 = false;
    public static bool open8 = false;
    // Use this for initialization
    void Start () {
     open1 = false;
     open2 = false;
     open3 = false;
     open4 = false;
     open5 = false;
     open6 = false;
     open7 = false;
     open8 = false;
    platform1 = GameObject.FindGameObjectWithTag("Platform1");
	}
	
	// Update is called once per frame
	void Update () {
        StateOne();
        StateTwo();
        StateTree();
        StateFour();
       
    }
    void StateOne()
    {
        if (open1 == true || open2 == true)
        {
            Vector3 Point = pointplatform1.transform.position - platform1.transform.position;                     
            print(poitt);
            if (Point.y < -0.5 || Point.y > 0.5)
            {
                platform1.transform.Translate(0, 0.02f, 0, Space.World);
            }
            if (Point.y >= -0.5f || Point.y <= 0.5)
            {
                poitt = 0;
                if (poitt == 0)
                {
                    platform1.transform.Translate(Vector3.zero);
                }
            }
           
        }
    }
    void StateTwo()
    {
        if (open3 == true)
        {          
            Door1.transform.Translate(Vector3.down);
        }
        if (open4 == true)
        {
            Door2.transform.Translate(Vector3.down);
        }
    }
    void StateTree()
    {
        if (open5 == true)
        {
            print("5true");
            lighttail1.SetActive(true);
        }
        if (open6 == true)
        {
            print("6true");
            lighttail2.SetActive(true);
        }
        if (open7 == true)
        {
            print("7true");
            lighttail3.SetActive(true);
        }
        if (open8 == true)
        {
            print("8true");
            lighttail4.SetActive(true);
        }

    }
    void StateFour()
    {
        if(open5==true&& open6 == true && open7 == true && open8 == true)
        {
            StartCoroutine(timedelay());
        }
    }
    IEnumerator timedelay()
    {
        yield return new WaitForSeconds(5);
        Meteo.SetActive(true);
        Outgate.SetActive(true);
    }
    
}
