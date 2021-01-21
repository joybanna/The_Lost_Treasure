using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnd : MonoBehaviour {
    [SerializeField] GameObject Endtext;
	// Use this for initialization
	void Start () {
        Endtext.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Endtext.SetActive(false);
        }
    }
}
