using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBox : MonoBehaviour {
    [SerializeField] private GameObject teasurebox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        EventD1.AddListener(orbOpen);
	}
    void orbOpen(int numorb)
    {
        
    }

}
