using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSun : MonoBehaviour {
    [SerializeField] [Range(1, 6)] private int caseswitch = 6;
    [SerializeField] private GameObject sun;
    // Use this for initialization
    void Start () {
        sun.SetActive(false);
    }
	
	// Update is called once per frame
	
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PressE.show = true;
            if (Input.GetKey(KeyCode.E))
            {
                sun.SetActive(true);
                switch (caseswitch)
                {
                    case 1:
                        print("1");
                        EventD2.sun1 = true;
                        break;
                    case 2:
                        print("2");
                        EventD2.sun2 = true;
                        break;
                    case 3:
                        print("3");
                        EventD2.sun3 = true;
                        break;
                    case 4:
                        print("4");
                        EventD2.sun4 = true;
                        break;
                    case 5:
                        print("5");
                        EventD2.sun5 = true;
                        break;
                    case 6:
                        print("6");
                        EventD2.sun6 = true;
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
