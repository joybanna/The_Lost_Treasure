using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class switopen : MonoBehaviour {
    [SerializeField] private GameObject lights;
    [SerializeField] private GameObject door;
    [SerializeField] private Transform ponit;
    [SerializeField] private GameObject E;
    
    private bool doors=false;

    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        if (doors == true)
        {
            door.transform.Translate(door.transform.right*0.3f*Time.deltaTime);                    
        }
        
        
    }
        
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                lights.SetActive(true);
                doors = true;
            }                       
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(false);
            
        }
    }

}


