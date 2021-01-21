using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Loadingtime());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Loadingtime()
    {
        yield return new WaitForSeconds(3);
        print("load");
    }
}
