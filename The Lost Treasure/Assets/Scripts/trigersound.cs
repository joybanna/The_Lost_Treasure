using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigersound : MonoBehaviour {
    public AudioClip coinsound;
    private AudioSource consound;
	// Use this for initialization
	void Start () {
        consound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            consound.PlayOneShot(coinsound);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
