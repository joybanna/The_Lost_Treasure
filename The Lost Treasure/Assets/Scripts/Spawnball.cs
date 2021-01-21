using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnball : MonoBehaviour {
    [SerializeField] private GameObject ball;
    [SerializeField] private Transform pointball;
    private bool playerhit=false;
    private bool spawn = false;
	// Use this for initialization
	void Start () {
        Invoke("Spawn", 2);
    }
	
	// Update is called once per frame
	void Update () {
      
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            playerhit  = true;
        }
    }
  void Spawn()
    {
        print("ball");
        Instantiate(ball, pointball.position, Quaternion.identity);
        Invoke("Spawn", 5);
    }
}
