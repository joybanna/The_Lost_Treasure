using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour {
    [SerializeField] private GameObject dialogE;
    public static bool show;
	// Use this for initialization
	void Start () {
        show = false;
        dialogE.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        checkE();

    }
    void checkE()
    {
        if (show == true)
        {
            dialogE.SetActive(true);
        }
        else
        {
            dialogE.SetActive(false);
        }
    }
}
