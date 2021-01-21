using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacPlayer : playerPressE {
    [SerializeField] GameObject dialougeNPC;
    protected bool isTalk;
	// Use this for initialization
	void Start () {
        isTalk = false;
        dialougeNPC.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (isInteract)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                isTalk = true;
                dialougeNPC.SetActive(true);
            }
           
        }
        else
        {
            isTalk = false;
            dialougeNPC.SetActive(false);
        }
	}

}
