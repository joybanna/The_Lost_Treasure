using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventState : MonoBehaviour {
    [SerializeField]private GameObject stateObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DayNightController2.isDay == true)
        {
            stateObj.SetActive(false);
            
        }
        else
        {
            
            stateObj.SetActive(true);
        }
	}
}
