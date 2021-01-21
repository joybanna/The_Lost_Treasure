using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {
    public AudioClip hurt;
    private AudioSource conHh;
    public int damagetoplayer=10;
	// Use this for initialization
	void Start () {
        conHh = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            conHh.PlayOneShot(hurt);
            playerstatus.takedamage(damagetoplayer);
        }
    }
}
