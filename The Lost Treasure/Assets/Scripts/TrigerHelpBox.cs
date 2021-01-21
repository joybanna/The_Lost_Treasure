using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerHelpBox : MonoBehaviour {
    [SerializeField] private GameObject talk;
	// Use this for initialization
	void Start () {
        talk.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            talk.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            talk.SetActive(false);
        }
    }
}
