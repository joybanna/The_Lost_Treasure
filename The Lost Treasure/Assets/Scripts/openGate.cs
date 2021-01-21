using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour {
    public GameObject Gate;
    static public bool isGate;
	// Use this for initialization
	void Start () {
        isGate = false;
        Gate.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (isGate)
        {
            Gate.SetActive(true);
        }

	}
}
