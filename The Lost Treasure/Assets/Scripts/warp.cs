using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour {
    [SerializeField] private GameObject pointwarp;
    private GameObject player;
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 V = pointwarp.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            player.transform.position = pointwarp.transform.position;
            
        }
    }
}
