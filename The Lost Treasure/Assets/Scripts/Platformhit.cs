using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformhit : MonoBehaviour {
    private int numStand = 2;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (numStand == 0)
        {
           gameObject.SetActive(false);
        }
        
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            numStand++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            numStand-=3;
        }
    }
}
