using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveChar : MonoBehaviour {
    private GameObject player;
    
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            print("iswork");
            player.transform.parent = transform;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.parent = null;
        }
            
    }
}
