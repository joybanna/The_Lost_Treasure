using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPressE : DetectPlayer {
    private GameObject Emassage;
    protected bool isInteract;
	// Use this for initialization
	void Start () {
        Emassage = GameObject.FindGameObjectWithTag("Emassage");
        isInteract = false;
        Emassage.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (isPlayer)
        {
            isInteract = true;
            Emassage.SetActive(true);
        }
        else
        {
            isInteract = false;
            Emassage.SetActive(true);
        }
	}

}
