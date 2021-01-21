using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrigerToChangeScene : MonoBehaviour {
    [SerializeField] private int Scene;
    public GameObject loading;
    // Use this for initialization
    void Start () {		
	}	
	// Update is called once per frame
	void Update () {		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            Loading();
        }
    }
    void Loading()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        loading.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(Scene);
    }
  
}
