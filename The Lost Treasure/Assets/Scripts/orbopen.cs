using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbopen : interacPlayer
{
    [SerializeField] private GameObject Lightorb;
    private bool islight;
	// Use this for initialization
	void Start () {
        Lightorb.SetActive(false);
        islight = false;
	}
	
	// Update is called once per frame
	void Update () {
        checkInterrac();
        if (islight)
        {
            Lightorb.SetActive(true);
        }
        else
        {
            Lightorb.SetActive(false);
        }
        
	}
    void checkInterrac()
    {
        if (isTalk)
        {
            islight = true;
        }
        else
        {
            islight = false;
        }
    }
}
