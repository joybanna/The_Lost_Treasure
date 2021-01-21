using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountOpen : MonoBehaviour {
    [Range(1,8)]
    [SerializeField] private int numcase = 0;
    [SerializeField] private GameObject LightOrb;
    
   
	// Use this for initialization
	void Start () {
        LightOrb.SetActive(false);
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
                
                switch (numcase)
                {
                    case 1:
                        LightOrb.SetActive(true);
                        ActionPlatform.open1 = true;
                        
                        print("1");
                        break;
                    case 2:
                        LightOrb.SetActive(true);
                        ActionPlatform.open2 = true;
                       
                        print("2");
                        break;
                    case 3:

                        LightOrb.SetActive(true);
                        ActionPlatform.open3 = true;
                        
                        print("3");
                        break;
                    case 4:
                        LightOrb.SetActive(true);
                        ActionPlatform.open4 = true;
                       
                        print("4");
                        break;
                    case 5:
                        LightOrb.SetActive(true);
                        ActionPlatform.open5 = true;

                        print("5");
                        break;
                    case 6:
                        LightOrb.SetActive(true);
                        ActionPlatform.open6 = true;

                        print("6");
                        break;
                    case 7:
                        LightOrb.SetActive(true);
                        ActionPlatform.open7 = true;

                        print("7");
                        break;
                    case 8:
                        LightOrb.SetActive(true);
                        ActionPlatform.open8 = true;

                        print("8");
                        break;
                }                                                        
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            PressE.show = false;
        }
    }
}
