using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxfinal : MonoBehaviour {
    [SerializeField] private GameObject textBox;
	// Use this for initialization
	void Start () {
        textBox.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PressE.show = true;
            if (Input.GetKey(KeyCode.E))
            {
                ExpPlayer.isD1 = true;
                textBox.SetActive(true);
            }
                
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PressE.show = false;
            textBox.SetActive(false);
        }
    }
}
