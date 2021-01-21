using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkdialouge : MonoBehaviour {
    [SerializeField] private GameObject textobj;    
	// Use this for initialization
	void Start () {
        textobj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PressE.show = true;
            if (Input.GetKeyUp(KeyCode.E))
            {
                textobj.SetActive(true);
            }
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textobj.SetActive(false);
            PressE.show = false;
        }

    }
}
