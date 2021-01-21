using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFootstep : MonoBehaviour {
   public AudioClip footSound;
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        sound.PlayOneShot(footSound);
    }
}
